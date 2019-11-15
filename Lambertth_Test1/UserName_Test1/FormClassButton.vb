Public Class FormClassButton
   Private _frmJump As FormClassJump
   Public Sub New()

      ' This call is required by the designer.
      InitializeComponent()
      _frmJump = New FormClassJump
      _frmJump.MainForm = Me
      ' Add any initialization after the InitializeComponent() call.

   End Sub

   Private Sub mnuSwitch_Click(sender As Object, e As EventArgs) Handles mnuSwitch.Click
      Me.Hide()
      _frmJump.Show()
   End Sub

   Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
      Application.Exit()
   End Sub

   Private Sub mnuCreate_Click(sender As Object, e As EventArgs) Handles mnuCreate.Click
      Dim temp1 As String
      temp1 = txtKey.Text.Trim
      Try
         If Not (temp1 = "") Then
            _frmJump.CreateButton(temp1, txtCaption.Text.Trim)
         Else
            MessageBox.Show("Enter the key please!")
         End If
      Catch ex As Exception When ex.Message = ("TMB")
         MessageBox.Show("There are three buttons created already!")
      Catch ex As Exception When ex.Message = ("Dupe")
         MessageBox.Show("Key must be unique!")
      End Try

   End Sub

   Private Sub mnuRemove_Click(sender As Object, e As EventArgs) Handles mnuRemove.Click
      Try
         If (txtKey.Text.Trim = "") Then
            MessageBox.Show("Enter the key please!")
         Else
            _frmJump.RemoveButton(txtKey.Text.Trim)
         End If
      Catch ex As Exception When ex.Message = "RNF"
         MessageBox.Show("No button has the key!")
      End Try

   End Sub
   Private Sub FormClassShow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
      If (e.CloseReason = CloseReason.UserClosing) Then
         e.Cancel = True
      End If
   End Sub
End Class
