'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 3/11/2018
' Description: Program4 
'              Class FormClassThread
' This class handles manipulating the form.
'------------------------------------------------------------------------------------------------------------
Imports System.Threading
Imports UWPCS3340
Public Class FormClassThread
   Private WithEvents newuser As UserAccount
   Private total As Integer = 0
   Private balance As Integer = 1000
   Private newThread As Thread
   'Private startsub As ThreadStart
   Private dummyThread As Thread
   Private Delegate Sub EnableButtons()
   Private variableDelegate As EnableButtons

   ' Creates a new UserAccount, assigns the delegates to the appropriate methods, sets the main form and calls spin up
   Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
      newuser = New UserAccount()
      newuser.TheReport = AddressOf output
      newuser.TheTransaction = AddressOf work
      newuser.MainForm = Me
      newuser.SpinUp()
   End Sub

   ' If something is selected, sets the correct UserAccount to wait
   Private Sub btnWait_Click(sender As Object, e As EventArgs) Handles btnWait.Click
      If Not (lstAllUsers.SelectedIndex() = -1) Then
         newuser = UserAccount.GetUserByIndex(lstAllUsers.SelectedIndex())
         newuser.UserWait()
      End If
   End Sub

   ' If something is selected, sets the correct UserAccount to continue
   Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
      If Not (lstAllUsers.SelectedIndex() = -1) Then
         newuser = UserAccount.GetUserByIndex(lstAllUsers.SelectedIndex())
         newuser.UserContinue()
      End If
   End Sub

   ' If something is selected, sets the correct UserAccount to terminate
   Private Sub btnTerminate_Click(sender As Object, e As EventArgs) Handles btnTerminate.Click
      If Not (lstAllUsers.SelectedIndex = -1) Then
         Dim u As UserAccount
         u = UserAccount.GetUserByIndex(lstAllUsers.SelectedIndex())
         u.SpinDown()
      End If
   End Sub

   ' Creates a dummy thread to exit the application and disables all the buttons
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      dummyThread = New Thread(AddressOf ExitApplication)
      dummyThread.Start()
      btnContinue.Enabled = False
      btnCreate.Enabled = False
      btnExit.Enabled = False
      btnTerminate.Enabled = False
      btnWait.Enabled = False
   End Sub

   ' Sets the main thread name, sets the text box intial amounts and sets the VariableDelegate
   Private Sub FormClassThread_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Thread.CurrentThread.Name = "Main" & Thread.CurrentThread.GetHashCode()
      variableDelegate = AddressOf SubToEnableButtons
      txtTransaction.Text = FormatCurrency(total, 2)
      txtBalance.Text = FormatCurrency(balance, 2)
   End Sub

   ' Enables the buttons
   Private Sub SubToEnableButtons()
      btnCreate.Enabled = True
      btnWait.Enabled = True
      btnContinue.Enabled = True
      btnTerminate.Enabled = True
      btnExit.Enabled = True
   End Sub

   ' Changes the listbox based on the new UserState, can remove users from the listbox
   Private Sub output(ByVal ID As String, ByVal State As UWPCS3340.UserAccount.UserState)
      Dim temp1 As Integer = -1
      For index As Integer = 0 To lstAllUsers.Items.Count - 1
         Dim temp As String = lstAllUsers.Items(index).ToString
         If temp.Contains(ID) Then
            temp1 = index
         End If
      Next

      If Not (temp1 = -1) Then
         If (State = UserAccount.UserState.Terminated) Then
            Try
               lstAllUsers.Items.RemoveAt(lstAllUsers.SelectedIndex())
            Catch ex As Exception
               lstAllUsers.Items.RemoveAt(temp1)
            End Try
         ElseIf (State = UserAccount.UserState.Waiting) Then
               lstAllUsers.Items(lstAllUsers.SelectedIndex) = (ID & ": Waiting")
            Else
               lstAllUsers.Items(lstAllUsers.SelectedIndex) = (ID & ": Working")
         End If
      Else
         lstAllUsers.Items.Add(ID & ": Working")
         txtLog.Text &= (ID & ": started working" & vbCrLf)
      End If
   End Sub

   ' Adds the transactions to the textbox and scrolls to caret
   ' Also changes the balance and transaction total textboxes
   Private Sub work(ByVal ID As String, ByVal Amount As Integer, ByVal Final As Boolean)
      If Final = False Then
         txtLog.Text &= ID & ": " & Amount & vbCrLf
         balance += Amount
         txtBalance.Text = FormatCurrency(balance, 2)
      Else
         txtLog.Text &= ID & ": Total transaction - " & FormatCurrency(Amount, 2) & vbCrLf
         total += Amount
         txtTransaction.Text = FormatCurrency(total, 2)
      End If
      txtLog.SelectionStart = Len(txtLog.Text) - 1
      txtLog.ScrollToCaret()
   End Sub

   ' Handles closing the application using a dummy thread
   Sub ExitApplication()
      ' Thread dummyThread waiting here for all worker threads to finish
      UserAccount.TerminateAllUsers()

      Dim result As Microsoft.VisualBasic.MsgBoxResult
      result = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo)
      If result = MsgBoxResult.Yes Then
         Application.Exit()
      Else
         Me.Invoke(variableDelegate)
      End If
   End Sub
End Class
