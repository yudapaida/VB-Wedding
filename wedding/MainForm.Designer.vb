<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EVENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KEDATANGANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUMBANGANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CETAKBARCODEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SINGLEBARCODEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MULTIBARCODEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EVENTToolStripMenuItem, Me.CETAKBARCODEToolStripMenuItem, Me.DATAToolStripMenuItem, Me.LAPORANToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(876, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EVENTToolStripMenuItem
        '
        Me.EVENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KEDATANGANToolStripMenuItem, Me.SUMBANGANToolStripMenuItem})
        Me.EVENTToolStripMenuItem.Name = "EVENTToolStripMenuItem"
        Me.EVENTToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.EVENTToolStripMenuItem.Text = "EVENT"
        '
        'KEDATANGANToolStripMenuItem
        '
        Me.KEDATANGANToolStripMenuItem.Name = "KEDATANGANToolStripMenuItem"
        Me.KEDATANGANToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KEDATANGANToolStripMenuItem.Text = "KEDATANGAN"
        '
        'SUMBANGANToolStripMenuItem
        '
        Me.SUMBANGANToolStripMenuItem.Name = "SUMBANGANToolStripMenuItem"
        Me.SUMBANGANToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SUMBANGANToolStripMenuItem.Text = "SUMBANGAN"
        '
        'CETAKBARCODEToolStripMenuItem
        '
        Me.CETAKBARCODEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SINGLEBARCODEToolStripMenuItem, Me.MULTIBARCODEToolStripMenuItem})
        Me.CETAKBARCODEToolStripMenuItem.Name = "CETAKBARCODEToolStripMenuItem"
        Me.CETAKBARCODEToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.CETAKBARCODEToolStripMenuItem.Text = "CETAK BARCODE"
        '
        'SINGLEBARCODEToolStripMenuItem
        '
        Me.SINGLEBARCODEToolStripMenuItem.Name = "SINGLEBARCODEToolStripMenuItem"
        Me.SINGLEBARCODEToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SINGLEBARCODEToolStripMenuItem.Text = "SINGLE BARCODE"
        '
        'DATAToolStripMenuItem
        '
        Me.DATAToolStripMenuItem.Name = "DATAToolStripMenuItem"
        Me.DATAToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.DATAToolStripMenuItem.Text = "DATA"
        '
        'LAPORANToolStripMenuItem
        '
        Me.LAPORANToolStripMenuItem.Name = "LAPORANToolStripMenuItem"
        Me.LAPORANToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LAPORANToolStripMenuItem.Text = "LAPORAN"
        Me.LAPORANToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'MULTIBARCODEToolStripMenuItem
        '
        Me.MULTIBARCODEToolStripMenuItem.Name = "MULTIBARCODEToolStripMenuItem"
        Me.MULTIBARCODEToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.MULTIBARCODEToolStripMenuItem.Text = "MULTI BARCODE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 311)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EVENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KEDATANGANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUMBANGANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CETAKBARCODEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SINGLEBARCODEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LAPORANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MULTIBARCODEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
