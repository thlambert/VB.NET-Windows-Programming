<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassThread
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
      Me.txtTransaction = New System.Windows.Forms.TextBox()
      Me.txtBalance = New System.Windows.Forms.TextBox()
      Me.txtLog = New System.Windows.Forms.TextBox()
      Me.lstAllUsers = New System.Windows.Forms.ListBox()
      Me.btnCreate = New System.Windows.Forms.Button()
      Me.btnWait = New System.Windows.Forms.Button()
      Me.btnContinue = New System.Windows.Forms.Button()
      Me.btnTerminate = New System.Windows.Forms.Button()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'txtTransaction
      '
      Me.txtTransaction.BackColor = System.Drawing.SystemColors.Window
      Me.txtTransaction.Location = New System.Drawing.Point(212, 31)
      Me.txtTransaction.Name = "txtTransaction"
      Me.txtTransaction.ReadOnly = True
      Me.txtTransaction.Size = New System.Drawing.Size(100, 20)
      Me.txtTransaction.TabIndex = 0
      Me.txtTransaction.TabStop = False
      Me.txtTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'txtBalance
      '
      Me.txtBalance.BackColor = System.Drawing.SystemColors.Window
      Me.txtBalance.Location = New System.Drawing.Point(410, 31)
      Me.txtBalance.Name = "txtBalance"
      Me.txtBalance.ReadOnly = True
      Me.txtBalance.Size = New System.Drawing.Size(100, 20)
      Me.txtBalance.TabIndex = 1
      Me.txtBalance.TabStop = False
      Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'txtLog
      '
      Me.txtLog.BackColor = System.Drawing.SystemColors.Window
      Me.txtLog.Location = New System.Drawing.Point(38, 92)
      Me.txtLog.Multiline = True
      Me.txtLog.Name = "txtLog"
      Me.txtLog.ReadOnly = True
      Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtLog.Size = New System.Drawing.Size(238, 199)
      Me.txtLog.TabIndex = 2
      Me.txtLog.TabStop = False
      '
      'lstAllUsers
      '
      Me.lstAllUsers.FormattingEnabled = True
      Me.lstAllUsers.Location = New System.Drawing.Point(468, 92)
      Me.lstAllUsers.Name = "lstAllUsers"
      Me.lstAllUsers.Size = New System.Drawing.Size(238, 199)
      Me.lstAllUsers.TabIndex = 3
      '
      'btnCreate
      '
      Me.btnCreate.Location = New System.Drawing.Point(328, 90)
      Me.btnCreate.Name = "btnCreate"
      Me.btnCreate.Size = New System.Drawing.Size(80, 23)
      Me.btnCreate.TabIndex = 4
      Me.btnCreate.Text = "&NEW"
      Me.btnCreate.UseVisualStyleBackColor = True
      '
      'btnWait
      '
      Me.btnWait.Location = New System.Drawing.Point(328, 134)
      Me.btnWait.Name = "btnWait"
      Me.btnWait.Size = New System.Drawing.Size(80, 23)
      Me.btnWait.TabIndex = 5
      Me.btnWait.Text = "&WAIT"
      Me.btnWait.UseVisualStyleBackColor = True
      '
      'btnContinue
      '
      Me.btnContinue.Location = New System.Drawing.Point(328, 172)
      Me.btnContinue.Name = "btnContinue"
      Me.btnContinue.Size = New System.Drawing.Size(80, 23)
      Me.btnContinue.TabIndex = 6
      Me.btnContinue.Text = "&CONTINUE"
      Me.btnContinue.UseVisualStyleBackColor = True
      '
      'btnTerminate
      '
      Me.btnTerminate.Location = New System.Drawing.Point(328, 211)
      Me.btnTerminate.Name = "btnTerminate"
      Me.btnTerminate.Size = New System.Drawing.Size(80, 23)
      Me.btnTerminate.TabIndex = 7
      Me.btnTerminate.Text = "&TERMINATE"
      Me.btnTerminate.UseVisualStyleBackColor = True
      '
      'btnExit
      '
      Me.btnExit.Location = New System.Drawing.Point(328, 254)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(80, 23)
      Me.btnExit.TabIndex = 8
      Me.btnExit.Text = "E&XIT"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(212, 12)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(95, 13)
      Me.Label1.TabIndex = 9
      Me.Label1.Text = "Total Transactions"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(407, 9)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(73, 13)
      Me.Label2.TabIndex = 10
      Me.Label2.Text = "Total Balance"
      '
      'FormClassThread
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(765, 352)
      Me.ControlBox = False
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnTerminate)
      Me.Controls.Add(Me.btnContinue)
      Me.Controls.Add(Me.btnWait)
      Me.Controls.Add(Me.btnCreate)
      Me.Controls.Add(Me.lstAllUsers)
      Me.Controls.Add(Me.txtLog)
      Me.Controls.Add(Me.txtBalance)
      Me.Controls.Add(Me.txtTransaction)
      Me.Name = "FormClassThread"
      Me.Text = "FormClassThread"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents txtTransaction As TextBox
   Friend WithEvents txtBalance As TextBox
   Friend WithEvents txtLog As TextBox
   Friend WithEvents lstAllUsers As ListBox
   Friend WithEvents btnCreate As Button
   Friend WithEvents btnWait As Button
   Friend WithEvents btnContinue As Button
   Friend WithEvents btnTerminate As Button
   Friend WithEvents btnExit As Button
   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
End Class
