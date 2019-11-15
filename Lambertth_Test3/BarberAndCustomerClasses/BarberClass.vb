'------------------------------------------------------------------------------------------------------------
' Course     : CS 3340 
'
' Name       : Thomas Lambert
'
' Date       : March 22, 2018
'
' Description: Test 3
'              BarberClass
'------------------------------------------------------------------------------------------------------------

Imports System.Threading
Imports UWPCS3340

Public Class BarberClass

   Public Enum BarberState
      Open
      Working
      Sleeping
      Closing
      Closed
   End Enum

   Private _barberThread As Thread
   Private _barberMessage As BarberShopClass.PassMessage
   Private _mainForm As Form

   ' Indicates if the barber should exit from the while loop or not 
   Private _done As Boolean

   ' To wake up the barber.
   Friend barberEvent As New ManualResetEvent(False)

   ' Generates the amount of time needed for each haircut
   Private BarberRand As Random = New Random(Now.Second)

   ' The barber state is shared by all customers and the barber himself, 
   ' and Monitor must be used on "this" BarberClass object to enforce 
   ' mutual exclusion when accessing the state.
   ' The initial state is closed.
   Private _theState As BarberState = BarberState.Closed

   ' The property does not provide exclusive access to _theState, and
   ' Monitor must be used on "this" object to enforce mutual exclusion
   ' for any customer to access the state.
   Public Property TheState As BarberState
      Set(value As BarberState)
         _theState = value
      End Set
      Get
         Return _theState
      End Get
   End Property

   ' Sets the value for the PassMessage delegate.
   Public WriteOnly Property BarberMessage As BarberShopClass.PassMessage
      Set(value As BarberShopClass.PassMessage)
         _barberMessage = value
      End Set
   End Property

   ' Sets the value for _mainForm to invoke delegate.
   Public WriteOnly Property MainForm As Form
      Set(value As Form)
         _mainForm = value
      End Set
   End Property

   ' Creates a new barber thread, sets _done to false and the state to Open,
   ' then starts the barber thread
   Public Sub OpenBarberShop()

      _barberThread = New Thread(AddressOf run)
      _done = False
      TheState = BarberState.Open
      _barberThread.Start()

   End Sub

   ' Sets the state to Closing, wakes up the barber thread, 
   ' and waits until the barber thread is terminated
   Public Sub CloseBarberShop()

      Monitor.Enter(Me)
      _theState = BarberState.Closing
      Monitor.Exit(Me)

      barberEvent.Set()

      ' Waits here until the barber thread is terminated.
      _barberThread.Join()
   End Sub

   ' It will be called from the main form when the user wants to exit before 
   ' the barber shop is open, since some customers might be waiting.
   ' It removes the customers from the queue, one by one, and wakes up the customer 
   ' with parameter telling the customer that hair cut is not done. 
   ' So the customer thread will terminate before the program can be terminated.
   Public Shared Sub ClearCustomerQueue()
      Monitor.Enter(BarberShopClass.CustomerQueue)
      While (BarberShopClass.CustomerQueue.Count > 0)
         Dim temp As CustomerClass = BarberShopClass.CustomerQueue.Dequeue()
         temp.WakeUp(False)
      End While
      Monitor.Exit(BarberShopClass.CustomerQueue)
   End Sub

   ' Remember to use Monitor on the customer queue to enforce mutual exclusion.
   Private Sub run()
      While (_done = False)
         Monitor.Enter(Me)
         If (TheState = BarberState.Open) Then
            _mainForm.Invoke(_barberMessage, "The Barber Shop Is Now Open.")
            TheState = BarberState.Working
            Monitor.Exit(Me)
         ElseIf (TheState = BarberState.Sleeping) Then
            _mainForm.Invoke(_barberMessage, "The Barber Goes to Sleep.")
            barberEvent.Reset()
            Monitor.Exit(Me)
            barberEvent.WaitOne()
         ElseIf (TheState = BarberState.Closing) Then
            _mainForm.Invoke(_barberMessage, "The Barber Shop Is Now Closing.")
            Monitor.Exit(Me)
            FinishingAll()
            Monitor.Enter(Me)
            TheState = BarberState.Closed
            Monitor.Exit(Me)
         ElseIf (TheState = BarberState.Closed) Then
            _mainForm.Invoke(_barberMessage, "The Barber Shop Is Now Closed.")
            _done = True
            Monitor.Exit(Me)
         ElseIf (TheState = BarberState.Working) Then
            Monitor.Exit(Me)
            Monitor.Enter(BarberShopClass.CustomerQueue)
            If (BarberShopClass.CustomerQueue.Count < 1) Then
               Monitor.Enter(Me)
               TheState = BarberState.Sleeping
               Monitor.Exit(Me)
               Monitor.Exit(BarberShopClass.CustomerQueue)
            Else
               Dim temp As CustomerClass = BarberShopClass.CustomerQueue.Dequeue
               Monitor.Exit(BarberShopClass.CustomerQueue)
               CutHairForOneCustomer(temp)
            End If
         End If
      End While
   End Sub

   ' Does haircut for one customer, 
   ' including passing messages before and after the haircut
   ' and waking up the customer
   Private Sub CutHairForOneCustomer(ByVal c As CustomerClass)
      ' Pass a message "Cut Hair for Customer " followed by the customer’s ID
      ' The barber needs 2 – 5 seconds for a customer 
      ' Pass a message "Finished Hair Cut for Customer " followed by ID
      ' Wake up the customer with parameter that hair cut is done

      _mainForm.Invoke(_barberMessage, "Cut Hair for Customer " & c.ID)
      Thread.Sleep(BarberRand.Next(3000, 5000))
      _mainForm.Invoke(_barberMessage, "Finished Hair Cut for Customer " & c.ID)
      c.WakeUp(True)

   End Sub

   ' Should be called after the barber shop is closing to do hair cut 
   ' for all waiting customers.
   ' The state has been set to Closing, and no customers will enter 
   ' the CustomerQueue and no Monitor is needed.
   Private Sub FinishingAll()

      BarberShopClass.CustomerQueue.Clear()


   End Sub
End Class
