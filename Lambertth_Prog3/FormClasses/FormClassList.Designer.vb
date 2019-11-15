<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassList
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
      Me.lblCount = New System.Windows.Forms.Label()
      Me.txtCount = New System.Windows.Forms.TextBox()
      Me.lstHouses = New System.Windows.Forms.ListBox()
      Me.btnDisplay = New System.Windows.Forms.Button()
      Me.btnOK = New System.Windows.Forms.Button()
      Me.btnRemove = New System.Windows.Forms.Button()
      Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
      CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'lblCount
      '
      Me.lblCount.AutoSize = True
      Me.lblCount.Location = New System.Drawing.Point(184, 57)
      Me.lblCount.Name = "lblCount"
      Me.lblCount.Size = New System.Drawing.Size(122, 13)
      Me.lblCount.TabIndex = 0
      Me.lblCount.Text = "Total Number of Houses"
      '
      'txtCount
      '
      Me.txtCount.Location = New System.Drawing.Point(350, 57)
      Me.txtCount.Name = "txtCount"
      Me.txtCount.Size = New System.Drawing.Size(100, 20)
      Me.txtCount.TabIndex = 1
      Me.txtCount.TabStop = False
      Me.txtCount.Text = "0"
      Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'lstHouses
      '
      Me.lstHouses.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lstHouses.FormattingEnabled = True
      Me.lstHouses.ItemHeight = 16
      Me.lstHouses.Location = New System.Drawing.Point(137, 112)
      Me.lstHouses.Name = "lstHouses"
      Me.lstHouses.Size = New System.Drawing.Size(277, 100)
      Me.lstHouses.TabIndex = 2
      '
      'btnDisplay
      '
      Me.btnDisplay.Location = New System.Drawing.Point(468, 103)
      Me.btnDisplay.Name = "btnDisplay"
      Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
      Me.btnDisplay.TabIndex = 3
      Me.btnDisplay.Text = "&DISPLAY"
      Me.btnDisplay.UseVisualStyleBackColor = True
      '
      'btnOK
      '
      Me.btnOK.Location = New System.Drawing.Point(468, 202)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.Size = New System.Drawing.Size(75, 23)
      Me.btnOK.TabIndex = 4
      Me.btnOK.Text = "&OK"
      Me.btnOK.UseVisualStyleBackColor = True
      '
      'btnRemove
      '
      Me.btnRemove.Location = New System.Drawing.Point(468, 151)
      Me.btnRemove.Name = "btnRemove"
      Me.btnRemove.Size = New System.Drawing.Size(75, 23)
      Me.btnRemove.TabIndex = 5
      Me.btnRemove.Text = "&Remove"
      Me.btnRemove.UseVisualStyleBackColor = True
      '
      'ErrorProvider1
      '
      Me.ErrorProvider1.ContainerControl = Me
      '
      'FormClassList
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(654, 361)
      Me.Controls.Add(Me.btnRemove)
      Me.Controls.Add(Me.btnOK)
      Me.Controls.Add(Me.btnDisplay)
      Me.Controls.Add(Me.lstHouses)
      Me.Controls.Add(Me.txtCount)
      Me.Controls.Add(Me.lblCount)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Name = "FormClassList"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "All Houses - Thomas Lambert"
      CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lblCount As Label
   Friend WithEvents txtCount As TextBox
   Friend WithEvents lstHouses As ListBox
   Friend WithEvents btnDisplay As Button
   Friend WithEvents btnOK As Button
   Friend WithEvents btnRemove As Button
   Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
