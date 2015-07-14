<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FData
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
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.LabelAlamat = New System.Windows.Forms.Label()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelSumbangan = New System.Windows.Forms.Label()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.TextBoxSumbangan = New System.Windows.Forms.TextBox()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(12, 234)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.RowHeadersWidth = 50
        Me.dgvData.Size = New System.Drawing.Size(717, 163)
        Me.dgvData.TabIndex = 0
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.Location = New System.Drawing.Point(20, 63)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(55, 23)
        Me.LabelNama.TabIndex = 1
        Me.LabelNama.Text = "Nama"
        '
        'LabelAlamat
        '
        Me.LabelAlamat.AutoSize = True
        Me.LabelAlamat.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlamat.Location = New System.Drawing.Point(20, 99)
        Me.LabelAlamat.Name = "LabelAlamat"
        Me.LabelAlamat.Size = New System.Drawing.Size(64, 23)
        Me.LabelAlamat.TabIndex = 2
        Me.LabelAlamat.Text = "Alamat"
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.Location = New System.Drawing.Point(20, 134)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(67, 23)
        Me.LabelGender.TabIndex = 3
        Me.LabelGender.Text = "Gender"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.Location = New System.Drawing.Point(20, 167)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(58, 23)
        Me.LabelStatus.TabIndex = 4
        Me.LabelStatus.Text = "Status"
        '
        'LabelSumbangan
        '
        Me.LabelSumbangan.AutoSize = True
        Me.LabelSumbangan.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSumbangan.Location = New System.Drawing.Point(20, 199)
        Me.LabelSumbangan.Name = "LabelSumbangan"
        Me.LabelSumbangan.Size = New System.Drawing.Size(101, 23)
        Me.LabelSumbangan.TabIndex = 5
        Me.LabelSumbangan.Text = "Sumbangan"
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelId.Location = New System.Drawing.Point(20, 30)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(26, 23)
        Me.LabelId.TabIndex = 6
        Me.LabelId.Text = "Id"
        '
        'TextBoxId
        '
        Me.TextBoxId.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxId.Location = New System.Drawing.Point(180, 34)
        Me.TextBoxId.Multiline = True
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(90, 23)
        Me.TextBoxId.TabIndex = 7
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNama.Location = New System.Drawing.Point(180, 67)
        Me.TextBoxNama.Multiline = True
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(205, 23)
        Me.TextBoxNama.TabIndex = 8
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAlamat.Location = New System.Drawing.Point(180, 103)
        Me.TextBoxAlamat.Multiline = True
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(205, 23)
        Me.TextBoxAlamat.TabIndex = 9
        '
        'TextBoxSumbangan
        '
        Me.TextBoxSumbangan.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSumbangan.Location = New System.Drawing.Point(180, 203)
        Me.TextBoxSumbangan.Multiline = True
        Me.TextBoxSumbangan.Name = "TextBoxSumbangan"
        Me.TextBoxSumbangan.Size = New System.Drawing.Size(205, 23)
        Me.TextBoxSumbangan.TabIndex = 10
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(180, 138)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(123, 21)
        Me.ComboBoxGender.TabIndex = 11
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Items.AddRange(New Object() {"Hadir", "Tidak Hadir"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(180, 171)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(123, 21)
        Me.ComboBoxStatus.TabIndex = 12
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(565, 23)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(94, 34)
        Me.ButtonAdd.TabIndex = 13
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(565, 67)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(94, 34)
        Me.ButtonEdit.TabIndex = 14
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(565, 113)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(94, 34)
        Me.ButtonDelete.TabIndex = 15
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(565, 163)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(94, 34)
        Me.ButtonClear.TabIndex = 16
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'FData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ComboBoxStatus)
        Me.Controls.Add(Me.ComboBoxGender)
        Me.Controls.Add(Me.TextBoxSumbangan)
        Me.Controls.Add(Me.TextBoxAlamat)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.LabelSumbangan)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.LabelAlamat)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "FData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents LabelNama As System.Windows.Forms.Label
    Friend WithEvents LabelAlamat As System.Windows.Forms.Label
    Friend WithEvents LabelGender As System.Windows.Forms.Label
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents LabelSumbangan As System.Windows.Forms.Label
    Friend WithEvents LabelId As System.Windows.Forms.Label
    Friend WithEvents TextBoxId As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSumbangan As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxGender As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
End Class
