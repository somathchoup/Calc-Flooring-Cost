<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHardwood
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
        Me.rdoFloating = New System.Windows.Forms.RadioButton()
        Me.rdoStandard = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtInstallation = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtHardwood = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'rdoFloating
        '
        Me.rdoFloating.AutoSize = True
        Me.rdoFloating.Location = New System.Drawing.Point(144, 75)
        Me.rdoFloating.Name = "rdoFloating"
        Me.rdoFloating.Size = New System.Drawing.Size(62, 17)
        Me.rdoFloating.TabIndex = 19
        Me.rdoFloating.TabStop = True
        Me.rdoFloating.Text = "Floating"
        Me.ToolTip1.SetToolTip(Me.rdoFloating, "Cost of floating: $1.99")
        Me.rdoFloating.UseVisualStyleBackColor = True
        '
        'rdoStandard
        '
        Me.rdoStandard.AutoSize = True
        Me.rdoStandard.Checked = True
        Me.rdoStandard.Location = New System.Drawing.Point(69, 75)
        Me.rdoStandard.Name = "rdoStandard"
        Me.rdoStandard.Size = New System.Drawing.Size(68, 17)
        Me.rdoStandard.TabIndex = 18
        Me.rdoStandard.TabStop = True
        Me.rdoStandard.Text = "Standard"
        Me.ToolTip1.SetToolTip(Me.rdoStandard, "Cost of standard: $2.99")
        Me.rdoStandard.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(131, 186)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(22, 186)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 26
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(106, 150)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 25
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtTotal, "Total Cost.")
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(19, 153)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(34, 13)
        Me.label6.TabIndex = 24
        Me.label6.Text = "Total:"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInstallation
        '
        Me.txtInstallation.Location = New System.Drawing.Point(106, 124)
        Me.txtInstallation.Name = "txtInstallation"
        Me.txtInstallation.ReadOnly = True
        Me.txtInstallation.Size = New System.Drawing.Size(100, 20)
        Me.txtInstallation.TabIndex = 23
        Me.txtInstallation.TabStop = False
        Me.txtInstallation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtInstallation, "Cost of installation.")
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(19, 127)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(60, 13)
        Me.label5.TabIndex = 22
        Me.label5.Text = "Installation:"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHardwood
        '
        Me.txtHardwood.Location = New System.Drawing.Point(106, 98)
        Me.txtHardwood.Name = "txtHardwood"
        Me.txtHardwood.ReadOnly = True
        Me.txtHardwood.Size = New System.Drawing.Size(100, 20)
        Me.txtHardwood.TabIndex = 21
        Me.txtHardwood.TabStop = False
        Me.txtHardwood.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtHardwood, "Cost of hardwood.")
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(19, 101)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(59, 13)
        Me.label3.TabIndex = 20
        Me.label3.Text = "Hardwood:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCost
        '
        Me.HelpProvider1.SetHelpString(Me.txtCost, "Enter cost per sq ft.")
        Me.txtCost.Location = New System.Drawing.Point(106, 49)
        Me.txtCost.Name = "txtCost"
        Me.HelpProvider1.SetShowHelp(Me.txtCost, True)
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 17
        Me.txtCost.Tag = "Cost per square foot"
        Me.ToolTip1.SetToolTip(Me.txtCost, "Enter cost per sq ft.")
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(19, 52)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(78, 13)
        Me.label2.TabIndex = 16
        Me.label2.Text = "Cost per sq. ft.:"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtArea
        '
        Me.HelpProvider1.SetHelpString(Me.txtArea, "Enter the area.")
        Me.txtArea.Location = New System.Drawing.Point(106, 23)
        Me.txtArea.Name = "txtArea"
        Me.HelpProvider1.SetShowHelp(Me.txtArea, True)
        Me.txtArea.Size = New System.Drawing.Size(100, 20)
        Me.txtArea.TabIndex = 15
        Me.txtArea.Tag = "Area"
        Me.ToolTip1.SetToolTip(Me.txtArea, "Enter the area.")
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(19, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 13)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Area (sq. ft.):"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmHardwood
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(228, 227)
        Me.Controls.Add(Me.rdoFloating)
        Me.Controls.Add(Me.rdoStandard)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtInstallation)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtHardwood)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpString(Me, "Calculatse hardwood costs.")
        Me.Name = "frmHardwood"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Hardwood Costs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents rdoFloating As System.Windows.Forms.RadioButton
    Private WithEvents rdoStandard As System.Windows.Forms.RadioButton
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents btnCalculate As System.Windows.Forms.Button
    Private WithEvents txtTotal As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txtInstallation As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtHardwood As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtCost As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtArea As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
