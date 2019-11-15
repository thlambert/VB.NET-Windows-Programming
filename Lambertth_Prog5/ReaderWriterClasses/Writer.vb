'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 3/20/2018
' Description: Program5 
'              Class Writer
'              This is a subclass of ReaderWriter and handles Writer properties and running.
'------------------------------------------------------------------------------------------------------------
Imports System.Threading
Public Class Writer

   Inherits ReaderWriter

   ' To get the ID
   Public Overrides ReadOnly Property ID As String
      Get
         Return "Writer_" & _thread.Name
      End Get
   End Property

   ' To get the Type
   Public Overrides ReadOnly Property type As ReaderWriterType
      Get
         Return ReaderWriterType.Writer
      End Get
   End Property

   ' This handles using monitor before accessing the queue and locking the total before accessing it.
   ' Generates the worktime, passes messages and wakes up the next reader/writer in the list if there is one.
   Protected Overrides Sub run()
      _database.LockDataObj()
      Monitor.Enter(FIFOQueue)
      If (Not (FIFOQueue.Count = 0) Or Not (_database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty)) Then
         FIFOQueue.Enqueue(Me)
         _mainForm.Invoke(_passMsg, ID, State.Waiting, _database.TotalValue)
         _database.ReleaseDataObj()
         Monitor.Exit(FIFOQueue)
         _ReaderWriterEvent.WaitOne()
         _database.LockDataObj()
      Else
         Monitor.Exit(FIFOQueue)
      End If

      _database.IncreaseWriterCount()
      _database.ReleaseDataObj()
      _mainForm.Invoke(_passMsg, ID, State.Working, _database.TotalValue)

      Dim temp = _randomGenerator.Next(3000, 4000)
      Thread.Sleep(temp)
      temp = _randomGenerator.Next(-10, 10)
      _database.TotalValue = _database.TotalValue + temp

      _mainForm.Invoke(_passMsg, ID, State.Finished, _database.TotalValue)
      _database.LockDataObj()
      _database.DecreaseWriterCount()
      If (FIFOQueue.Count > 0) Then
         Dim obj = FIFOQueue.Dequeue()
         obj.wakeup()
      End If
      _database.ReleaseDataObj()
      If (done = True) Then
         WakeupNextWhenExiting()
      End If
   End Sub
End Class
