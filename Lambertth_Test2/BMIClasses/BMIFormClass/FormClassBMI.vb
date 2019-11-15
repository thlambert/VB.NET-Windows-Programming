'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: March 1, 2018
' Description: Test 2
'              FormClassBMI
'------------------------------------------------------------------------------------------------------------

Imports UWPCS3340

Public Class FormClassBMI

   Private WithEvents _bmi As BMI
   Private Sub btnWeight_Click(sender As Object, e As EventArgs) Handles btnWeight.Click
      Dim bool As Boolean = True
      Dim temp As String = txtWeight.Text
      Dim temp2 As Single = Single.Parse(temp)
      If (bool) Then
         Try
            If (rdoAmerican.Checked) Then
               _bmi = New BMIAmerican(temp2, Single.Parse(txtHeight.Text))
            Else
               _bmi = New BMIInternational(temp2, Single.Parse(txtHeight.Text))
            End If
         Catch ex As Exception When ex.Message = "IW"
            If (rdoAmerican.checked) Then
               errBMI.SetError(txtWeight, "Weight in pounds is out of range (44.1 to 449.9).")
            Else
               errBMI.SetError(txtWeight, "Weight in kilograms is out of range (20 to 200).")
            End If
         End Try
      Else
         errBMI.SetError(txtWeight, "Conversion from string " + txtWeight.Text + "to type 'Single' is not valid")
      End If
   End Sub

   Private Sub FormClassBMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      rdoInternational.Checked = True
      txtWeight.Text = 20
      txtHeight.Text = 1
      txtBMI.Text = 20
   End Sub

   Private Sub rdoInternational_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInternational.CheckedChanged
      txtWeight.Text = 20
      txtHeight.Text = 1
      txtBMI.Text = 20
   End Sub

   Private Sub rdoAmerican_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAmerican.CheckedChanged
      txtWeight.Text = 44.1
      txtHeight.Text = 39.4
      txtBMI.Text = 19.97107
   End Sub

   Private Sub btnHeight_Click(sender As Object, e As EventArgs) Handles btnHeight.Click
      Dim bool As Boolean
      Dim temp As String = txtHeight.Text
      Dim temp2 As Single = Single.TryParse(temp, bool)
      If (bool) Then
         Try

         Catch ex As Exception When ex.Message = "IH"
            If (rdoAmerican.Checked) Then
               errBMI.SetError(txtWeight, "Height in inches is out of range (39.4 to 98.4).")
            Else
               errBMI.SetError(txtWeight, "Height in meters is out of range (1 to 2.5).")
            End If

         End Try
      Else
         errBMI.SetError(txtWeight, "Conversion from string " + txtHeight.Text + "to type 'Single' is not valid")
      End If
   End Sub

   Private Sub btnUnload_Click(sender As Object, e As EventArgs) Handles btnUnload.Click
      Close()
      Hide()
   End Sub
End Class
