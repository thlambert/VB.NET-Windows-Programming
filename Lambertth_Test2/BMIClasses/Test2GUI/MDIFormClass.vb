'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: March 1, 2018
' Description: Test 2
'              MDIFormClass
'------------------------------------------------------------------------------------------------------------

Imports System.Windows.Forms


Public Class MDIFormClass
   Private m_ChildFormNumber As Integer
   Private Sub MDIFormClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub

   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      Dim ChildForm As New UWPCS3340.FormClassBMI
      m_ChildFormNumber += 1
      Dim temp As String = "Form #" + m_ChildFormNumber.ToString + " - Thomas Lambert"
      ChildForm.Text = temp
      ChildForm.MdiParent = Me
      ChildForm.Show()
   End Sub
End Class
