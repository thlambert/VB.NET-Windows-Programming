'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 3/11/2018
' Description: Program4 
'              Class UserAccount
' This class the creation of UserAccounts and all properties of them.
'------------------------------------------------------------------------------------------------------------
Imports System.Windows.Forms
Imports System.Threading
Public Class UserAccount
   Public Enum UserState
      Working
      Waiting
      Terminated
   End Enum
   Public Delegate Sub TransactionDelegate(ByVal ID As String, ByVal Amount As Integer,
                                           ByVal Final As Boolean)
   Public Delegate Sub PassMessageDelegate(ByVal ID As String, ByVal State As UserState)
   Private done As Boolean = False
   Private Shared AllUsers As New List(Of UserAccount)
   Private _thread As System.Threading.Thread
   Private _id As String
   Private _mainForm As System.Windows.Forms.Form
   Private _state As UserState
   Private _workTime As Integer
   Private _transactionAmount As Integer
   Private _totalTransactionAmount As Integer = 0
   Private _trans As TransactionDelegate
   Private _report As PassMessageDelegate
   Private _randomGenerator As New System.Random
   Private _userWait As New ManualResetEvent(False)
   Private Shared _allTerminated As New ManualResetEvent(False)

   ' To set the value of _mainForm.
   Public WriteOnly Property MainForm As System.Windows.Forms.Form
      Set(value As System.Windows.Forms.Form)
         _mainForm = value
      End Set
   End Property

   ' To set the value for delegate _trans.
   Public WriteOnly Property TheTransaction As TransactionDelegate
      Set(value As TransactionDelegate)
         _trans = (value)
      End Set
   End Property

   ' To Set the value of delegate _report.
   Public WriteOnly Property TheReport As PassMessageDelegate
      Set(value As PassMessageDelegate)
         _report = value
      End Set
   End Property

   ' Creates an Thread object and sets the thread name 
   Public Sub New()
      _thread = New Thread(AddressOf run)
      _thread.Name = "TH" & _thread.GetHashCode
      _id = _thread.Name
   End Sub

   ' To start the user thread.
   Public Sub SpinUp()
      _thread.Start()
   End Sub

   ' To terminate the user.
   Public Sub SpinDown()
      _userWait.Set()
      _state = UserState.Terminated
      done = True
   End Sub

   ' To suspend the user.
   Public Sub UserWait()
      If Not (_state = UserState.Waiting) Then
         _state = UserState.Waiting
         _userWait.Reset()
      End If
   End Sub

   ' To wake up the user.
   Public Sub UserContinue()
      If Not (_state = UserState.Working) Then
         _state = UserState.Working
         _userWait.Set()
         '_mainForm.Invoke(_report, _id, _state)
      End If
   End Sub

   ' To terminate all user threads.
   Public Shared Sub TerminateAllUsers()
      If AllUsers.Count > 0 Then
         ' What if you comment out Reset?
         _allTerminated.Reset()

         For index = AllUsers.Count - 1 To 0 Step -1
            Dim w As UserAccount
            w = AllUsers(index)
            w.SpinDown()
         Next

         ' The main thread is waiting here before all worker threads terminated
         _allTerminated.WaitOne()
      End If
   End Sub

   ' To get the UserAccount object at a given index of list AllUsers.
   Public Shared Function GetUserByIndex(ByVal index As Integer) As UserAccount
      Return AllUsers(index)
   End Function

   ' Handles running the threads. Adds a user to the list, does the work based on the UserState, removes user from the list after the while
   Private Sub run()
      Static count As Integer

      AllUsers.Add(Me)
      _mainForm.Invoke(_report, _id, _state)
      While Not done
         _workTime = _randomGenerator.Next(3, 5)
         If (_state = UserState.Waiting) Then
            _mainForm.Invoke(_report, _id, _state)
            _userWait.WaitOne()
            _mainForm.Invoke(_report, _id, _state)
         End If
         Thread.Sleep(_workTime * 1000)
         count += 1
         _transactionAmount = _randomGenerator.Next(-100, 100)
         _totalTransactionAmount += _transactionAmount
         If (done = True) Then
            done = False
            _mainForm.Invoke(_trans, _id, _transactionAmount, done)
            done = True
         Else
            _mainForm.Invoke(_trans, _id, _transactionAmount, done)
         End If
      End While

      ' Remove the worker object from the list just before the thread finishes its work
      _mainForm.Invoke(_trans, _id, _totalTransactionAmount, done)
      _mainForm.Invoke(_report, _id, _state)
      AllUsers.Remove(Me)
      If AllUsers.Count = 0 Then
         _allTerminated.Set()
      End If
   End Sub
End Class
