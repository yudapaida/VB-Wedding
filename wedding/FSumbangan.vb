Public Class FSumbangan
    Dim cnn As New OleDb.OleDbConnection

    Private Sub UpdateKehadiran()
        'open connection
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        'update data
        Dim cmd As New OleDb.OleDbCommand("UPDATE T_Guest SET sumbangan='" & TextBoxNominal.Text & "'  WHERE nama='" & LabelNama.Text & "'", cnn)

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
End Class