'------------------------------------------------------------------------------------------------------------
' Name: Thomas Lambert
' Date: 2/23/2018
' Description: Program3 
'              Class FormClassBranch
' This class handles the differences the forms which inherit from FormClassHouse have.
'------------------------------------------------------------------------------------------------------------
Public Class FormClassBranch
   Inherits UWPCS3340.FormClassHouse
   Private _branchMo As Integer

   ' Sets the branch number and sets the form parent to MDIForm
   Public WriteOnly Property BranchNo As Integer
      Set(value As Integer)
         _branchMo = value
         Me.Text = "Branch #" & _branchMo
         _frmlist.Text = "Branch #" & _branchMo
         _frmlist.MdiParent = Me.MdiParent
      End Set
   End Property

   ' Overrides the exit button on FormClassHouse to close and hide rather then exit
   Protected Overrides Sub btnExit_Click(sender As Object, e As EventArgs)
      'MyBase.btnExit_Click(sender, e)
      Close()
      Hide()
   End Sub

End Class