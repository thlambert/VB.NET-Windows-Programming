'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 1/31/2018
' Description: Program1 
'              Class FormClassCreate
' This class handles creating and removing buttons from the show form using two textboxes.
'------------------------------------------------------------------------------------------------------------
Public Class FormClassCreate
   Dim badinput As Boolean = False
   Private _frmShow As FormClassShow
   Private Const MAX_KEY_LENGTH As Integer = 6

   ' Initializes the connection between forms
   Public Sub New()
      InitializeComponent()
      _frmShow = New FormClassShow
      _frmShow._mainForm = Me
   End Sub

   ' Exits when the exit button is clicked
   Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
      Application.Exit()
   End Sub

   ' Switches to the show form
   Private Sub mnuShow_Click(sender As Object, e As EventArgs) Handles mnuShow.Click
      Me.Hide()
      _frmShow.Show()
   End Sub

   ' Checks if the close reason is UserClosing
   Private Sub FormClassCreate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
      If (e.CloseReason = CloseReason.UserClosing) Then
         e.Cancel = True
      End If
   End Sub

   ' Creates a button on the show form using the two textboxes. Handles duplicate keys and too many button exceptions.
   Private Sub mnuCreate_Click(sender As Object, e As EventArgs) Handles mnuCreate.Click
      Dim theCaption As String
      Dim theKey As String
      theCaption = txtCaption.Text.Trim()
      theKey = txtKey.Text.Trim()

      If theKey = "" Then
         MessageBox.Show("A key is required!")
      Else
         Try
            _frmShow.addButton(theKey, theCaption)
         Catch ex As Exception When ex.Message = "Dupe"
            MessageBox.Show("Duplicate Key!")
         Catch ex As Exception When ex.Message = "TooMany"
            MessageBox.Show("There are 4 buttons already!")
         End Try

      End If
   End Sub

   ' Calls the remove button sub. Handles if the key wasn't found
   Private Sub mnuRemove_Click(sender As Object, e As EventArgs) Handles mnuRemove.Click
      Try
         _frmShow.removeButton(txtKey.Text)
      Catch ex As Exception
         MessageBox.Show("Could not remove key: Key not found.")
      End Try
   End Sub

   ' Checks the input of the key textbox. If there are too many characters or it starts with a number, sets badinput to true.
   Private Sub txtKey_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKey.KeyDown
      badinput = False
      If (txtKey.Text.Length < 1) Then
         If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) Or (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) Then
            badinput = True
         End If
      ElseIf (txtKey.Text.Length = MAX_KEY_LENGTH) Then
         If (e.KeyCode = Keys.Back) Then
         Else
            badinput = True
         End If
      End If
   End Sub

   ' Checks badinput. Outputs the error messages.
   Private Sub txtKey_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKey.KeyPress
      If badinput = True Then
         If (txtKey.Text.Length = 0) Then
            MessageBox.Show("Keys cannot start with a digit!")
         Else
            MessageBox.Show("Keys can have at most 6 characters!")
         End If
         e.Handled = True
      End If
   End Sub

End Class
