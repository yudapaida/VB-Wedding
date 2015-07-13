Public Class FData
    Dim cnn As New OleDb.OleDbConnection

    Private Sub FData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\wedding.mdb"
        '

        Me.RefreshData()
    End Sub

    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT id, nama, alamat, jenis_kelamin, status, sumbangan FROM T_Guest ORDER BY id DESC", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.dgvData.DataSource = dt

        'close connection
        cnn.Close()
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        Me.TextBoxId.Text = ""
        Me.TextBoxNama.Text = ""
        Me.TextBoxAlamat.Text = ""
        Me.TextBoxSumbangan.Text = ""
        'Me.ComboBoxGender.Text = ""
        'Me.ComboBoxStatus.Text = ""
        ' enable button edit
        Me.ButtonEdit.Enabled = True
        ' set button add to add label
        Me.ButtonAdd.Text = "Add"
        '
        Me.TextBoxId.Focus()
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        ' for check the empty form
        Dim emptyTextBoxes =
                            From txt In Me.Controls.OfType(Of TextBox)()
                            Where txt.Text.Length = 0
                            Select txt.Name

        Dim cmd As New OleDb.OleDbCommand
        If Not cnn.State = ConnectionState.Open Then
            'open connection if it is not yet open
            cnn.Open()
        End If

        cmd.Connection = cnn
        ' check for empty form
        If emptyTextBoxes.Any Then
            ' MsgBox(String.Format("Please fill following textboxes: {0}", String.Join(",", emptyTextBoxes)))
            MsgBox("Please fill in all boxes !")
        Else
            'check whether add new or update
            If Me.TextBoxId.Tag & "" = "" Then
                'add new 
                'add data to table
                cmd.CommandText = "INSERT INTO T_Guest(id,nama,alamat,jenis_kelamin,status,sumbangan) " & _
                                  "VALUES(" & Me.TextBoxId.Text & ",'" & Me.TextBoxNama.Text & "','" & Me.TextBoxAlamat.Text & "','" & _
                                            Me.ComboBoxGender.Text & "','" & Me.ComboBoxStatus.Text & "','" & Me.TextBoxSumbangan.Text & "')"
                cmd.ExecuteNonQuery()
            Else
                'update data in table
                cmd.CommandText = "UPDATE T_Guest " & _
                                  " SET id=" & Me.TextBoxId.Text & _
                                  ", nama='" & Me.TextBoxNama.Text & "'" & _
                                  ", alamat='" & Me.TextBoxAlamat.Text & "'" & _
                                  ", jenis_kelamin='" & Me.ComboBoxGender.Text & "'" & _
                                  ", status='" & Me.ComboBoxStatus.Text & "'" & _
                                  ", sumbangan='" & Me.TextBoxSumbangan.Text & "'" & _
                                  " WHERE id=" & Me.TextBoxId.Tag
                cmd.ExecuteNonQuery()
            End If
        End If
        'refresh data in list
        RefreshData()
        'clear form
        Me.ButtonClear.PerformClick()

        'close connection
        cnn.Close()
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        'check for the selected item in list
        If Me.dgvData.Rows.Count > 0 Then
            If Me.dgvData.SelectedRows.Count > 0 Then
                Dim intStdID As Integer = Me.dgvData.SelectedRows(0).Cells("id").Value
                'get data from database followed by student id
                'open connection
                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If
                'get data into datatable
                Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM T_Guest " & _
                                                     " WHERE id=" & intStdID, cnn)
                Dim dt As New DataTable
                da.Fill(dt)

                Me.TextBoxId.Text = intStdID
                Me.TextBoxNama.Text = dt.Rows(0).Item("nama")
                Me.TextBoxAlamat.Text = dt.Rows(0).Item("alamat")
                Me.ComboBoxGender.Text = dt.Rows(0).Item("jenis_kelamin")
                Me.ComboBoxStatus.Text = dt.Rows(0).Item("status")
                Me.TextBoxSumbangan.Text = dt.Rows(0).Item("sumbangan")
                '
                'hide the id to be edited in TAG of txtstdid in case id is changed
                Me.TextBoxId.Tag = intStdID
                'change button add to update
                Me.ButtonAdd.Text = "Update"
                'disable button edit
                Me.ButtonEdit.Enabled = False
                'close connection
                cnn.Close()
            End If
        End If
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        'check for the selected item in list
        If Me.dgvData.Rows.Count > 0 Then
            If Me.dgvData.SelectedRows.Count > 0 Then
                Dim intStdID As Integer = Me.dgvData.SelectedRows(0).Cells("id").Value
                'open connection
                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If

                'delete data
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cnn
                cmd.CommandText = "DELETE FROM T_Guest WHERE id=" & intStdID
                cmd.ExecuteNonQuery()
                'refresh data
                Me.RefreshData()

                'close connection
                cnn.Close()
            End If
        End If
    End Sub
End Class