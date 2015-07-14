Public Class FMultiBarcode
    Dim cnn As New OleDb.OleDbConnection
    Dim FontEncoder As New IDAutomation.NetAssembly.FontEncoder

    Private Sub FMultiBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\wedding.mdb"

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM T_Guest", cnn)
        Dim dt As New DataTable

        Dim nama(,) As String

        cnn.Open()
        da.Fill(dt) 'fill to the data table
        cnn.Close()

        'fill data grid view with datatable
        Me.dgvData.DataSource = dt


        ReDim nama(dt.Rows.Count - 1, dt.Columns.Count - 1)
        'fill array with database record
        For j As Integer = 0 To dt.Rows.Count - 1

            For i As Integer = 0 To dt.Columns.Count - 1

                nama(j, i) = dt.Rows(j).Item(i).ToString

            Next

        Next


        Label1.Text = nama(0, 1)
    End Sub

End Class