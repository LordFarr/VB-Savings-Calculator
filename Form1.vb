Option Strict On
Public Class frmSavings
    Dim Deposit As Double
    Dim Interest As Double
    Dim Months As Double
    Dim Final As Double

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim IntRate As Double
        Dim FinalCompute As Double, IntChange As Double, IntDirection As Integer

        Deposit = Val(txtDeposit.Text)
        Interest = Val(txtInterest.Text)
        Months = Val(txtMonths.Text)
        IntRate = Interest / 1200     '12 months and 100 to convert to decimal
        Final = Val(txtBalance.Text)

        If Trim(txtDeposit.Text) = "" Then
            If Interest = 0 Then
                Deposit = Final / Months
            Else
                Deposit = Final / (((1 + IntRate) ^ Months - 1) / IntRate)
            End If
            txtDeposit.Text = Format(Deposit, "0.00")

        ElseIf Trim(txtInterest.Text) = "" Then
            Interest = 0
            IntChange = 1
            IntDirection = 1
            Do
                Interest += IntDirection * IntChange
                IntRate = Interest / 1200
                FinalCompute = Deposit * ((1 + IntRate) ^ Months - 1) / IntRate
                If IntDirection = 1 Then
                    If FinalCompute > Final Then
                        IntDirection = -1
                        IntChange /= 10
                    End If
                Else
                    If FinalCompute < Final Then
                        IntDirection = 1
                        IntChange /= 10
                    End If
                End If
            Loop Until Math.Abs(FinalCompute - final) < 0.005
            txtInterest.Text = Format(Interest, "0.00")

        ElseIf Trim(txtMonths.Text) = "" Then
            If Interest = 0 Then
                Months = Final / Deposit
            Else
                Months = Math.Log(Final * IntRate / Deposit + 1) / Math.Log(1 + IntRate)
            End If
            txtMonths.Text = Format(Months, "0.00")

        ElseIf Trim(txtBalance.Text) = "" Then
            If Interest = 0 Then
                Final = Deposit * Months
            Else
                Final = Deposit * ((1 + IntRate) ^ Months - 1) / IntRate
            End If
            txtBalance.Text = Format(Final, "0.00")
        End If




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtDeposit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeposit.KeyPress
        Select Case e.KeyChar
            Case CChar("0") To CChar("9"), ControlChars.Back
                e.Handled = False
            Case ControlChars.Cr
                txtInterest.Focus()
            Case CChar(".")
                If InStr(txtDeposit.Text, ".") = 0 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If

            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtInterest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInterest.KeyPress
        Select Case e.KeyChar
            Case CChar("0") To CChar("9"), ControlChars.Back
                e.Handled = False
            Case ControlChars.Cr
                txtMonths.Focus()
            Case CChar(".")
                If InStr(txtDeposit.Text, ".") = 0 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If

            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtMonths_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonths.KeyPress
        Select Case e.KeyChar
            Case CChar("0") To CChar("9"), ControlChars.Back
                e.Handled = False
            Case ControlChars.Cr
                btnCalculate.Focus()
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub txtBalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBalance.KeyPress
        Select Case e.KeyChar
            Case CChar("0") To CChar("9"), ControlChars.Back
                e.Handled = False
            Case ControlChars.Cr
                txtInterest.Focus()
            Case CChar(".")
                If InStr(txtDeposit.Text, ".") = 0 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If

            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDeposit.Text = ""
        txtInterest.Text = ""
        txtMonths.Text = ""
        txtBalance.Text = ""
    End Sub


End Class
