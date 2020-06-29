<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFlooringCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.File = New System.Windows.Forms.MenuStrip()
        Me.CarpetingCosts = New System.Windows.Forms.ToolStripMenuItem()
        Me.Carpet = New System.Windows.Forms.ToolStripMenuItem()
        Me.Hardwood = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseActiveForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.Window = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cascaded = New System.Windows.Forms.ToolStripMenuItem()
        Me.Vertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.Horizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsCarpetingCosts = New System.Windows.Forms.ToolStripLabel()
        Me.tsHardwoodCosts = New System.Windows.Forms.ToolStripLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.File.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'File
        '
        Me.File.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarpetingCosts, Me.Window})
        Me.File.Location = New System.Drawing.Point(0, 0)
        Me.File.MdiWindowListItem = Me.Window
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(1458, 24)
        Me.File.TabIndex = 1
        Me.File.Text = "File"
        '
        'CarpetingCosts
        '
        Me.CarpetingCosts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Carpet, Me.Hardwood, Me.CloseActiveForm, Me.ToolStripSeparator1, Me.CloseProgram})
        Me.CarpetingCosts.Name = "CarpetingCosts"
        Me.CarpetingCosts.Size = New System.Drawing.Size(37, 20)
        Me.CarpetingCosts.Text = "&File"
        '
        'Carpet
        '
        Me.Carpet.Name = "Carpet"
        Me.Carpet.Size = New System.Drawing.Size(170, 22)
        Me.Carpet.Text = "&Carpeting"
        '
        'Hardwood
        '
        Me.Hardwood.Name = "Hardwood"
        Me.Hardwood.Size = New System.Drawing.Size(170, 22)
        Me.Hardwood.Text = "&Hardwood"
        '
        'CloseActiveForm
        '
        Me.CloseActiveForm.Name = "CloseActiveForm"
        Me.CloseActiveForm.Size = New System.Drawing.Size(170, 22)
        Me.CloseActiveForm.Text = "Close &Active Form"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'CloseProgram
        '
        Me.CloseProgram.Name = "CloseProgram"
        Me.CloseProgram.Size = New System.Drawing.Size(170, 22)
        Me.CloseProgram.Text = "E&xit"
        '
        'Window
        '
        Me.Window.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cascaded, Me.Vertical, Me.Horizontal})
        Me.Window.Name = "Window"
        Me.Window.Size = New System.Drawing.Size(63, 20)
        Me.Window.Text = "&Window"
        '
        'Cascaded
        '
        Me.Cascaded.Name = "Cascaded"
        Me.Cascaded.Size = New System.Drawing.Size(168, 22)
        Me.Cascaded.Text = "Cascaded Layout"
        '
        'Vertical
        '
        Me.Vertical.Name = "Vertical"
        Me.Vertical.Size = New System.Drawing.Size(168, 22)
        Me.Vertical.Text = "Vertical Layout"
        '
        'Horizontal
        '
        Me.Horizontal.Name = "Horizontal"
        Me.Horizontal.Size = New System.Drawing.Size(168, 22)
        Me.Horizontal.Text = "Horizontal Layout"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCarpetingCosts, Me.tsHardwoodCosts})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1458, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsCarpetingCosts
        '
        Me.tsCarpetingCosts.Name = "tsCarpetingCosts"
        Me.tsCarpetingCosts.Size = New System.Drawing.Size(91, 22)
        Me.tsCarpetingCosts.Text = "Carpeting Costs"
        '
        'tsHardwoodCosts
        '
        Me.tsHardwoodCosts.Name = "tsHardwoodCosts"
        Me.tsHardwoodCosts.Size = New System.Drawing.Size(95, 22)
        Me.tsHardwoodCosts.Text = "Hardwood Costs"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 477)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1458, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssCount
        '
        Me.tssCount.Name = "tssCount"
        Me.tssCount.Size = New System.Drawing.Size(237, 17)
        Me.tssCount.Text = "Number of child forms currently displayed: "
        '
        'frmFlooringCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1458, 499)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.File)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.File
        Me.Name = "frmFlooringCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flooring Calculator"
        Me.File.ResumeLayout(False)
        Me.File.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents File As MenuStrip
    Friend WithEvents CarpetingCosts As ToolStripMenuItem
    Friend WithEvents Carpet As ToolStripMenuItem
    Friend WithEvents Hardwood As ToolStripMenuItem
    Friend WithEvents CloseActiveForm As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseProgram As ToolStripMenuItem
    Friend WithEvents Window As ToolStripMenuItem
    Friend WithEvents Cascaded As ToolStripMenuItem
    Friend WithEvents Vertical As ToolStripMenuItem
    Friend WithEvents Horizontal As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsCarpetingCosts As ToolStripLabel
    Friend WithEvents tsHardwoodCosts As ToolStripLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tssCount As ToolStripStatusLabel
End Class
