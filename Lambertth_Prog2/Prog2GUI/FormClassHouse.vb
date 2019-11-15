'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 2/14/2018
' Description: Program2 
'              Class FormClassHouse
' This class handles the creation, placement and font of up to 4 buttons on the form.
'------------------------------------------------------------------------------------------------------------

Imports UWPCS3340
Public Class FormClassHouse

   Dim _frmlist As FormClassList
   Private WithEvents _house As House

   ' Initializes the connection between forms
   Public Sub New()
      InitializeComponent()
      _frmlist = New FormClassList
      _frmlist.MainForm = Me
   End Sub

   ' Handles assigning a type value to a new house and catchs incorrect ID exceptions.
   ' Those exceptions include: duplicate ID's, ID's that aren't 5 characters and non-digit and non-letter ID's.
   ' Also catches if a type wasn't selected.
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      If (btnSave.Text = "&SAVE") Then
         Dim temp As String
         temp = txtID.Text.Trim
         Try
            If (cobType.SelectedItem = "Chicago") Then
               _house = New CHouse(temp, cobType.SelectedItem)
            ElseIf (cobType.SelectedItem = "Madison") Then
               _house = New MHouse(temp, cobType.SelectedItem)
            ElseIf (cobType.SelectedItem = "Platteville") Then
               _house = New PHouse(temp, cobType.SelectedItem)
            Else
               Throw New Exception("SH")
            End If
            _frmlist.add(_house)
            DisplayHouse(_house)
         Catch ex As Exception When ex.Message = "IDL"
            MessageBox.Show("ID must have exactly five characters!")
         Catch ex As Exception When ex.Message = "SH"
            MessageBox.Show("Select House Type Please!")
         Catch ex As Exception When ex.Message = "Dupe"
            MessageBox.Show("ID must be unique!")
         Catch ex As Exception When ex.Message = "S"
            MessageBox.Show("Each character of ID must be a digit or letter!")
         End Try
      Else
         NextHouse()
      End If
   End Sub

   ' Handles resetting the radiobuttons to what the house has for the number of rooms and garages.
   Private Sub radiobuttons()
      If (_house.Garages = 1) Then
         rdoGarage1.Checked = True
      ElseIf (_house.Garages = 2) Then
         rdoGarage2.Checked = True
      Else
         rdoGarage3.Checked = True
      End If
      If (_house.Rooms = 2) Then
         rdoRoom2.Checked = True
      ElseIf (_house.Rooms = 3) Then
         rdoRoom3.Checked = True
      Else
         rdoRoom4.Checked = True
      End If
   End Sub

   ' Resets the info on the form to accept a new house.
   Private Sub NextHouse()
      cobType.Enabled = True
      btnRooms.Enabled = False
      btnGarages.Enabled = False
      grpGarages.Enabled = False
      grpRooms.Enabled = False
      txtID.Enabled = True
      btnSave.Text = "&SAVE"
      txtID.Text = ""
      cobType.Text = ""
      txtPrice.Text = ""
   End Sub

   ' Exits the application.
   Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub

   ' Hides this form and moves to form List.
   Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
      Hide()
      _frmlist.Show()
      _frmlist.BringToFront()
   End Sub

   ' Handles changing which house is displayed on the form.
   Friend Sub DisplayHouse(ByVal aHouse As House)
      _house = aHouse
      radiobuttons()
      txtPrice.Text = FormatCurrency(_house.Price, 0)
      cobType.Enabled = False
      btnRooms.Enabled = True
      btnGarages.Enabled = True
      grpGarages.Enabled = True
      grpRooms.Enabled = True
      txtID.Enabled = False
      btnSave.Text = "New"
      cobType.Text = _house.Type
      txtID.Text = _house.ID
   End Sub

   ' Handles changing the number of rooms a house has. Checks if the number of rooms indicated by the radio buttons has changed.
   ' It it has changed, it sets the number of the rooms to the new value.
   ' Handles exceptions thrown if the number of rooms is out of range.
   Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
      Dim temp As Integer = _house.Rooms
      Try
         If (rdoRoom2.Checked = True) Then
            If Not (temp = 2) Then
               _house.Rooms = 2
            End If
         ElseIf (rdoRoom3.Checked = True) Then
            If Not (temp = 3) Then
               _house.Rooms = 3
            End If
         Else
            If Not (temp = 4) Then
               _house.Rooms = 4
            End If
         End If
         DisplayHouse(_house)
         _frmlist.updates()
      Catch ex As Exception When ex.Message = ("OOR")
         MessageBox.Show("Number of rooms is out of range!")
      End Try
   End Sub

   ' Handles changing the number of garages a house has. Checks if the number of garages indicated by the radio buttons has changed.
   ' If it has changed, it sets the number of the garages to the new value.
   ' Handles exceptions thrown if the number of garages is out of range.
   Private Sub btnGarages_Click(sender As Object, e As EventArgs) Handles btnGarages.Click
      Dim temp As Integer = _house.Garages
      Try
         If (rdoGarage1.Checked = True) Then
            _house.Garages = 1
         ElseIf (rdoGarage2.Checked = True) Then
            _house.Garages = 2
         Else
            _house.Garages = 3
         End If
         DisplayHouse(_house)
         _frmlist.updates()
      Catch ex As Exception When ex.Message = ("OOR")
         MessageBox.Show("Number of garages is out of range!")
      End Try
   End Sub

   ' Handles the PriceChanged event. Shows a messagebox.
   Private Sub modifyPrice() Handles _house.PriceChanged
      MessageBox.Show("Price has been changed!")
   End Sub

   ' Prevents the user from closing without going through the exit button
   Private Sub FormClassCreate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
      If (e.CloseReason = CloseReason.UserClosing) Then
         e.Cancel = True
      End If
   End Sub

End Class
