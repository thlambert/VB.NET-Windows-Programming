Public Class FormClassJump
   Private Const BUTTON_WIDTH As Integer = 85
   Private Const BUTTON_HEIGHT As Integer = 35
   Private Const MAX_BUTTONS As Integer = 3

   Private _mainfrom As Form
   Private AllButtons As New SortedList
   Private flags As New List(Of Boolean)
   Private aButton As Button

   Public WriteOnly Property MainForm As Form
      Set(ByVal value As Form)
         _mainfrom = value
      End Set
   End Property

   ' Required friend Sub
   Friend Sub RemoveButton(ByVal theKey As String)
      If (AllButtons.Contains(theKey)) Then
         Controls.RemoveByKey(theKey)
         Dim index As Integer = AllButtons.IndexOfKey(theKey)
         aButton = CType(AllButtons.GetByIndex(index), Button)
         Controls.Remove(aButton)
         AllButtons.Remove(theKey)
         ArrangeButtons()
      Else
         Throw New Exception("RNFs")
      End If
   End Sub

   ' Required friend Sub
   Friend Sub CreateButton(ByVal theKey As String, ByVal theCaption As String)
      If (AllButtons.Count < MAX_BUTTONS) Then
         Try
            aButton = New Button
            aButton.Text = theCaption
            aButton.Tag = theKey
            aButton.Height = BUTTON_HEIGHT
            aButton.Width = BUTTON_WIDTH
            AddHandler aButton.Click, AddressOf ButtonClick
            AllButtons.Add(theKey, aButton)
            ArrangeButtons()
            Me.Controls.Add(aButton)
            Dim flag As Boolean = True
            flags.Add(flag)
         Catch ex As Exception
            Throw New Exception("Dupe")
         End Try
      Else
         Throw New Exception("TMB")
      End If

   End Sub

   ' Required Private Sub
   Private Sub ArrangeButtons()

      Dim formClientWidth As Integer
      Dim FormClientHeight As Integer
      formClientWidth = Me.ClientSize.Width
      FormClientHeight = Me.ClientSize.Height

      Dim temp As Integer = (FormClientHeight - (BUTTON_HEIGHT * AllButtons.Count)) / (AllButtons.Count + 1)
      Dim tempbutton As Button

      For index As Integer = 0 To AllButtons.Count - 1
         tempbutton = CType(AllButtons.GetByIndex(index), Button)
         tempbutton.Top = temp + (index * BUTTON_HEIGHT) + (temp * index)
         tempbutton.Left = (formClientWidth / 2) - (BUTTON_WIDTH / 2)
      Next
   End Sub

   ' Required event handler for the button click event 
   Private Sub JumpEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Dim temp As Integer = AllButtons.IndexOfValue(sender)
      If (sender.Left = 274) Then
         If (flags.Item(temp)) Then
            Dim flag As Boolean = False
            flags.Item(temp) = flag
            sender.Left = sender.Left + BUTTON_WIDTH
         Else
            Dim flag As Boolean = True
            flags.Item(temp) = flag
            sender.Left = sender.Left - BUTTON_WIDTH
         End If
      ElseIf (sender.Left < 274) Then
         sender.Left = sender.Left + BUTTON_WIDTH
      Else
         sender.Left = sender.Left - BUTTON_WIDTH
      End If
   End Sub

   Private Sub FormClassJump_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
      ArrangeButtons()
   End Sub

   Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
      Me.Hide()
      _mainfrom.Show()
   End Sub

   Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
      Application.Exit()
   End Sub
   Private Sub ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
      Dim TheButton As Button
      TheButton = CType(sender, Button)
      JumpEvent(TheButton, e)

   End Sub
   Private Sub FormClassShow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
      If (e.CloseReason = CloseReason.UserClosing) Then
         e.Cancel = True
      End If
   End Sub

   Private Sub FormClassJump_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
      ArrangeButtons()
   End Sub
End Class