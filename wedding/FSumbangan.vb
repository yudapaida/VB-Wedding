Public Class FSumbangan
    Dim cnn As New OleDb.OleDbConnection

    Private Sub UpdateSumbangan()
        'open connection
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        'update data
        Dim cmd As New OleDb.OleDbCommand("UPDATE T_Guest SET sumbangan='" & TextBoxNominal.Text & "'  WHERE nama='" & TextBoxNama.Text & "'", cnn)

        'cmd.Connection = cnn
        'cmd.CommandText = "UPDATE T_Guest SET status='Hadir' WHERE id='1'"
        cmd.ExecuteNonQuery()

        'close connection
        cnn.Close()
    End Sub

    Private Sub FSumbangan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load database connection
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\wedding.mdb"
        '
    End Sub

    
    Private Sub ButtonEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnter.Click
        ' for check the empty form
        Dim emptyTextBoxes =
                            From txt In Me.Controls.OfType(Of TextBox)()
                            Where txt.Text.Length = 0
                            Select txt.Name

        If emptyTextBoxes.Any Then
            MsgBox("Please fill in all boxes !")
        Else
            UpdateSumbangan()
        End If

        TextBoxNama.Text = ""
        TextBoxNominal.Text = ""
    End Sub
End Class