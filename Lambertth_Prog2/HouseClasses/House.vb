'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 2/14/2018
' Description: Program2 
'              Class House
' This class handles the creation of houses and all properties of houses such as Type.
'------------------------------------------------------------------------------------------------------------
Public MustInherit Class House

   Protected _price As Integer
   Protected _garages As Integer
   Protected _rooms As Integer
   Protected _type As String
   Protected _id As String
   Dim temp As Integer
   Private Shared AllHouses As List(Of House) = New List(Of House)

   ' Returns the total count of created house objects.
   Public Shared ReadOnly Property TotalCount As Integer
      Get
         Return AllHouses.Count
      End Get
   End Property

   ' Returns the house at the specified index. 
   Public Shared ReadOnly Property HouseByIndex(ByVal index As Integer) As House
      Get
         HouseByIndex = AllHouses.Item(index)
      End Get
   End Property

   ' Returns the type of the house EX. Chicago
   Public ReadOnly Property Type As String
      Get
         Return _type
      End Get
   End Property

   'Returns the ID of the house
   Public ReadOnly Property ID As String
      Get
         Return _id
      End Get
   End Property

   ' Returns the number of rooms
   ' Can also set the number of rooms which calls setPrice
   Public Property Rooms As Integer
      Get
         Return _rooms
      End Get
      Set(value As Integer)
         _rooms = value
         setPrice()
      End Set
   End Property

   ' Returns the number of garages
   ' Can also set the number of garages which calls setPrice
   Public Property Garages As Integer
      Get
         Return _garages
      End Get
      Set(value As Integer)
         _garages = value
         setPrice()
      End Set
   End Property

   ' Returns the calculated price
   Public ReadOnly Property Price As Single
      Get
         Return _price
      End Get
   End Property

   ' Calculates the price based on the number of rooms and number of garages.
   ' Event PriceChanged will be raised if the new calculated price is different 
   ' from the old price.
   ' It will be called after setting rooms and garages.
   ' Handled in the subclasses
   Protected Overridable Sub setPrice()

   End Sub

   ' Raised when the price of the house changed.
   Public Event PriceChanged()

   ' Sub used to raise PriceChanged event
   Protected Sub subEvent()
      RaiseEvent PriceChanged()
   End Sub

   ' Handles creating a new House object
   ' Checks the length of the ID, checks for duplicate ID's, Checks for non-digit or non-number characters
   ' Sets the ID and type of the house
   ' Can throw exceptions if incorrect id
   Public Sub New(ByVal id1 As String, ByVal type1 As String)
      _id = id1
      ' Check length
      If Not (_id.Length = 5) Then
         Throw New Exception("IDL")
      End If
      ' Check for duplicate ID's
      For index As Integer = 0 To AllHouses.Count - 1
         If (AllHouses.Item(index).ID = id1) Then
            Throw New Exception("Dupe")
         End If
      Next
      ' check for symbols
      Dim temp1 As Char = id1.Substring(0, 1)
      Dim temp2 As Char = id1.Substring(1, 1)
      Dim temp3 As Char = id1.Substring(2, 1)
      Dim temp4 As Char = id1.Substring(3, 1)
      Dim temp5 As Char = id1.Substring(4, 1)
      If Not (Char.IsLetterOrDigit(temp1) And Char.IsLetterOrDigit(temp2) And Char.IsLetterOrDigit(temp3) And
             Char.IsLetterOrDigit(temp4) And Char.IsLetterOrDigit(temp5)) Then
         Throw New Exception("S")
      End If
      _type = type1
      AllHouses.Add(Me)
   End Sub

End Class