<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSingleBarcode
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
        Me.LblNama = New System.Windows.Forms.Label()
        Me.TBInputBarcode = New System.Windows.Forms.TextBox()
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.LabelBarcode = New System.Windows.Forms.Label()
        Me.LabelFont = New System.Windows.Forms.Label()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNama
        '
        Me.LblNama.AutoSize = True
        Me.LblNama.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNama.Location = New System.Drawing.Point(149, 35)
        Me.LblNama.Name = "LblNama"
        Me.LblNama.Size = New System.Drawing.Size(55, 23)
        Me.LblNama.TabIndex = 0
        Me.LblNama.Text = "Nama"
        '
        'TBInputBarcode
        '
        Me.TBInputBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBInputBarcode.Location = New System.Drawing.Point(259, 35)
        Me.TBInputBarcode.Multiline = True
        Me.TBInputBarcode.Name = "TBInputBarcode"
        Me.TBInputBarcode.Size = New System.Drawing.Size(244, 32)
        Me.TBInputBarcode.TabIndex = 1
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Location = New System.Drawing.Point(259, 86)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(81, 35)
        Me.BtnGenerate.TabIndex = 2
        Me.BtnGenerate.Text = "Generate"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(346, 86)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(81, 35)
        Me.BtnPrint.TabIndex = 3
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'LabelBarcode
        '
        Me.LabelBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBarcode.Location = New System.Drawing.Point(12, 133)
        Me.LabelBarcode.Name = "LabelBarcode"
        Me.LabelBarcode.Size = New System.Drawing.Size(717, 98)
        Me.LabelBarcode.TabIndex = 4
        Me.LabelBarcode.Text = "--"
        Me.LabelBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelFont
        '
        Me.LabelFont.BackColor = System.Drawing.Color.White
        Me.LabelFont.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFont.ForeColor = System.Drawing.Color.Black
        Me.LabelFont.Location = New System.Drawing.Point(195, 89)
        Me.LabelFont.Name = "LabelFont"
        Me.LabelFont.Size = New System.Drawing.Size(39, 29)
        Me.LabelFont.TabIndex = 5
        Me.LabelFont.Text = "--"
        Me.LabelFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelFont.Visible = False
        '
        'printDoc
        '
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(18, 247)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(711, 150)
        Me.dgvData.TabIndex = 6
        '
        'FSingleBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.LabelFont)
        Me.Controls.Add(Me.LabelBarcode)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnGenerate)
        Me.Controls.Add(Me.TBInputBarcode)
        Me.Controls.Add(Me.LblNama)
        Me.Name = "FSingleBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents TBInputBarcode As System.Windows.Forms.TextBox
    Friend WithEvents BtnGenerate As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents LabelBarcode As System.Windows.Forms.Label
    Friend WithEvents printDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents LabelFont As System.Windows.Forms.Label
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
End Class
