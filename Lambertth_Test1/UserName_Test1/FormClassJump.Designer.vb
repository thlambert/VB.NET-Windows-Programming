<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClassJump
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()>
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Me.cmsJump = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
      Me.cmsJump.SuspendLayout()
      Me.SuspendLayout()
      '
      'cmsJump
      '
      Me.cmsJump.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuExit})
      Me.cmsJump.Name = "ContextMenuStrip1"
      Me.cmsJump.Size = New System.Drawing.Size(146, 48)
      '
      'mnuBack
      '
      Me.mnuBack.Name = "mnuBack"
      Me.mnuBack.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
      Me.mnuBack.Size = New System.Drawing.Size(145, 22)
      Me.mnuBack.Text = "&BACK"
      '
      'mnuExit
      '
      Me.mnuExit.Name = "mnuExit"
      Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
      Me.mnuExit.Size = New System.Drawing.Size(145, 22)
      Me.mnuExit.Text = "E&XIT"
      '
      'FormClassJump
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(634, 382)
      Me.ContextMenuStrip = Me.cmsJump
      Me.ControlBox = False
      Me.MinimumSize = New System.Drawing.Size(300, 150)
      Me.Name = "FormClassJump"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Test1 -  Thomas Lambert"
      Me.cmsJump.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents cmsJump As System.Windows.Forms.ContextMenuStrip
   Friend WithEvents mnuBack As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
End Class
