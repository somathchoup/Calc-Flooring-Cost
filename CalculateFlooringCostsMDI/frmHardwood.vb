Public Class frmHardwood

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        If IsValidData() Then
            Dim area As Decimal = CDec(txtArea.Text)
            Dim hardwoodUnitCost As Decimal = CDec(txtCost.Text)
            Dim hardwoodCost As Decimal = area * hardwoodUnitCost
            Dim installationCost As Decimal = 0
            If rdoStandard.Checked Then
                installationCost = area * 2.99D
            Else
                installationCost = area * 1.99D
            End If
            Dim totalCost As Decimal = hardwoodCost + installationCost

            txtHardwood.Text = FormatCurrency(hardwoodCost)
            txtInstallation.Text = FormatCurrency(installationCost)
            txtTotal.Text = FormatCurrency(totalCost)

            txtArea.Select()
        End If
    End Sub

    Private Function IsValidData() As Boolean
        Return _
            Validator.IsPresent(txtArea) AndAlso
            Validator.IsDecimal(txtArea) AndAlso
            Validator.IsWithinRange(txtArea, 50, 10000) AndAlso
            Validator.IsPresent(txtCost) AndAlso
            Validator.IsDecimal(txtCost) AndAlso
            Validator.IsWithinRange(txtCost, 1.99D, 99)
    End Function

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnExit_Disposed(sender As Object, e As EventArgs) Handles btnExit.Disposed
        frmFlooringCalculator.subtractCount()
    End Sub
End Class