'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: March 1, 2018
' Description: Test 2
'              BMI sub-classes
'------------------------------------------------------------------------------------------------------------

Public Class BMIInternational
   Inherits BMI

   Public Sub New(ByVal h As Single, ByVal W As Single)
      MyBase.New(h, W)
      WeightUnit = "kilograms"
      HeightUnit = "meters"
      _BMI = 20
      _height = 1
      _weight = 20
   End Sub
   Protected Overrides Sub CalculateBMI()

   End Sub
End Class


Public Class BMIAmerican
   Inherits BMI
   Public Sub New(ByVal h As Single, ByVal W As Single)
      MyBase.New(h, W)
      WeightUnit = "pounds"
      HeightUnit = "inches"
      _BMI = 20
      _height = 1
      _weight = 20
   End Sub

   Protected Overrides Sub CalculateBMI()

   End Sub
End Class
