<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavings
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
        Me.lblDeposit = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.lblMonths = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDeposit
        '
        Me.lblDeposit.AutoSize = True
        Me.lblDeposit.Location = New System.Drawing.Point(270, 73)
        Me.lblDeposit.Name = "lblDeposit"
        Me.lblDeposit.Size = New System.Drawing.Size(123, 20)
        Me.lblDeposit.TabIndex = 0
        Me.lblDeposit.Text = "Monthly Deposit"
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Location = New System.Drawing.Point(270, 133)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(112, 20)
        Me.lblInterest.TabIndex = 1
        Me.lblInterest.Text = "Yearly Interest"
        '
        'lblMonths
        '
        Me.lblMonths.AutoSize = True
        Me.lblMonths.Location = New System.Drawing.Point(270, 198)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.Size = New System.Drawing.Size(140, 20)
        Me.lblMonths.TabIndex = 2
        Me.lblMonths.Text = "Number of Months"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(270, 266)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(105, 20)
        Me.lblBalance.TabIndex = 3
        Me.lblBalance.Text = "Final Balance"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(548, 67)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(100, 26)
        Me.txtDeposit.TabIndex = 4
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(548, 127)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(100, 26)
        Me.txtInterest.TabIndex = 5
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(548, 192)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(100, 26)
        Me.txtMonths.TabIndex = 6
        '
        'txtBalance
        '
        Me.txtBalance.AcceptsReturn = True
        Me.txtBalance.AcceptsTab = True
        Me.txtBalance.BackColor = System.Drawing.SystemColors.Window
        Me.txtBalance.Location = New System.Drawing.Point(548, 260)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(100, 26)
        Me.txtBalance.TabIndex = 7
        Me.txtBalance.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(293, 309)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(142, 51)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(375, 385)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 44)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(466, 309)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 51)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmSavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtMonths)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblMonths)
        Me.Controls.Add(Me.lblInterest)
        Me.Controls.Add(Me.lblDeposit)
        Me.Name = "frmSavings"
        Me.Text = "Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblInterest As Label
    Friend WithEvents lblMonths As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class
