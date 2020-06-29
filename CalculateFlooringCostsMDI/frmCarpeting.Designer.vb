<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarpeting
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtInstallation = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtPadding = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtCarpeting = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.chkPadding = New System.Windows.Forms.CheckBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(131, 210)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(22, 210)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 28
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(106, 173)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 27
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtTotal, "Total Costs.")
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(19, 176)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(34, 13)
        Me.label6.TabIndex = 26
        Me.label6.Text = "Total:"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInstallation
        '
        Me.txtInstallation.Location = New System.Drawing.Point(106, 147)
        Me.txtInstallation.Name = "txtInstallation"
        Me.txtInstallation.ReadOnly = True
        Me.txtInstallation.Size = New System.Drawing.Size(100, 20)
        Me.txtInstallation.TabIndex = 25
        Me.txtInstallation.TabStop = False
        Me.txtInstallation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtInstallation, "Installation")
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(19, 150)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(60, 13)
        Me.label5.TabIndex = 24
        Me.label5.Text = "Installation:"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPadding
        '
        Me.txtPadding.Location = New System.Drawing.Point(106, 121)
        Me.txtPadding.Name = "txtPadding"
        Me.txtPadding.ReadOnly = True
        Me.txtPadding.Size = New System.Drawing.Size(100, 20)
        Me.txtPadding.TabIndex = 23
        Me.txtPadding.TabStop = False
        Me.txtPadding.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtPadding, "Padding")
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(19, 124)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(49, 13)
        Me.label4.TabIndex = 22
        Me.label4.Text = "Padding:"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCarpeting
        '
        Me.txtCarpeting.Location = New System.Drawing.Point(106, 95)
        Me.txtCarpeting.Name = "txtCarpeting"
        Me.txtCarpeting.ReadOnly = True
        Me.txtCarpeting.Size = New System.Drawing.Size(100, 20)
        Me.txtCarpeting.TabIndex = 21
        Me.txtCarpeting.TabStop = False
        Me.txtCarpeting.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCarpeting, "Carpeting")
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(19, 95)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(55, 13)
        Me.label3.TabIndex = 20
        Me.label3.Text = "Carpeting:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPadding
        '
        Me.chkPadding.AutoSize = True
        Me.chkPadding.Location = New System.Drawing.Point(106, 72)
        Me.chkPadding.Name = "chkPadding"
        Me.chkPadding.Size = New System.Drawing.Size(107, 17)
        Me.chkPadding.TabIndex = 19
        Me.chkPadding.Text = "Padding upgrade"
        Me.ToolTip1.SetToolTip(Me.chkPadding, "Padding upgrade: $0.39 per sq ft")
        Me.chkPadding.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.HelpProvider1.SetHelpString(Me.txtCost, "Enter cost of area per sq ft.")
        Me.txtCost.Location = New System.Drawing.Point(106, 46)
        Me.txtCost.Name = "txtCost"
        Me.HelpProvider1.SetShowHelp(Me.txtCost, True)
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 18
        Me.txtCost.Tag = "Cost per square foot"
        Me.ToolTip1.SetToolTip(Me.txtCost, "Enter cost of area per sq ft.")
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(19, 49)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(78, 13)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Cost per sq. ft.:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtArea
        '
        Me.HelpProvider1.SetHelpString(Me.txtArea, "Enter area in square ft.")
        Me.txtArea.Location = New System.Drawing.Point(106, 20)
        Me.txtArea.Name = "txtArea"
        Me.HelpProvider1.SetShowHelp(Me.txtArea, True)
        Me.txtArea.Size = New System.Drawing.Size(100, 20)
        Me.txtArea.TabIndex = 16
        Me.txtArea.Tag = "Area"
        Me.ToolTip1.SetToolTip(Me.txtArea, "Enter area in square ft.")
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(19, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 13)
        Me.label1.TabIndex = 15
        Me.label1.Text = "Area (sq. ft.):"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.label1, "Enter area in square ft.")
        '
        'frmCarpeting
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(229, 249)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtInstallation)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtPadding)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.txtCarpeting)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.chkPadding)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpKeyword(Me, "Calculates carpeting costs.")
        Me.HelpProvider1.SetHelpString(Me, "Calculates carpeting costs.")
        Me.Name = "frmCarpeting"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Carpeting Costs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents btnCalculate As System.Windows.Forms.Button
    Private WithEvents txtTotal As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txtInstallation As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtPadding As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtCarpeting As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents chkPadding As System.Windows.Forms.CheckBox
    Private WithEvents txtCost As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtArea As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
