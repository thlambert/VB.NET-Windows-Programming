'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 3/20/2018
' Description: Program5 
'              Class Reader
'              This is a subclass of ReaderWriter and handles Reader properties and running.
'------------------------------------------------------------------------------------------------------------
Imports System.Threading

Public Class Reader

   Inherits ReaderWriter

   ' To get the ID
   Public Overrides ReadOnly Property ID As String
      Get
         Return "Reader_" & _thread.Name
      End Get
   End Property

   ' To get the Type
   Public Overrides ReadOnly Property type As ReaderWriterType
      Get
         Return ReaderWriterType.Reader
      End Get
   End Property

   ' This handles using monitor before accessing the queue and locking the total before accessing it.
   ' Generates the worktime, passes messages and wakes up the next reader/writer in the list if there is one.
   ' Wakes up multiple readers until a writer if possible
   Protected Overrides Sub run()

      _database.LockDataObj()
      Monitor.Enter(FIFOQueue)
      If (Not FIFOQueue.Count = 0 Or _database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Writing) Then
         FIFOQueue.Enqueue(Me)
         _mainForm.Invoke(_passMsg, ID, State.Waiting, _database.TotalValue)
         _database.ReleaseDataObj()
         Monitor.Exit(FIFOQueue)
         _ReaderWriterEvent.WaitOne()
         If (FIFOQueue.Count > 0) Then
            Dim n = FIFOQueue.Peek()
            If (n.type = ReaderWriterType.Reader) Then
               n = FIFOQueue.Dequeue()
               n.wakeup()
            End If
         End If
         _database.LockDataObj()
      Else
         Monitor.Exit(FIFOQueue)
      End If

      _database.IncreaseReaderCount()
      _database.ReleaseDataObj()
      _mainForm.Invoke(_passMsg, ID, State.Working, _database.TotalValue)

      Dim temp = _randomGenerator.Next(2000, 3000)
      Thread.Sleep(temp)
      _mainForm.Invoke(_passMsg, ID, State.Finished, _database.TotalValue)

      _database.LockDataObj()
      _database.DecreaseReaderCount()


      If (FIFOQueue.Count > 0 And _database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty) Then
         Dim n = FIFOQueue.Dequeue()
         n.WakeUp()
      End If


      _database.ReleaseDataObj()
      If (done = True) Then
         WakeupNextWhenExiting()
      End If
   End Sub
End Class