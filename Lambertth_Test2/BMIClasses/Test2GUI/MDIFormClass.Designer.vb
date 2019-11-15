<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIFormClass
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
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
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIFormClass))
      Me.ToolStrip = New System.Windows.Forms.ToolStrip()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
      Me.btnNew = New System.Windows.Forms.ToolStripButton()
      Me.btnExit = New System.Windows.Forms.ToolStripButton()
      Me.ToolStrip.SuspendLayout()
      Me.SuspendLayout()
      '
      'ToolStrip
      '
      Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
      Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.btnNew, Me.btnExit})
      Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
      Me.ToolStrip.Name = "ToolStrip"
      Me.ToolStrip.Size = New System.Drawing.Size(632, 25)
      Me.ToolStrip.TabIndex = 6
      Me.ToolStrip.Text = "ToolStrip"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'ToolStripSeparator2
      '
      Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
      Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'btnNew
      '
      Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
      Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(37, 22)
      Me.btnNew.Text = "&NEW"
      '
      'btnExit
      '
      Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
      Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
      Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(34, 22)
      Me.btnExit.Text = "E&XIT"
      '
      'MDIFormClass
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.ControlBox = False
      Me.Controls.Add(Me.ToolStrip)
      Me.IsMdiContainer = True
      Me.Name = "MDIFormClass"
      Me.Text = "Test 2"
      Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
      Me.ToolStrip.ResumeLayout(False)
      Me.ToolStrip.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents btnNew As ToolStripButton
   Friend WithEvents btnExit As ToolStripButton
End Class
