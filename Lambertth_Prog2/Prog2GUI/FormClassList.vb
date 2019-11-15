'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 2/14/2018
' Description: Program2 
'              Class FormClassList
' This class handles the listbox which contains all the houses created.
'------------------------------------------------------------------------------------------------------------

Imports UWPCS3340
Public Class FormClassList

   Private _mainForm As FormClassHouse

   ' Public property to set the mainForm
   Public WriteOnly Property MainForm As FormClassHouse
      Set(ByVal value As FormClassHouse)
         _mainForm = value
      End Set
   End Property

   ' Goes back to the main form when the OK button is clicked
   Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
      Hide()
      _mainForm.Show()
      _mainForm.BringToFront()
   End Sub

   ' Gets the index of the selected House in the list and then puts the house info back on the main form.
   ' Moves to the main form.
   Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
      If Not (lstHouses.SelectedIndex = -1) Then
         _mainForm.DisplayHouse(House.HouseByIndex(lstHouses.SelectedIndex))
         Hide()
         _mainForm.Show()
      Else
         MessageBox.Show("Select a house in the list!")
      End If
   End Sub

   ' Adds a house to the listbox. Uses padding to show ID, Type and Price. 
   Friend Sub add(house As House)
      Dim temp1 As String = house.ID.ToString.PadRight(12)
      Dim temp2 As String = house.Type.ToString.PadRight(13)
      Dim temp3 As String = FormatCurrency(house.Price.ToString, 0)
      lstHouses.Items.Add(temp1 + temp2 + temp3)
      txtCount.Text = House.TotalCount
   End Sub

   ' Updates the data in the listbox by clearing the listbox and then adding all the houses back in.
   Friend Sub updates()
      lstHouses.Items.Clear()
      For Index As Integer = 0 To House.TotalCount - 1
         add(House.HouseByIndex(Index))
      Next
   End Sub

   ' Prevents the user from closing without going through the exit button
   Private Sub FormClassCreate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
      If (e.CloseReason = CloseReason.UserClosing) Then
         e.Cancel = True
      End If
   End Sub

End Class