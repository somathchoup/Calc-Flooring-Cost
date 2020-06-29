Public Class frmFlooringCalculator


    Private mCount As Integer = 0

    Private Sub CloseProgram_Click(sender As Object, e As EventArgs) Handles CloseProgram.Click
        ' Closes the program
        Me.Close()
    End Sub

    ' Creates new instance of frmCarpeting
    Private Sub Carpet_Click(sender As Object, e As EventArgs) Handles Carpet.Click
        Dim carpetingForm As New frmCarpeting
        carpetingForm.MdiParent = Me
        carpetingForm.Show()

        ' Increases count
        mCount += 1

    End Sub

    ' Creates new instance of frmHardwood
    Private Sub Hardwood_Click(sender As Object, e As EventArgs) Handles Hardwood.Click
        Dim hardwoodForm As New frmHardwood
        hardwoodForm.MdiParent = Me
        hardwoodForm.Show()

        ' Increases count
        mCount += 1

    End Sub

    ' Closes active child form
    Private Sub CloseActiveForm_Click(sender As Object, e As EventArgs) Handles CloseActiveForm.Click
        Dim activeForm As Form = Me.ActiveMdiChild
        If activeForm IsNot Nothing Then
            activeForm.Close()

            ' Decreases count
            subtractCount()
        End If
    End Sub

    ' Arranges in cascade
    Private Sub Cascaded_Click(sender As Object, e As EventArgs) Handles Cascaded.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    ' Arranges in vertical
    Private Sub Vertical_Click(sender As Object, e As EventArgs) Handles Vertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    ' Arranges in horizontal
    Private Sub Horizontal_Click(sender As Object, e As EventArgs) Handles Horizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    ' Creates new instance of frmCarpeting
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles tsCarpetingCosts.Click
        Dim carpetingForm As New frmCarpeting
        carpetingForm.MdiParent = Me
        carpetingForm.Show()

        ' Increases count
        mCount += 1
    End Sub

    ' Creates new instance of frmHardwood
    Private Sub tsHardwoodCosts_Click(sender As Object, e As EventArgs) Handles tsHardwoodCosts.Click
        Dim hardwoodForm As New frmHardwood
        hardwoodForm.MdiParent = Me
        hardwoodForm.Show()

        ' Increases count
        mCount += 1

    End Sub

    Public Sub subtractCount()
        Me.mCount -= 1
    End Sub

    Public Sub DisplayFormCount()
        tssCount.Text = "Number of child forms currently displayed: " + mCount.ToString
    End Sub

    Private Sub frmFlooringCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayFormCount()
    End Sub

    Private Sub tssCount_Click(sender As Object, e As EventArgs) Handles tssCount.Click
        DisplayFormCount()
    End Sub
End Class