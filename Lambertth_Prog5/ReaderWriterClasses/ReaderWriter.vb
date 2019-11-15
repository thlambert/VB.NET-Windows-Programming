'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 3/20/2018
' Description: Program5 
'              Class ReaderWriter
'              This class is the parent class to Reader and Writer. 
'              Handles accessing the database and the mainform.
'------------------------------------------------------------------------------------------------------------
Imports System.Threading
Imports System.Windows.Forms
Public MustInherit Class ReaderWriter
   Public Enum ReaderWriterType
      Reader
      Writer
   End Enum

   Public Enum State
      Waiting
      Working
      Finished
   End Enum

   Protected _thread As Thread
   Protected _passMsg As PassMessage
   Protected _mainForm As form
   Protected _ReaderWriterEvent As New AutoResetEvent(False)
   Protected _randomGenerator As New Random
   Protected Shared done As Boolean = False
   Protected Shared FIFOQueue As New Queue
   Protected Shared _database As DatabaseClass
   Private Shared endProgram As New AutoResetEvent(False)

   Public Delegate Sub PassMessage(ByVal theID As String,
                                   ByVal theState As State,
                                   ByVal theTotal As Integer)

   ' Handled in the subclass
   Public MustOverride ReadOnly Property ID() As String

   ' Handled in the subclass
   Public MustOverride ReadOnly Property type() As ReaderWriterType

   ' To set the database
   Public Shared WriteOnly Property TheDatabase() As DatabaseClass
      Set(value As UWPCS3340.DatabaseClass)
         _database = value
      End Set
   End Property

   ' To set the message
   Public WriteOnly Property DisplayMsg() As PassMessage
      Set(value As PassMessage)
         _passMsg = value
      End Set
   End Property

   ' To set the mainform
   Public WriteOnly Property MainForm() As Form
      Set(value As System.Windows.Forms.Form)
         _mainForm = value
      End Set
   End Property

   ' Handles naming the thread
   Public Sub New()
      _thread = New Thread(AddressOf run)
      _thread.Name = "TH" & _thread.GetHashCode
   End Sub

   ' When a writer or a reader exits the database and no other readers/writers
   ' are in the database, the writer or reader wakes up the the first reader/writer 
   ' in the waiting queue.
   ' If the queue is empty, sets endProgram to signalled (green), since it's 
   ' possible that a thread is waiting for all readers/writers to finish the work.
   ' Mutual exclusion on the queue must be enforced.
   Protected Shared Sub WakeupNextWhenExiting()
      Monitor.Enter(FIFOQueue)
      If (FIFOQueue.Count = 0 And _database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty) Then
         endProgram.Set()
      End If
      Monitor.Exit(FIFOQueue)
   End Sub

   ' Waits for all readers and writers to finish the work in order to terminate 
   ' the program.
   Public Shared Sub FinishReadWrite()
      If (done = True) Then
         done = False
      ElseIf (FIFOQueue.Count = 0 And _database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty) Then

      Else
         done = True
         endProgram.WaitOne()
      End If
      'If (FIFOQueue.Count = 0 And _database.TheDatabaseStatus = DatabaseClass.DatabaseStatus.Empty) Then

      'Else
      '   endProgram.WaitOne()
      'End If
   End Sub

   ' Starts the thread
   Public Overridable Sub SpinUp()
      _thread.Start()
   End Sub

   ' Signals the ReaderWriterEvent which allows the next reader/writer in the queue to start working
   Public Sub WakeUp()
      _ReaderWriterEvent.Set()
   End Sub

   Protected MustOverride Sub run()

End Class
