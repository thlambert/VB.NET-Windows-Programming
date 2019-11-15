<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReaderWriterForm
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
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtLog = New System.Windows.Forms.TextBox()
      Me.txtTotal = New System.Windows.Forms.TextBox()
      Me.lstWaiting = New System.Windows.Forms.ListBox()
      Me.lstWorking = New System.Windows.Forms.ListBox()
      Me.btnReader = New System.Windows.Forms.Button()
      Me.btnWriter = New System.Windows.Forms.Button()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(110, 90)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(47, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Working"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(332, 35)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(34, 13)
      Me.Label2.TabIndex = 1
      Me.Label2.Text = "Total:"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(661, 90)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(43, 13)
      Me.Label3.TabIndex = 2
      Me.Label3.Text = "Waiting"
      '
      'txtLog
      '
      Me.txtLog.BackColor = System.Drawing.SystemColors.Window
      Me.txtLog.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtLog.Location = New System.Drawing.Point(263, 84)
      Me.txtLog.Multiline = True
      Me.txtLog.Name = "txtLog"
      Me.txtLog.ReadOnly = True
      Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtLog.Size = New System.Drawing.Size(304, 215)
      Me.txtLog.TabIndex = 3
      '
      'txtTotal
      '
      Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
      Me.txtTotal.Location = New System.Drawing.Point(398, 32)
      Me.txtTotal.Name = "txtTotal"
      Me.txtTotal.ReadOnly = True
      Me.txtTotal.Size = New System.Drawing.Size(100, 20)
      Me.txtTotal.TabIndex = 4
      Me.txtTotal.Text = "1000"
      Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'lstWaiting
      '
      Me.lstWaiting.FormattingEnabled = True
      Me.lstWaiting.Location = New System.Drawing.Point(614, 126)
      Me.lstWaiting.Name = "lstWaiting"
      Me.lstWaiting.Size = New System.Drawing.Size(184, 173)
      Me.lstWaiting.TabIndex = 5
      '
      'lstWorking
      '
      Me.lstWorking.FormattingEnabled = True
      Me.lstWorking.Location = New System.Drawing.Point(40, 126)
      Me.lstWorking.Name = "lstWorking"
      Me.lstWorking.Size = New System.Drawing.Size(184, 173)
      Me.lstWorking.TabIndex = 6
      '
      'btnReader
      '
      Me.btnReader.Location = New System.Drawing.Point(220, 341)
      Me.btnReader.Name = "btnReader"
      Me.btnReader.Size = New System.Drawing.Size(75, 23)
      Me.btnReader.TabIndex = 7
      Me.btnReader.Text = "New Reader"
      Me.btnReader.UseVisualStyleBackColor = True
      '
      'btnWriter
      '
      Me.btnWriter.Location = New System.Drawing.Point(364, 341)
      Me.btnWriter.Name = "btnWriter"
      Me.btnWriter.Size = New System.Drawing.Size(75, 23)
      Me.btnWriter.TabIndex = 8
      Me.btnWriter.Text = "New Writer"
      Me.btnWriter.UseVisualStyleBackColor = True
      '
      'btnExit
      '
      Me.btnExit.Location = New System.Drawing.Point(527, 341)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(75, 23)
      Me.btnExit.TabIndex = 9
      Me.btnExit.Text = "Exit"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'ReaderWriterForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(830, 417)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnWriter)
      Me.Controls.Add(Me.btnReader)
      Me.Controls.Add(Me.lstWorking)
      Me.Controls.Add(Me.lstWaiting)
      Me.Controls.Add(Me.txtTotal)
      Me.Controls.Add(Me.txtLog)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "ReaderWriterForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "FIFO: Readers and Writers - Thomas Lambert"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents txtLog As TextBox
   Friend WithEvents txtTotal As TextBox
   Friend WithEvents lstWaiting As ListBox
   Friend WithEvents lstWorking As ListBox
   Friend WithEvents btnReader As Button
   Friend WithEvents btnWriter As Button
   Friend WithEvents btnExit As Button
End Class
