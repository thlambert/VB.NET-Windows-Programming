<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassBMI
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
      Me.rdoInternational = New System.Windows.Forms.RadioButton()
      Me.rdoAmerican = New System.Windows.Forms.RadioButton()
      Me.txtBMI = New System.Windows.Forms.TextBox()
      Me.txtHeight = New System.Windows.Forms.TextBox()
      Me.txtWeight = New System.Windows.Forms.TextBox()
      Me.btnWeight = New System.Windows.Forms.Button()
      Me.btnHeight = New System.Windows.Forms.Button()
      Me.btnBMI = New System.Windows.Forms.Button()
      Me.btnUnload = New System.Windows.Forms.Button()
      Me.errBMI = New System.Windows.Forms.ErrorProvider(Me.components)
      CType(Me.errBMI, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'rdoInternational
      '
      Me.rdoInternational.AutoSize = True
      Me.rdoInternational.Location = New System.Drawing.Point(295, 81)
      Me.rdoInternational.Name = "rdoInternational"
      Me.rdoInternational.Size = New System.Drawing.Size(83, 17)
      Me.rdoInternational.TabIndex = 2
      Me.rdoInternational.TabStop = True
      Me.rdoInternational.Text = "&International"
      Me.rdoInternational.UseVisualStyleBackColor = True
      '
      'rdoAmerican
      '
      Me.rdoAmerican.AutoSize = True
      Me.rdoAmerican.Location = New System.Drawing.Point(509, 81)
      Me.rdoAmerican.Name = "rdoAmerican"
      Me.rdoAmerican.Size = New System.Drawing.Size(69, 17)
      Me.rdoAmerican.TabIndex = 3
      Me.rdoAmerican.TabStop = True
      Me.rdoAmerican.Text = "&American"
      Me.rdoAmerican.UseVisualStyleBackColor = True
      '
      'txtBMI
      '
      Me.txtBMI.BackColor = System.Drawing.SystemColors.Window
      Me.txtBMI.Location = New System.Drawing.Point(584, 154)
      Me.txtBMI.Name = "txtBMI"
      Me.txtBMI.ReadOnly = True
      Me.txtBMI.Size = New System.Drawing.Size(100, 20)
      Me.txtBMI.TabIndex = 8
      Me.txtBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'txtHeight
      '
      Me.txtHeight.Location = New System.Drawing.Point(365, 154)
      Me.txtHeight.Name = "txtHeight"
      Me.txtHeight.Size = New System.Drawing.Size(100, 20)
      Me.txtHeight.TabIndex = 1
      Me.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'txtWeight
      '
      Me.txtWeight.Location = New System.Drawing.Point(146, 154)
      Me.txtWeight.Name = "txtWeight"
      Me.txtWeight.Size = New System.Drawing.Size(100, 20)
      Me.txtWeight.TabIndex = 0
      Me.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'btnWeight
      '
      Me.btnWeight.Location = New System.Drawing.Point(159, 227)
      Me.btnWeight.Name = "btnWeight"
      Me.btnWeight.Size = New System.Drawing.Size(75, 23)
      Me.btnWeight.TabIndex = 4
      Me.btnWeight.Text = "Set &Weight"
      Me.btnWeight.UseVisualStyleBackColor = True
      '
      'btnHeight
      '
      Me.btnHeight.Location = New System.Drawing.Point(378, 227)
      Me.btnHeight.Name = "btnHeight"
      Me.btnHeight.Size = New System.Drawing.Size(75, 23)
      Me.btnHeight.TabIndex = 5
      Me.btnHeight.Text = "Set &Height"
      Me.btnHeight.UseVisualStyleBackColor = True
      '
      'btnBMI
      '
      Me.btnBMI.Location = New System.Drawing.Point(597, 227)
      Me.btnBMI.Name = "btnBMI"
      Me.btnBMI.Size = New System.Drawing.Size(75, 23)
      Me.btnBMI.TabIndex = 6
      Me.btnBMI.Text = "Get &BMI"
      Me.btnBMI.UseVisualStyleBackColor = True
      '
      'btnUnload
      '
      Me.btnUnload.Location = New System.Drawing.Point(378, 323)
      Me.btnUnload.Name = "btnUnload"
      Me.btnUnload.Size = New System.Drawing.Size(75, 23)
      Me.btnUnload.TabIndex = 7
      Me.btnUnload.Text = "&Unload"
      Me.btnUnload.UseVisualStyleBackColor = True
      '
      'errBMI
      '
      Me.errBMI.ContainerControl = Me
      '
      'FormClassBMI
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(830, 407)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnUnload)
      Me.Controls.Add(Me.btnBMI)
      Me.Controls.Add(Me.btnHeight)
      Me.Controls.Add(Me.btnWeight)
      Me.Controls.Add(Me.txtWeight)
      Me.Controls.Add(Me.txtHeight)
      Me.Controls.Add(Me.txtBMI)
      Me.Controls.Add(Me.rdoAmerican)
      Me.Controls.Add(Me.rdoInternational)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "FormClassBMI"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Form1"
      CType(Me.errBMI, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents rdoInternational As RadioButton
   Friend WithEvents rdoAmerican As RadioButton
   Friend WithEvents txtBMI As TextBox
   Friend WithEvents txtHeight As TextBox
   Friend WithEvents txtWeight As TextBox
   Friend WithEvents btnWeight As Button
   Friend WithEvents btnHeight As Button
   Friend WithEvents btnBMI As Button
   Friend WithEvents btnUnload As Button
   Friend WithEvents errBMI As ErrorProvider
End Class
