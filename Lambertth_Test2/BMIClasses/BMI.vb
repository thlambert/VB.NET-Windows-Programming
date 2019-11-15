'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: March 1, 2018
' Description: Test 2
'              Base class BMI
'------------------------------------------------------------------------------------------------------------


Public MustInherit Class BMI

   Protected Weight_Min, Weight_Max, Height_Min, Height_Max As Single
   Protected WeightUnit, HeightUnit As String

   Protected _BMI, _weight, _height As Single

   Public Event Obese()

   Protected MustOverride Sub CalculateBMI()

   Public Property weight As Single
      Set(value As Single)
         _weight = value
         CalculateBMI()
      End Set
      Get
         Return _weight
      End Get
   End Property

   Public Property height As Single
      Set(value As Single)
         _height = value
         CalculateBMI()
      End Set
      Get
         Return _height
      End Get
   End Property
   Public Sub New(ByVal h As Single, ByVal W As Single)
      If (h > Height_Min And h < Height_Max) Then
         _height = h
      Else
         Throw New Exception("IH")
      End If
      If (W > Weight_Min And h < Weight_Max) Then
         _weight = W
      Else
         Throw New Exception("IW")
      End If
   End Sub
End Class
