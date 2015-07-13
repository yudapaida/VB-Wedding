<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FLaporan
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChartKehadiran = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LabelKehadiran = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxTotalUndangan = New System.Windows.Forms.TextBox()
        Me.TextBoxHadir = New System.Windows.Forms.TextBox()
        Me.TextBoxTidakHdr = New System.Windows.Forms.TextBox()
        Me.TextBoxTotSumbangan = New System.Windows.Forms.TextBox()
        CType(Me.ChartKehadiran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartKehadiran
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartKehadiran.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartKehadiran.Legends.Add(Legend1)
        Me.ChartKehadiran.Location = New System.Drawing.Point(12, 221)
        Me.ChartKehadiran.Name = "ChartKehadiran"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartKehadiran.Series.Add(Series1)
        Me.ChartKehadiran.Size = New System.Drawing.Size(717, 176)
        Me.ChartKehadiran.TabIndex = 0
        Me.ChartKehadiran.Text = "Chart1"
        '
        'LabelKehadiran
        '
        Me.LabelKehadiran.AutoSize = True
        Me.LabelKehadiran.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKehadiran.Location = New System.Drawing.Point(308, 22)
        Me.LabelKehadiran.Name = "LabelKehadiran"
        Me.LabelKehadiran.Size = New System.Drawing.Size(108, 29)
        Me.LabelKehadiran.TabIndex = 2
        Me.LabelKehadiran.Text = "LAPORAN"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.Location = New System.Drawing.Point(12, 79)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(127, 23)
        Me.LabelNama.TabIndex = 3
        Me.LabelNama.Text = "Total undangan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hadir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tidak Hadir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(441, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Sumbangan"
        '
        'TextBoxTotalUndangan
        '
        Me.TextBoxTotalUndangan.Enabled = False
        Me.TextBoxTotalUndangan.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotalUndangan.Location = New System.Drawing.Point(198, 79)
        Me.TextBoxTotalUndangan.Multiline = True
        Me.TextBoxTotalUndangan.Name = "TextBoxTotalUndangan"
        Me.TextBoxTotalUndangan.Size = New System.Drawing.Size(98, 23)
        Me.TextBoxTotalUndangan.TabIndex = 8
        '
        'TextBoxHadir
        '
        Me.TextBoxHadir.Enabled = False
        Me.TextBoxHadir.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHadir.Location = New System.Drawing.Point(198, 112)
        Me.TextBoxHadir.Multiline = True
        Me.TextBoxHadir.Name = "TextBoxHadir"
        Me.TextBoxHadir.Size = New System.Drawing.Size(98, 23)
        Me.TextBoxHadir.TabIndex = 9
        '
        'TextBoxTidakHdr
        '
        Me.TextBoxTidakHdr.Enabled = False
        Me.TextBoxTidakHdr.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTidakHdr.Location = New System.Drawing.Point(198, 149)
        Me.TextBoxTidakHdr.Multiline = True
        Me.TextBoxTidakHdr.Name = "TextBoxTidakHdr"
        Me.TextBoxTidakHdr.Size = New System.Drawing.Size(98, 23)
        Me.TextBoxTidakHdr.TabIndex = 10
        '
        'TextBoxTotSumbangan
        '
        Me.TextBoxTotSumbangan.Enabled = False
        Me.TextBoxTotSumbangan.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotSumbangan.Location = New System.Drawing.Point(612, 79)
        Me.TextBoxTotSumbangan.Multiline = True
        Me.TextBoxTotSumbangan.Name = "TextBoxTotSumbangan"
        Me.TextBoxTotSumbangan.Size = New System.Drawing.Size(98, 23)
        Me.TextBoxTotSumbangan.TabIndex = 11
        '
        'FLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxTotSumbangan)
        Me.Controls.Add(Me.TextBoxTidakHdr)
        Me.Controls.Add(Me.TextBoxHadir)
        Me.Controls.Add(Me.TextBoxTotalUndangan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.LabelKehadiran)
        Me.Controls.Add(Me.ChartKehadiran)
        Me.Name = "FLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ChartKehadiran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChartKehadiran As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents LabelKehadiran As System.Windows.Forms.Label
    Friend WithEvents LabelNama As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotalUndangan As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHadir As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTidakHdr As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotSumbangan As System.Windows.Forms.TextBox
End Class
