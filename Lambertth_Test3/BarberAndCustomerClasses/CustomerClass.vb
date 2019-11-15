'------------------------------------------------------------------------------------------------------------
' Course     : CS 3340 
'
' Name       : Thomas Lambert
'
' Date       : March 22, 2018
'
' Description: Test 3
'              CustomerClass
'------------------------------------------------------------------------------------------------------------

Imports System.Threading

Public Class CustomerClass
   Private _customerThread As Threading.Thread
   Private _customerMessage As BarberShopClass.PassMessage
   Private _mainForm As Form
   Private customerEvent As New ManualResetEvent(False)

   ' Indicates whether a haircut is done or not for the customer
   Private hairCutDone As Boolean

   ' Sets the delegate member that will be used to pass customer messages
   Public WriteOnly Property CustomerMessage As BarberShopClass.PassMessage
      Set(value As BarberShopClass.PassMessage)
         _customerMessage = value
      End Set
   End Property

   ' Sets the Form member that will be used to invoke the delegate
   Public WriteOnly Property MainForm As Form
      Set(value As Form)
         _mainForm = value
      End Set
   End Property

   ' Returns your initials followed by the hash code of the customer thread object
   ' Example: QY47
   ' You MUST use your own initial, not "QY" for the ID.
   Public ReadOnly Property ID As String
      Get
         Return "TH" & _customerThread.GetHashCode
      End Get
   End Property

   ' Creates a new customer thread object and starts the thread.
   Public Sub SpinUp()
      _customerThread = New Thread(AddressOf run)
      _customerThread.Start()
   End Sub

   ' Wakes up the customer with one parameter as Boolean to indicate 
   ' if hair cut is done or not
   Friend Sub WakeUp(ByVal hadHaircut As Boolean)
      hairCutDone = hadHaircut
      customerEvent.Set()
   End Sub

   ' You MUST lock object theBarber of BarberShopClass before accessing its state
   ' and release the object after accessing in order to enforce mutual exclusion.
   ' The same applies to the customer queue.
   Private Sub run()

      'If the barber state is Closing
      '   Pass a message "New Customer ID: Coming Tomorrow."
      'Else
      '   Put the customer itself into the customer queue
      '   Reset customerEvent
      '   If the barber state is Sleeping
      '      Pass a message "New Customer ID: Waking up the Barber."
      '      Set the barber state to Working
      '      Wake up the barber
      '   Else
      '      Pass a message "New Customer ID: Waiting for the Barber."
      '
      '   Wait on customerEvent
      '
      '   If hair cut is done (after being waked up)
      '      Pass a message "Customer ID: Going home after hair cut."
      '   Else
      '      Pass a message "Customer ID: Going home without hair cut." 

      'The ID in the messages should be the string from the ID property.
      Monitor.Enter(BarberShopClass.theBarber)
      If (BarberShopClass.theBarber.TheState = BarberClass.BarberState.Closing) Then
         _mainForm.Invoke(_customerMessage, ID & ": Coming Tomorrow. ")
      Else
         BarberShopClass.CustomerQueue.Enqueue(Me)
         customerEvent.Reset()
         If (BarberShopClass.theBarber.TheState = BarberClass.BarberState.Sleeping) Then
            _mainForm.Invoke(_customerMessage, ID & ": Waking up the Barber.")
            'Monitor.Enter(BarberShopClass.theBarber)
            BarberShopClass.theBarber.TheState = BarberClass.BarberState.Working
            Monitor.Exit(BarberShopClass.theBarber)
            BarberShopClass.theBarber.barberEvent.Set()
         Else
            Monitor.Exit(BarberShopClass.theBarber)
            _mainForm.Invoke(_customerMessage, ID & ": Waiting for the Barber.")
         End If

         customerEvent.WaitOne()

         If (hairCutDone) Then
            _mainForm.Invoke(_customerMessage, ID & ": Going home after hair cut.")
         Else
            _mainForm.Invoke(_customerMessage, ID & ": Going home without hair cut.")
         End If
      End If
   End Sub
End Class
