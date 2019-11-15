<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassButton
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
      Me.mspMain = New System.Windows.Forms.MenuStrip()
      Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuSwitch = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuButton = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuCreate = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuRemove = New System.Windows.Forms.ToolStripMenuItem()
      Me.txtKey = New System.Windows.Forms.TextBox()
      Me.txtCaption = New System.Windows.Forms.TextBox()
      Me.lblCaption = New System.Windows.Forms.Label()
      Me.lblKey = New System.Windows.Forms.Label()
      Me.mspMain.SuspendLayout()
      Me.SuspendLayout()
      '
      'mspMain
      '
      Me.mspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuButton})
      Me.mspMain.Location = New System.Drawing.Point(0, 0)
      Me.mspMain.Name = "mspMain"
      Me.mspMain.Size = New System.Drawing.Size(610, 24)
      Me.mspMain.TabIndex = 0
      Me.mspMain.Text = "MenuStrip1"
      '
      'mnuFile
      '
      Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSwitch, Me.mnuExit})
      Me.mnuFile.Name = "mnuFile"
      Me.mnuFile.Size = New System.Drawing.Size(37, 20)
      Me.mnuFile.Text = "&File"
      '
      'mnuSwitch
      '
      Me.mnuSwitch.Name = "mnuSwitch"
      Me.mnuSwitch.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
      Me.mnuSwitch.Size = New System.Drawing.Size(157, 22)
      Me.mnuSwitch.Text = "&SWITCH"
      '
      'mnuExit
      '
      Me.mnuExit.Name = "mnuExit"
      Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
      Me.mnuExit.Size = New System.Drawing.Size(157, 22)
      Me.mnuExit.Text = "E&XIT"
      '
      'mnuButton
      '
      Me.mnuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreate, Me.mnuRemove})
      Me.mnuButton.Name = "mnuButton"
      Me.mnuButton.Size = New System.Drawing.Size(55, 20)
      Me.mnuButton.Text = "&Button"
      '
      'mnuCreate
      '
      Me.mnuCreate.Name = "mnuCreate"
      Me.mnuCreate.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
      Me.mnuCreate.Size = New System.Drawing.Size(161, 22)
      Me.mnuCreate.Text = "&CREATE"
      '
      'mnuRemove
      '
      Me.mnuRemove.Name = "mnuRemove"
      Me.mnuRemove.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
      Me.mnuRemove.Size = New System.Drawing.Size(161, 22)
      Me.mnuRemove.Text = "&REMOVE"
      '
      'txtKey
      '
      Me.txtKey.Location = New System.Drawing.Point(331, 174)
      Me.txtKey.Name = "txtKey"
      Me.txtKey.Size = New System.Drawing.Size(100, 20)
      Me.txtKey.TabIndex = 1
      Me.txtKey.Text = "K3"
      '
      'txtCaption
      '
      Me.txtCaption.Location = New System.Drawing.Point(179, 174)
      Me.txtCaption.Name = "txtCaption"
      Me.txtCaption.Size = New System.Drawing.Size(100, 20)
      Me.txtCaption.TabIndex = 2
      Me.txtCaption.Text = "3"
      '
      'lblCaption
      '
      Me.lblCaption.AutoSize = True
      Me.lblCaption.Location = New System.Drawing.Point(208, 145)
      Me.lblCaption.Name = "lblCaption"
      Me.lblCaption.Size = New System.Drawing.Size(43, 13)
      Me.lblCaption.TabIndex = 3
      Me.lblCaption.Text = "Caption"
      '
      'lblKey
      '
      Me.lblKey.AutoSize = True
      Me.lblKey.Location = New System.Drawing.Point(369, 145)
      Me.lblKey.Name = "lblKey"
      Me.lblKey.Size = New System.Drawing.Size(25, 13)
      Me.lblKey.TabIndex = 4
      Me.lblKey.Text = "Key"
      '
      'FormClassButton
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(610, 368)
      Me.ControlBox = False
      Me.Controls.Add(Me.lblKey)
      Me.Controls.Add(Me.lblCaption)
      Me.Controls.Add(Me.txtCaption)
      Me.Controls.Add(Me.txtKey)
      Me.Controls.Add(Me.mspMain)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.MainMenuStrip = Me.mspMain
      Me.Name = "FormClassButton"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Test1 - Thomas Lambert"
      Me.mspMain.ResumeLayout(False)
      Me.mspMain.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents mspMain As System.Windows.Forms.MenuStrip
   Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuSwitch As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuButton As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuCreate As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents mnuRemove As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents txtKey As System.Windows.Forms.TextBox
   Friend WithEvents txtCaption As System.Windows.Forms.TextBox
   Friend WithEvents lblCaption As System.Windows.Forms.Label
   Friend WithEvents lblKey As System.Windows.Forms.Label

End Class
