'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 3/20/2018
' Description: Program5 
'              Class DatabaseClass
'              This class handles mutual exclusion with the total and keeps track of what is in the database.
'------------------------------------------------------------------------------------------------------------
Imports System.Threading

Public Class DatabaseClass

   Public Enum DatabaseStatus
      Reading
      Writing
      Empty
   End Enum

   ' The data shared by all readers and writers
   Private _total As Integer

   ' To control data access 
   Private ReaderCount As Integer
   Private WriterCount As Integer

   ' To enforce mutual exclusion on ReaderCount and WriterCount
   Private DataObj As New Object

   ' Returns Reading when some readers are reading the database value,
   '         Writing when a writer is writing the database value,    
   '         Empty otherwise.
   Public ReadOnly Property TheDatabaseStatus As DatabaseStatus
      Get
         If (ReaderCount > 0) Then
            Return DatabaseStatus.Reading
         ElseIf (WriterCount > 0) Then
            Return DatabaseStatus.Writing
         Else
            Return DatabaseStatus.Empty
         End If
      End Get
   End Property

   ' Sets the total
   Public Sub New(t As Integer)
      _total = t
      DataObj = _total
   End Sub

   ' Enter Monitor before exclusive access to ReaderCount and WriterCount.
   Public Sub LockDataObj()
      Monitor.Enter(DataObj)
   End Sub

   ' Exit Monitor after exclusive access to ReaderCount and WriterCount.
   Public Sub ReleaseDataObj()
      Monitor.Exit(DataObj)
   End Sub

   ' Gets and sets the data value
   Public Property TotalValue As Integer
      Set(value As Integer)
         _total = value
      End Set
      Get
         Return _total
      End Get
   End Property

   ' Increments the ReaderCount by one
   Public Sub IncreaseReaderCount()
      ReaderCount += 1
   End Sub

   ' Decrements the ReaderCount by one.
   Public Sub DecreaseReaderCount()
      ReaderCount -= 1
   End Sub

   ' Increments the WriterCount by one.
   Public Sub IncreaseWriterCount()
      WriterCount += 1
   End Sub

   ' Decrements the WriterCount by one.
   Public Sub DecreaseWriterCount()
      WriterCount -= 1
   End Sub
End Class
