'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 1/31/2018
' Description: Program1 
'              Class FormClassShow
' This class handles the creation, placement and font of up to 4 buttons on the form.
'------------------------------------------------------------------------------------------------------------
Public Class FormClassShow
   Private Const MAX_BUTTON_COUNT As Integer = 4
   Private Const BUTTON_HEIGHT As Integer = 23
   Private Const BUTTON_WIDTH As Integer = 75
   Private Const MENU_HEIGHT As Integer = 24
   Private Const MARGIN_SIZE As Integer = 100
   Private Const DISTANCE_BETWEEN As Integer = 50
   Private WithEvents aButton As Button
   Private _allButtons As New SortedList
   Friend _mainForm As Form

   ' Public property (set method)
   Public WriteOnly Property MainForm As Form
      Set(ByVal value As Form)
         _mainForm = value
      End Set
   End Property

   ' Hides this form and goes to the create form
   Private Sub mnuReturn_Click(sender As Object, e As EventArgs) Handles mnuReturn.Click
      Me.Hide()
      _mainForm.Show()
      _mainForm.BringToFront()
   End Sub

   ' Exits the program
   Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
      Application.Exit()
   End Sub

   ' Checks if the close reason is UserClosing
   Private Sub FormClassShow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
      If (e.CloseReason = CloseReason.UserClosing) Then
         e.Cancel = True
      End If
   End Sub

   ' Changes font to Bold or removes bold
   Private Sub mnuBold_Click(sender As Object, e As EventArgs) Handles mnuBold.Click
      aButton.Font = New Font(aButton.Font, aButton.Font.Style Xor FontStyle.Bold)
      ChangeFont(aButton.Font.Style, mnuBold)
   End Sub

   ' Changes font to Italic or removes italic
   Private Sub mnuItalic_Click(sender As Object, e As EventArgs) Handles mnuItalic.Click
      aButton.Font = New Font(aButton.Font, aButton.Font.Style Xor FontStyle.Italic)
      ChangeFont(aButton.Font.Style, mnuItalic)
   End Sub

   ' Changes font to Underline or removes Underline
   Private Sub mnuUnderline_Click(sender As Object, e As EventArgs) Handles mnuUnderline.Click
      aButton.Font = New Font(aButton.Font, aButton.Font.Style Xor FontStyle.Underline)
      ChangeFont(aButton.Font.Style, mnuUnderline)
   End Sub

   ' Arranges all buttons on the form according to the requirements.
   ' It does not change any thing of any button, except its location on the form.
   Private Sub ArrangeButtons()
      Dim formClientWidth As Integer
      Dim FormClientHeight As Integer
      formClientWidth = Me.ClientSize.Width
      FormClientHeight = Me.ClientSize.Height

      Dim temp As Integer = (formClientWidth - (MARGIN_SIZE * 2) - ((_allButtons.Count) * BUTTON_WIDTH)) /
         (_allButtons.Count + 1)
      Dim tempbutton As Button

      For index As Integer = 0 To _allButtons.Count - 1
         tempbutton = CType(_allButtons.GetByIndex(index), Button)
         tempbutton.Top = ((FormClientHeight + 24) / 2) - (BUTTON_HEIGHT / 2)
         tempbutton.Left = MARGIN_SIZE + temp + (index * BUTTON_WIDTH) + (index * temp)
      Next

   End Sub

   ' Changes the font of all buttons when a shortcut menu item is clicked.
   ' It also updates the menu item as checked or unchecked.
   Private Sub ChangeFont(ByVal f As FontStyle, ByVal m As ToolStripMenuItem)
      m.Checked = Not m.Checked
      For index As Integer = 0 To _allButtons.Count - 1
         aButton = CType(_allButtons.GetByIndex(index), Button)
         aButton.Font = New Font(aButton.Font, f)
      Next
   End Sub

   ' Sets the font style of button b according to whether the three menu items
   ' are checked or not.
   Private Sub setFont(ByVal b As Button)
      If (mnuBold.Checked = True) Then
         Button1.Font = New Font(Button1.Font, Button1.Font.Style Xor FontStyle.Bold)
      End If
      If (mnuItalic.Checked = True) Then
         Button1.Font = New Font(Button1.Font, Button1.Font.Style Xor FontStyle.Italic)
      End If
      If (mnuUnderline.Checked = True) Then
         Button1.Font = New Font(Button1.Font, Button1.Font.Style Xor FontStyle.Underline)
      End If
      b.Font = New Font(b.Font, Button1.Font.Style)
   End Sub

   ' At most MAX_BUTTON_COUNT buttons can be created. If MAX_BUTTON_COUNT buttons have 
   ' been created already, then an exception will be thrown and no button will be added.
   ' If no button in _allButtons has theKey as its key, the method creates a button with theKey 
   ' and theCaption and adds the button to both the form and the sorted list _allButtons.
   ' The Add method of the sorted list will check the uniqueness condition on key and throw an
   ' exception if the condition is violated. The method does not check the condition by itself 
   ' and calls the Add method of the sorted list and lets the caller to handle the exception.
   Public Sub addButton(ByVal theKey As String, ByVal theCaption As String)
      If (_allButtons.Count < MAX_BUTTON_COUNT) Then
         Try
            aButton = New Button
            aButton.Text = theCaption
            aButton.Tag = theKey
            AddHandler aButton.Click, AddressOf ButtonClick
            _allButtons.Add(theKey, aButton)
            setFont(aButton)
            ArrangeButtons()
            Me.Controls.Add(aButton)
         Catch ex As Exception
            Throw New Exception("Dupe")
         End Try
      Else
         Throw New Exception("TooMany")
      End If
   End Sub

   ' If a button in _allButtons has theKey as its key, the method removes the button from both 
   ' the form and the sorted list. Otherwise, it throws an exception.
   Public Sub removeButton(ByVal theKey As String)
      If (_allButtons.Contains(theKey)) Then
         Controls.RemoveByKey(theKey)
         Dim index As Integer = _allButtons.IndexOfKey(theKey)
         aButton = CType(_allButtons.GetByIndex(index), Button)
         Controls.Remove(aButton)
         _allButtons.Remove(theKey)
         ArrangeButtons()
      Else
         Throw New Exception("Could not remove key: Key not found.")
      End If
   End Sub

   ' Handles the position of the context menu with the font options. Moves it to the position of the mouse.
   Private Sub FormClassShow_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
      If e.Button = MouseButtons.Right Then
         Dim cord As Point
         cord.X = MousePosition.X
         cord.Y = MousePosition.Y
         ctmFont.Show()
         ctmFont.Location = cord
      End If
   End Sub

   ' Handles when any other the buttons are clicked. A message box shows the caption and the key of the button.
   Private Sub ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
      Dim TheButton As Button
      TheButton = CType(sender, Button)
      MessageBox.Show("Caption: " & TheButton.Text & Chr(Keys.LineFeed) & "Key: " & TheButton.Tag())
   End Sub

   ' Calls ArrangeButtons when the window is resized.
   Private Sub FormClassShow_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
      ArrangeButtons()
   End Sub

End Class