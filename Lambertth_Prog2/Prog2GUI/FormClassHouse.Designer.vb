<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassHouse
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
      Me.cobType = New System.Windows.Forms.ComboBox()
      Me.txtID = New System.Windows.Forms.TextBox()
      Me.txtPrice = New System.Windows.Forms.TextBox()
      Me.grpRooms = New System.Windows.Forms.GroupBox()
      Me.rdoRoom2 = New System.Windows.Forms.RadioButton()
      Me.rdoRoom3 = New System.Windows.Forms.RadioButton()
      Me.rdoRoom4 = New System.Windows.Forms.RadioButton()
      Me.grpGarages = New System.Windows.Forms.GroupBox()
      Me.rdoGarage3 = New System.Windows.Forms.RadioButton()
      Me.rdoGarage2 = New System.Windows.Forms.RadioButton()
      Me.rdoGarage1 = New System.Windows.Forms.RadioButton()
      Me.btnRooms = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnList = New System.Windows.Forms.Button()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.btnGarages = New System.Windows.Forms.Button()
      Me.grpRooms.SuspendLayout()
      Me.grpGarages.SuspendLayout()
      Me.SuspendLayout()
      '
      'cobType
      '
      Me.cobType.FormattingEnabled = True
      Me.cobType.Items.AddRange(New Object() {"Chicago", "Madison", "Platteville"})
      Me.cobType.Location = New System.Drawing.Point(81, 69)
      Me.cobType.Name = "cobType"
      Me.cobType.Size = New System.Drawing.Size(121, 21)
      Me.cobType.TabIndex = 0
      '
      'txtID
      '
      Me.txtID.Location = New System.Drawing.Point(81, 140)
      Me.txtID.Name = "txtID"
      Me.txtID.Size = New System.Drawing.Size(100, 20)
      Me.txtID.TabIndex = 1
      '
      'txtPrice
      '
      Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
      Me.txtPrice.Location = New System.Drawing.Point(81, 211)
      Me.txtPrice.Name = "txtPrice"
      Me.txtPrice.ReadOnly = True
      Me.txtPrice.Size = New System.Drawing.Size(100, 20)
      Me.txtPrice.TabIndex = 2
      Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'grpRooms
      '
      Me.grpRooms.Controls.Add(Me.rdoRoom2)
      Me.grpRooms.Controls.Add(Me.rdoRoom3)
      Me.grpRooms.Controls.Add(Me.rdoRoom4)
      Me.grpRooms.Enabled = False
      Me.grpRooms.Location = New System.Drawing.Point(310, 84)
      Me.grpRooms.Name = "grpRooms"
      Me.grpRooms.Size = New System.Drawing.Size(200, 100)
      Me.grpRooms.TabIndex = 3
      Me.grpRooms.TabStop = False
      Me.grpRooms.Text = "Rooms"
      '
      'rdoRoom2
      '
      Me.rdoRoom2.AutoSize = True
      Me.rdoRoom2.Location = New System.Drawing.Point(150, 45)
      Me.rdoRoom2.Name = "rdoRoom2"
      Me.rdoRoom2.Size = New System.Drawing.Size(31, 17)
      Me.rdoRoom2.TabIndex = 2
      Me.rdoRoom2.TabStop = True
      Me.rdoRoom2.Text = "2"
      Me.rdoRoom2.UseVisualStyleBackColor = True
      '
      'rdoRoom3
      '
      Me.rdoRoom3.AutoSize = True
      Me.rdoRoom3.Location = New System.Drawing.Point(80, 45)
      Me.rdoRoom3.Name = "rdoRoom3"
      Me.rdoRoom3.Size = New System.Drawing.Size(31, 17)
      Me.rdoRoom3.TabIndex = 1
      Me.rdoRoom3.TabStop = True
      Me.rdoRoom3.Text = "3"
      Me.rdoRoom3.UseVisualStyleBackColor = True
      '
      'rdoRoom4
      '
      Me.rdoRoom4.AutoSize = True
      Me.rdoRoom4.Location = New System.Drawing.Point(20, 45)
      Me.rdoRoom4.Name = "rdoRoom4"
      Me.rdoRoom4.Size = New System.Drawing.Size(31, 17)
      Me.rdoRoom4.TabIndex = 0
      Me.rdoRoom4.TabStop = True
      Me.rdoRoom4.Text = "4"
      Me.rdoRoom4.UseVisualStyleBackColor = True
      '
      'grpGarages
      '
      Me.grpGarages.Controls.Add(Me.rdoGarage3)
      Me.grpGarages.Controls.Add(Me.rdoGarage2)
      Me.grpGarages.Controls.Add(Me.rdoGarage1)
      Me.grpGarages.Enabled = False
      Me.grpGarages.Location = New System.Drawing.Point(310, 211)
      Me.grpGarages.Name = "grpGarages"
      Me.grpGarages.Size = New System.Drawing.Size(200, 100)
      Me.grpGarages.TabIndex = 4
      Me.grpGarages.TabStop = False
      Me.grpGarages.Text = "Garages"
      '
      'rdoGarage3
      '
      Me.rdoGarage3.AutoSize = True
      Me.rdoGarage3.Location = New System.Drawing.Point(20, 49)
      Me.rdoGarage3.Name = "rdoGarage3"
      Me.rdoGarage3.Size = New System.Drawing.Size(31, 17)
      Me.rdoGarage3.TabIndex = 3
      Me.rdoGarage3.TabStop = True
      Me.rdoGarage3.Text = "3"
      Me.rdoGarage3.UseVisualStyleBackColor = True
      '
      'rdoGarage2
      '
      Me.rdoGarage2.AutoSize = True
      Me.rdoGarage2.Location = New System.Drawing.Point(80, 49)
      Me.rdoGarage2.Name = "rdoGarage2"
      Me.rdoGarage2.Size = New System.Drawing.Size(31, 17)
      Me.rdoGarage2.TabIndex = 4
      Me.rdoGarage2.TabStop = True
      Me.rdoGarage2.Text = "2"
      Me.rdoGarage2.UseVisualStyleBackColor = True
      '
      'rdoGarage1
      '
      Me.rdoGarage1.AutoSize = True
      Me.rdoGarage1.Location = New System.Drawing.Point(150, 49)
      Me.rdoGarage1.Name = "rdoGarage1"
      Me.rdoGarage1.Size = New System.Drawing.Size(31, 17)
      Me.rdoGarage1.TabIndex = 5
      Me.rdoGarage1.TabStop = True
      Me.rdoGarage1.Text = "1"
      Me.rdoGarage1.UseVisualStyleBackColor = True
      '
      'btnRooms
      '
      Me.btnRooms.Enabled = False
      Me.btnRooms.Location = New System.Drawing.Point(596, 105)
      Me.btnRooms.Name = "btnRooms"
      Me.btnRooms.Size = New System.Drawing.Size(130, 23)
      Me.btnRooms.TabIndex = 5
      Me.btnRooms.Text = "MODIFY &ROOMS"
      Me.btnRooms.UseVisualStyleBackColor = True
      '
      'btnSave
      '
      Me.btnSave.Location = New System.Drawing.Point(106, 378)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(75, 23)
      Me.btnSave.TabIndex = 6
      Me.btnSave.Text = "&SAVE"
      Me.btnSave.UseVisualStyleBackColor = True
      '
      'btnList
      '
      Me.btnList.Location = New System.Drawing.Point(346, 378)
      Me.btnList.Name = "btnList"
      Me.btnList.Size = New System.Drawing.Size(75, 23)
      Me.btnList.TabIndex = 7
      Me.btnList.Text = "&LIST"
      Me.btnList.UseVisualStyleBackColor = True
      '
      'btnExit
      '
      Me.btnExit.Location = New System.Drawing.Point(586, 378)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(75, 23)
      Me.btnExit.TabIndex = 8
      Me.btnExit.Text = "E&XIT"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'btnGarages
      '
      Me.btnGarages.Enabled = False
      Me.btnGarages.Location = New System.Drawing.Point(596, 233)
      Me.btnGarages.Name = "btnGarages"
      Me.btnGarages.Size = New System.Drawing.Size(130, 23)
      Me.btnGarages.TabIndex = 9
      Me.btnGarages.Text = "MODIFY &GARAGES"
      Me.btnGarages.UseVisualStyleBackColor = True
      '
      'FormClassHouse
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(760, 457)
      Me.Controls.Add(Me.btnGarages)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnList)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnRooms)
      Me.Controls.Add(Me.grpGarages)
      Me.Controls.Add(Me.grpRooms)
      Me.Controls.Add(Me.txtPrice)
      Me.Controls.Add(Me.txtID)
      Me.Controls.Add(Me.cobType)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "FormClassHouse"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Form Class House - Thomas Lambert"
      Me.grpRooms.ResumeLayout(False)
      Me.grpRooms.PerformLayout()
      Me.grpGarages.ResumeLayout(False)
      Me.grpGarages.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents cobType As ComboBox
   Friend WithEvents txtID As TextBox
   Friend WithEvents txtPrice As TextBox
   Friend WithEvents grpRooms As GroupBox
   Friend WithEvents grpGarages As GroupBox
   Friend WithEvents rdoRoom2 As RadioButton
   Friend WithEvents rdoRoom3 As RadioButton
   Friend WithEvents rdoRoom4 As RadioButton
   Friend WithEvents rdoGarage3 As RadioButton
   Friend WithEvents rdoGarage2 As RadioButton
   Friend WithEvents rdoGarage1 As RadioButton
   Friend WithEvents btnRooms As Button
   Friend WithEvents btnSave As Button
   Friend WithEvents btnList As Button
   Friend WithEvents btnExit As Button
   Friend WithEvents btnGarages As Button
End Class
