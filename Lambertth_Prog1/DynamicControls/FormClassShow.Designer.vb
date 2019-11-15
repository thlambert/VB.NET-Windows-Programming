<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassShow
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
      Me.components = New System.ComponentModel.Container()
      Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
      Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuReturn = New System.Windows.Forms.ToolStripMenuItem()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
      Me.ctmFont = New System.Windows.Forms.ContextMenuStrip(Me.components)
      Me.mnuBold = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuItalic = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuUnderline = New System.Windows.Forms.ToolStripMenuItem()
      Me.Button1 = New System.Windows.Forms.Button()
      Me.MenuStrip1.SuspendLayout()
      Me.ctmFont.SuspendLayout()
      Me.SuspendLayout()
      '
      'MenuStrip1
      '
      Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
      Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
      Me.MenuStrip1.Name = "MenuStrip1"
      Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
      Me.MenuStrip1.TabIndex = 0
      Me.MenuStrip1.Text = "MenuStrip1"
      '
      'mnuFile
      '
      Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReturn, Me.ToolStripSeparator1, Me.mnuExit})
      Me.mnuFile.Name = "mnuFile"
      Me.mnuFile.Size = New System.Drawing.Size(37, 20)
      Me.mnuFile.Text = "File"
      '
      'mnuReturn
      '
      Me.mnuReturn.Name = "mnuReturn"
      Me.mnuReturn.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
      Me.mnuReturn.Size = New System.Drawing.Size(159, 22)
      Me.mnuReturn.Text = "RETURN"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(156, 6)
      '
      'mnuExit
      '
      Me.mnuExit.Name = "mnuExit"
      Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
      Me.mnuExit.Size = New System.Drawing.Size(159, 22)
      Me.mnuExit.Text = "EXIT"
      '
      'ctmFont
      '
      Me.ctmFont.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBold, Me.mnuItalic, Me.mnuUnderline})
      Me.ctmFont.Name = "ContextMenuStrip1"
      Me.ctmFont.Size = New System.Drawing.Size(168, 70)
      '
      'mnuBold
      '
      Me.mnuBold.Name = "mnuBold"
      Me.mnuBold.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
      Me.mnuBold.Size = New System.Drawing.Size(167, 22)
      Me.mnuBold.Text = "Bold"
      '
      'mnuItalic
      '
      Me.mnuItalic.Name = "mnuItalic"
      Me.mnuItalic.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
      Me.mnuItalic.Size = New System.Drawing.Size(167, 22)
      Me.mnuItalic.Text = "Italic"
      '
      'mnuUnderline
      '
      Me.mnuUnderline.Name = "mnuUnderline"
      Me.mnuUnderline.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
      Me.mnuUnderline.Size = New System.Drawing.Size(167, 22)
      Me.mnuUnderline.Text = "Underline"
      '
      'Button1
      '
      Me.Button1.Enabled = False
      Me.Button1.Location = New System.Drawing.Point(559, 1)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(0, 0)
      Me.Button1.TabIndex = 1
      Me.Button1.UseVisualStyleBackColor = True
      '
      'FormClassShow
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(634, 321)
      Me.ControlBox = False
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.MenuStrip1)
      Me.MainMenuStrip = Me.MenuStrip1
      Me.MinimumSize = New System.Drawing.Size(575, 100)
      Me.Name = "FormClassShow"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Loading Controls Dynamically - Thomas Lambert"
      Me.MenuStrip1.ResumeLayout(False)
      Me.MenuStrip1.PerformLayout()
      Me.ctmFont.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents MenuStrip1 As MenuStrip
   Friend WithEvents mnuFile As ToolStripMenuItem
   Friend WithEvents mnuReturn As ToolStripMenuItem
   Friend WithEvents mnuExit As ToolStripMenuItem
   Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
   Friend WithEvents ctmFont As ContextMenuStrip
   Friend WithEvents mnuBold As ToolStripMenuItem
   Friend WithEvents mnuItalic As ToolStripMenuItem
   Friend WithEvents mnuUnderline As ToolStripMenuItem
   Friend WithEvents Button1 As Button
End Class
