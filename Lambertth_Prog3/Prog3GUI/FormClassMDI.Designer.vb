<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassMDI
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClassMDI))
      Me.tspMDI = New System.Windows.Forms.ToolStrip()
      Me.btnNew = New System.Windows.Forms.ToolStripButton()
      Me.btnExit = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.ddbWindows = New System.Windows.Forms.ToolStripDropDownButton()
      Me.mnuCascade = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuHorizontal = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuVertical = New System.Windows.Forms.ToolStripMenuItem()
      Me.mnuIcons = New System.Windows.Forms.ToolStripMenuItem()
      Me.sspMDI = New System.Windows.Forms.StatusStrip()
      Me.lblUWP = New System.Windows.Forms.ToolStripStatusLabel()
      Me.lblSpring = New System.Windows.Forms.ToolStripStatusLabel()
      Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
      Me.tmrMI = New System.Windows.Forms.Timer(Me.components)
      Me.tspMDI.SuspendLayout()
      Me.sspMDI.SuspendLayout()
      Me.SuspendLayout()
      '
      'tspMDI
      '
      Me.tspMDI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnExit, Me.ToolStripSeparator1, Me.ddbWindows})
      Me.tspMDI.Location = New System.Drawing.Point(0, 0)
      Me.tspMDI.Name = "tspMDI"
      Me.tspMDI.Size = New System.Drawing.Size(632, 25)
      Me.tspMDI.TabIndex = 6
      Me.tspMDI.Text = "ToolStrip"
      '
      'btnNew
      '
      Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
      Me.btnNew.ImageTransparentColor = System.Drawing.Color.Black
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(51, 22)
      Me.btnNew.Text = "New"
      '
      'btnExit
      '
      Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
      Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(50, 22)
      Me.btnExit.Text = "EXIT"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
      '
      'ddbWindows
      '
      Me.ddbWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascade, Me.mnuHorizontal, Me.mnuVertical, Me.mnuIcons})
      Me.ddbWindows.Image = CType(resources.GetObject("ddbWindows.Image"), System.Drawing.Image)
      Me.ddbWindows.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.ddbWindows.Name = "ddbWindows"
      Me.ddbWindows.Size = New System.Drawing.Size(93, 22)
      Me.ddbWindows.Text = "WINDOWS"
      '
      'mnuCascade
      '
      Me.mnuCascade.Name = "mnuCascade"
      Me.mnuCascade.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
      Me.mnuCascade.Size = New System.Drawing.Size(191, 22)
      Me.mnuCascade.Text = "Cascade"
      '
      'mnuHorizontal
      '
      Me.mnuHorizontal.Name = "mnuHorizontal"
      Me.mnuHorizontal.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
      Me.mnuHorizontal.Size = New System.Drawing.Size(191, 22)
      Me.mnuHorizontal.Text = "TileHorizontal"
      '
      'mnuVertical
      '
      Me.mnuVertical.Name = "mnuVertical"
      Me.mnuVertical.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
      Me.mnuVertical.Size = New System.Drawing.Size(191, 22)
      Me.mnuVertical.Text = "TileVertical"
      '
      'mnuIcons
      '
      Me.mnuIcons.Name = "mnuIcons"
      Me.mnuIcons.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
      Me.mnuIcons.Size = New System.Drawing.Size(191, 22)
      Me.mnuIcons.Text = "ArrangeIcons"
      '
      'sspMDI
      '
      Me.sspMDI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUWP, Me.lblSpring, Me.lblDateTime})
      Me.sspMDI.Location = New System.Drawing.Point(0, 431)
      Me.sspMDI.Name = "sspMDI"
      Me.sspMDI.Size = New System.Drawing.Size(632, 22)
      Me.sspMDI.TabIndex = 7
      Me.sspMDI.Text = "StatusStrip"
      '
      'lblUWP
      '
      Me.lblUWP.AutoSize = False
      Me.lblUWP.Name = "lblUWP"
      Me.lblUWP.Size = New System.Drawing.Size(100, 17)
      Me.lblUWP.Text = "UWP - CS3340"
      '
      'lblSpring
      '
      Me.lblSpring.Name = "lblSpring"
      Me.lblSpring.Size = New System.Drawing.Size(367, 17)
      Me.lblSpring.Spring = True
      '
      'lblDateTime
      '
      Me.lblDateTime.AutoSize = False
      Me.lblDateTime.Name = "lblDateTime"
      Me.lblDateTime.Size = New System.Drawing.Size(150, 17)
      '
      'tmrMI
      '
      '
      'FormClassMDI
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.ControlBox = False
      Me.Controls.Add(Me.tspMDI)
      Me.Controls.Add(Me.sspMDI)
      Me.IsMdiContainer = True
      Me.Name = "FormClassMDI"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "FormClassMDI"
      Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
      Me.tspMDI.ResumeLayout(False)
      Me.tspMDI.PerformLayout()
      Me.sspMDI.ResumeLayout(False)
      Me.sspMDI.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents lblUWP As System.Windows.Forms.ToolStripStatusLabel
   Friend WithEvents sspMDI As System.Windows.Forms.StatusStrip
   Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
   Friend WithEvents tspMDI As System.Windows.Forms.ToolStrip
   Friend WithEvents btnExit As ToolStripButton
   Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
   Friend WithEvents lblSpring As ToolStripStatusLabel
   Friend WithEvents lblDateTime As ToolStripStatusLabel
   Friend WithEvents ddbWindows As ToolStripDropDownButton
   Friend WithEvents mnuCascade As ToolStripMenuItem
   Friend WithEvents mnuHorizontal As ToolStripMenuItem
   Friend WithEvents mnuVertical As ToolStripMenuItem
   Friend WithEvents mnuIcons As ToolStripMenuItem
   Friend WithEvents tmrMI As Timer
End Class
