'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 3/20/2018
' Description: Program5 
'              Class ReaderWriterForm
'              This class is the form that is displayed.
'              It handles the buttons and adding things to the listboxes and textbox.
'------------------------------------------------------------------------------------------------------------
Imports System.Threading
Imports UWPCS3340

Public Class ReaderWriterForm
   Private db As New DatabaseClass(1000)
   Private WithEvents WR As ReaderWriter
   Private dummyThread As Thread
   Private Delegate Sub EnableButtons()
   Private variableDelegate As EnableButtons
   Protected _randomGenerator As New System.Random
   Private Delegate Sub WriteMSG()
   Private msg As WriteMSG

   ' Sets the database and the delegate to enable buttons
   Private Sub ReaderWriterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      variableDelegate = AddressOf SubToEnableButtons
      ReaderWriter.TheDatabase = db
   End Sub

   ' Creates a new reader, sets the mainform, sets the delegate, starts the thread
   Private Sub btnReader_Click(sender As Object, e As EventArgs) Handles btnReader.Click
      WR = New Reader()
      WR.MainForm = Me
      WR.DisplayMsg = AddressOf WriteMessage
      WR.SpinUp()
   End Sub

   ' Creates a new writer, sets the mainform, sets the delegate, starts the thread
   Private Sub btnWriter_Click(sender As Object, e As EventArgs) Handles btnWriter.Click
      WR = New Writer()
      WR.MainForm = Me
      WR.DisplayMsg = AddressOf WriteMessage
      WR.SpinUp()
   End Sub

   ' Creates a new thread to handle exiting, disables the buttons
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      dummyThread = New Thread(AddressOf ExitApplication)
      dummyThread.Start()
      btnExit.Enabled = False
      btnReader.Enabled = False
      btnWriter.Enabled = False
   End Sub

   ' Waits for readers and writers to finish, Displays a messagebox asking if you want to quit or not
   Private Sub ExitApplication()
      ReaderWriter.FinishReadWrite()
      Dim result As MsgBoxResult
      result = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
      If result = MsgBoxResult.Yes Then
         Application.Exit()
      Else
         Me.Invoke(variableDelegate)
         ReaderWriter.FinishReadWrite()
      End If
   End Sub

   ' Enables the buttons if they didn't want to exit
   Private Sub SubToEnableButtons()
      btnExit.Enabled = True
      btnReader.Enabled = True
      btnWriter.Enabled = True
   End Sub

   ' Handles updating the textbox and listboxes with the provided ID, state and total.
   ' Removes items as well
   Private Sub WriteMessage(ByVal theID As String, ByVal theState As ReaderWriter.State, ByVal theTotal As Integer)
      If (theState = ReaderWriter.State.Working) Then
         Dim index = lstWaiting.Items.IndexOf(theID)
         If (index > -1) Then
            lstWaiting.Items.RemoveAt(index)
         End If
         txtLog.Text &= theID & " :  Start to work: Total is " & theTotal & vbCrLf
         txtLog.SelectionStart = Len(txtLog.Text) - 1
         txtLog.ScrollToCaret()
         lstWorking.Items.Add(theID)
      ElseIf (theState = ReaderWriter.State.Finished) Then
         txtLog.Text &= theID & " :  Finished work: Total is " & theTotal & vbCrLf
         txtLog.SelectionStart = Len(txtLog.Text) - 1
         txtLog.ScrollToCaret()
         txtTotal.Text = db.TotalValue
         Dim index = lstWorking.Items.IndexOf(theID)
         If (index > -1) Then
            lstWorking.Items.RemoveAt(index)
         End If
      Else
         lstWaiting.Items.Add(theID)
      End If
   End Sub
End Class
