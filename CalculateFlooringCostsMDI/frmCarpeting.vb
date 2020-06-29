Public Class frmCarpeting

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        If IsValidData() Then
            Dim area As Decimal = CDec(txtArea.Text)
            Dim carpetingUnitCost As Decimal = CDec(txtCost.Text)
            Dim carpetingCost As Decimal = area * carpetingUnitCost
            Dim paddingCost As Decimal = 0
            If chkPadding.Checked Then
                paddingCost = area * 0.39D
            End If
            Dim installationCost As Decimal = area * 0.99D
            Dim totalCost As Decimal = carpetingCost + paddingCost + installationCost

            txtCarpeting.Text = FormatCurrency(carpetingCost)
            txtPadding.Text = FormatCurrency(paddingCost)
            txtInstallation.Text = FormatCurrency(installationCost)
            txtTotal.Text = FormatCurrency(totalCost.ToString)

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
            Validator.IsWithinRange(txtCost, 0.99D, 50)
    End Function

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Disposed(sender As Object, e As EventArgs) Handles btnExit.Disposed
        frmFlooringCalculator.subtractCount()
    End Sub

End Class
