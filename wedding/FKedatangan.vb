Public Class FKedatangan
    Dim cnn As New OleDb.OleDbConnection

    Private Sub UpdateKehadiran()
        'open connection
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        Dim status As String = "Hadir"
        'update data
        Dim cmd As New OleDb.OleDbCommand("UPDATE T_Guest SET status='" & status & "'  WHERE nama='" & TextBoxScanBarcode.Text.Trim & "'", cnn)
        
        'cmd.Connection = cnn
        'cmd.CommandText = "UPDATE T_Guest SET status='Hadir' WHERE id='1'"
        cmd.ExecuteNonQuery()
        
        'close connection
        cnn.Close()
    End Sub

    Private Sub FKedatangan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load database connection
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\wedding.mdb"
        '
    End Sub

    Private Sub ButtonEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnter.Click
        UpdateKehadiran()
        'Greeting text
        LabelGreeting.Text = "Selamat Datang " & TextBoxScanBarcode.Text
        TextBoxScanBarcode.Text = ""
    End Sub
End Class