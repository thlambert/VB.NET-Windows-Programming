'------------------------------------------------------------------------------------------------------------
' Course     : CS 3340 
'
' Name       : Thomas Lambert
'
' Date       : March 22, 2018
'
' Description: Test 3
'              GUI Form1 
'------------------------------------------------------------------------------------------------------------

Imports System.Threading
Imports UWPCS3340

Public Class Form1

   Dim barber As UWPCS3340.BarberClass
   Dim customer As UWPCS3340.CustomerClass

   Private Delegate Sub EnableButtons()
   Private dummyThread As Thread
   Private toEnableButtons As EnableButtons

   ' Creates a new object of BarberClass and assigns to variable barber and sets its properties.
   ' Assigns barber to NewBarber of BarberShopClass.
   ' Also sets the value of toEnableButtons to ResetButtons.
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      barber = New BarberClass
      barber.MainForm = Me
      barber.BarberMessage = AddressOf HandleMessage
      BarberShopClass.NewBarber = barber
      toEnableButtons = AddressOf ResetButtons
   End Sub

   Private Sub ResetButtons()
      btnOpen.Enabled = True
      btnExit.Enabled = True

      btnNew.Enabled = True
      btnClose.Enabled = False
   End Sub

   ' Opens the Barbershop: 
   '           Clear txtLog, but not lstWaiting
   '           Disable btnOpen And btnExit, but enable btnNew And btnClose
   '           Call OpenBarberShop on the barber.
   Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
      txtLog.Clear()
      btnOpen.Enabled = False
      btnExit.Enabled = False

      btnNew.Enabled = True
      btnClose.Enabled = True

      barber.OpenBarberShop()
   End Sub


   ' Closes the BarberShop: 
   '            Disable btnClose, btnExit And btnOpen, but enable btnCustomer.
   '            Creates a new thread object for dummyThread 
   '               and starts the new thread.
   Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
      btnClose.Enabled = False
      btnExit.Enabled = False
      btnOpen.Enabled = False
      dummyThread = New Thread(AddressOf closeShop)
      dummyThread.Start()
   End Sub

   ' The delegate sub for dummyThread.
   '            Calls CloseBarberShop on barber
   '            Invokes toEnableButtons on the form.
   Private Sub closeShop()
      barber.CloseBarberShop()
      Me.Invoke(toEnableButtons)
   End Sub

   ' Creates a new customer, sets the properties, and spin up the customer.
   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      customer = New CustomerClass()
      customer.CustomerMessage = AddressOf HandleMessage
      customer.MainForm = Me
      customer.SpinUp()
   End Sub

   ' Exiting the program:
   '         Calls ClearCustomerQueue of BarberClass 
   '         Uses a message box With Yes/No To ask the user If To terminate.
   '         Terminates the program if the user selects Yes, and continues otherwise.
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      BarberClass.ClearCustomerQueue()
      Dim result As MsgBoxResult
      result = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
      If result = MsgBoxResult.Yes Then
         Application.Exit()
      End If
   End Sub

   ' The delegate sub for the barber and all customers.
   Private Sub HandleMessage(ByVal msg As String)
      ' If msg contains "Waiting for the Barber" or "Waking up the Barber"
      '    add msg to lstWaiting
      ' Else if msg contains "Cut Hair for Customer" Or "without hair cut"
      '    remove the first item from lstWaiting
      '
      ' If msg does not contain "Waiting for the Barber"
      '    add msg to the end of txtLog
      '    scroll down txtLog to show the new added msg 
      If (msg.Contains("Waiting for the Barber") Or msg.Contains("Waking up the Barber")) Then
         lstWaiting.Items.Add(msg)
      ElseIf (msg.Contains("Cut Hair for Customer") Or msg.Contains("without hair cut")) Then
         lstWaiting.Items.RemoveAt(0)
      End If

      If Not (msg.Contains("Waiting for the Barber")) Then
         txtLog.Text &= msg & vbCrLf
         txtLog.SelectionStart = Len(txtLog.Text) - 1
         txtLog.ScrollToCaret()
      End If
   End Sub
End Class
