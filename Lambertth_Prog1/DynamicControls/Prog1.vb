'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 1/31/2018
' Description: Program1
'              Class Prog1
' This program illustrates creating controls dynamically as well as managing the properties of dynamically created controls.
' This class creates the two forms and starts the program on the create form.
'------------------------------------------------------------------------------------------------------------
Public Class Prog1
   'Main sub
   Public Shared Sub main()
      Dim ClassShowForm = New FormClassShow
      Dim ClassCreateForm = New FormClassCreate
      Application.Run(ClassCreateForm)
   End Sub
End Class
