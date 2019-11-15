'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 2/14/2018
' Description: Program2 
'              Class PHouse
' This class handles setting the number of rooms and garages and calculating the price.
' This class only handles houses of type Platteville.
'------------------------------------------------------------------------------------------------------------
Public Class PHouse

   Inherits House

   ' Handles setting the rooms and garages and calls setprice
   Public Sub New(ByVal id As String, ByVal type As String)
      MyBase.New(id, type)
      _rooms = 2
      _garages = 1
      setPrice()
   End Sub

   ' Handles calculating the price and throwing an exception if the rooms or garages are out of range
   ' Also calls sub to raise pricechanged
   Protected Overrides Sub setPrice()
      Dim temp = _price
      If (_garages = 3 Or _rooms = 4) Then
         Throw New Exception("OOR")
      Else
         _price = 200000 + ((_garages - 1) * 2500) + ((_rooms - 2) * 8000)
      End If
      If Not (temp = _price) Then
         If (temp > 0) Then
            subEvent()
         End If
      End If
   End Sub
End Class

'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 2/14/2018
' Description: Program2 
'              Class MHouse
' This class handles setting the number of rooms and garages and calculating the price.
' This class only handles houses of type Madison.
'------------------------------------------------------------------------------------------------------------
Public Class MHouse

   Inherits House

   ' Handles setting the rooms and garages and calls setprice
   Public Sub New(ByVal id As String, ByVal type As String)
      MyBase.New(id, type)
      _rooms = 2
      _garages = 1
      setPrice()
   End Sub

   ' Handles calculating the price and calling the sub to raise pricechanged
   ' Can't throw out of range exception because can accept any rooms or garages listed
   Protected Overrides Sub setPrice()
      Dim temp = _price
      _price = 300000 + ((_garages - 1) * 5000) + ((_rooms - 2) * 10000)
      If Not (temp = _price) Then
         If (temp > 0) Then
            subEvent()
         End If
      End If
   End Sub
End Class

'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 2/14/2018
' Description: Program2 
'              Class CHouse
' This class handles setting the number of rooms and garages and calculating the price.
' This class only handles houses of type Chicago.
'------------------------------------------------------------------------------------------------------------
Public Class CHouse

   Inherits House

   ' Handles setting the rooms and garages and calls setprice
   Public Sub New(ByVal id As String, ByVal type As String)
      MyBase.New(id, type)
      _rooms = 3
      _garages = 2
      setPrice()
   End Sub

   ' Handles calculating the price and throwing an exception if the rooms or garages are out of range
   ' Also calls sub to raise pricechanged
   Protected Overrides Sub setPrice()
      Dim temp = _price
      If (_garages = 1 Or _rooms = 2) Then
         Throw New Exception("OOR")
      End If
      If (_rooms = 3) Then
         If (_garages = 2) Then
            _price = 400000
         Else
            _price = 410000
         End If
      Else
         If (_garages = 2) Then
            _price = 420000
         Else
            _price = 428000
         End If
      End If
      If (Not (temp = _price)) Then
         If (temp > 0) Then
            subEvent()
         End If
      End If
   End Sub

End Class
