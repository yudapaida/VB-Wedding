<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSumbangan
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
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.LabelNominal = New System.Windows.Forms.Label()
        Me.TextBoxNominal = New System.Windows.Forms.TextBox()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEnter.Location = New System.Drawing.Point(391, 283)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(81, 32)
        Me.ButtonEnter.TabIndex = 7
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNama.Enabled = False
        Me.TextBoxNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNama.Location = New System.Drawing.Point(228, 155)
        Me.TextBoxNama.Multiline = True
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(244, 32)
        Me.TextBoxNama.TabIndex = 6
        '
        'LabelNominal
        '
        Me.LabelNominal.AutoSize = True
        Me.LabelNominal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNominal.Location = New System.Drawing.Point(224, 202)
        Me.LabelNominal.Name = "LabelNominal"
        Me.LabelNominal.Size = New System.Drawing.Size(83, 23)
        Me.LabelNominal.TabIndex = 8
        Me.LabelNominal.Text = "Nominal :"
        '
        'TextBoxNominal
        '
        Me.TextBoxNominal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNominal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNominal.Location = New System.Drawing.Point(228, 228)
        Me.TextBoxNominal.Multiline = True
        Me.TextBoxNominal.Name = "TextBoxNominal"
        Me.TextBoxNominal.Size = New System.Drawing.Size(244, 32)
        Me.TextBoxNominal.TabIndex = 9
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.Location = New System.Drawing.Point(224, 129)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(84, 23)
        Me.LabelNama.TabIndex = 10
        Me.LabelNama.Text = "Nama      :"
        '
        'FSumbangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.TextBoxNominal)
        Me.Controls.Add(Me.LabelNominal)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Name = "FSumbangan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonEnter As System.Windows.Forms.Button
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents LabelNominal As System.Windows.Forms.Label
    Friend WithEvents TextBoxNominal As System.Windows.Forms.TextBox
    Friend WithEvents LabelNama As System.Windows.Forms.Label
End Class
