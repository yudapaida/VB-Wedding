<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMultiBarcode
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
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 128)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(717, 269)
        Me.dgvData.TabIndex = 7
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Location = New System.Drawing.Point(666, 70)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCetak.TabIndex = 10
        Me.ButtonCetak.Text = "Print All"
        Me.ButtonCetak.UseVisualStyleBackColor = True
        '
        'FMultiBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonCetak)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "FMultiBarcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
End Class
