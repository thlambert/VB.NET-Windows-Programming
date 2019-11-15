'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 2/23/2018
' Description: Program3 
'              Class FormClassMDI
' This class handles the creation of the MDIForm which is the parent of all other forms.
'------------------------------------------------------------------------------------------------------------

Imports System.Windows.Forms

Public Class FormClassMDI
   Dim thisDate As Date = Today
   Private m_ChildFormNumber As Integer

   ' Handles creating a new form as FormClassBranch and handles the number of branch
   Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
      Dim ChildForm As New FormClassBranch
      ChildForm.MdiParent = Me
      m_ChildFormNumber += 1
      ChildForm.BranchNo = m_ChildFormNumber
      ChildForm.Show()
   End Sub

   ' Creates the first form as FormClassHouse and sets it as a child form
   ' Starts the timer and sets the interval
   ' Sets the date and time
   Private Sub FormClassMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Dim ChildForm As New UWPCS3340.FormClassHouse
      ' Make it a child of this MDI form before showing it.
      ChildForm.MdiParent = Me
      ChildForm.Show()
      tmrMI.Start()
      tmrMI.Interval = 3000
      lblDateTime.Text = DateTime.Now.ToString("M/dd/yyyy h:mm:ss tt")
   End Sub

   ' Exits the application
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub

   ' Sets the layout style to Cascade
   Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuCascade.Click
      Me.LayoutMdi(MdiLayout.Cascade)
   End Sub

   ' Sets the layout style to TileHorizontal
   Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuHorizontal.Click
      Me.LayoutMdi(MdiLayout.TileHorizontal)
   End Sub

   ' Sets the layout style to TileVertical
   Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuVertical.Click
      Me.LayoutMdi(MdiLayout.TileVertical)
   End Sub

   ' Sets the layout style to ArrangeIcons
   Private Sub TileIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuIcons.Click
      Me.LayoutMdi(MdiLayout.ArrangeIcons)
   End Sub

   ' Sets the date and time every 3 seconds
   Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrMI.Tick
      lblDateTime.Text = DateTime.Now.ToString("M/dd/yyyy h:mm:ss tt")
   End Sub

End Class
