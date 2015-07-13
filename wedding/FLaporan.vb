Imports System.Windows.Forms.DataVisualization.Charting

Public Class FLaporan
    Dim cnn As New OleDb.OleDbConnection

    Private Sub FLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\wedding.mdb"

        Dim cmd As New OleDb.OleDbCommand("SELECT * FROM T_Guest", cnn)
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM T_Guest", cnn)
        Dim ds As New DataSet
        Dim dt As New DataTable

        cnn.Open()
        da.Fill(dt) 'fill to the data table
        cnn.Close()

        Dim total_hadir As Integer = dt.Compute("COUNT(status)", "status='Hadir'")
        Dim total_tidakhadir As Integer = dt.Compute("COUNT(status)", "status='Tidak Hadir'")
        Dim total_undangan As Integer = dt.Compute("COUNT(id)", "")
        Dim total_sumbangan As Integer = dt.Compute("SUM(sumbangan)", "")
        'MsgBox(total_tidakhadir.ToString)

        'fill form 
        TextBoxHadir.Text = total_hadir.ToString
        TextBoxTidakHdr.Text = total_tidakhadir.ToString
        TextBoxTotalUndangan.Text = total_undangan.ToString
        TextBoxTotSumbangan.Text = total_sumbangan.ToString

        'create chart
        With ChartKehadiran '=Nama Group
            .Series.Clear()
            .Series.Add("Kehadiran")

            'Format Series/Chart

            .ChartAreas(0).AxisX.Interval = 1

            .ChartAreas(0).AxisX.IsStartedFromZero = True
            .Series(0).ChartType = SeriesChartType.Column 'Bentuk chart
            .Series(0).XValueType = ChartValueType.String
            .Series(0).YValueType = ChartValueType.Double
            'Isi Nilai Series/Chart (X,Y)
            .Series(0).Points.AddXY("Hadir", total_hadir)
            .Series(0).Points.AddXY("Tidak Hadir", total_tidakhadir)
        End With
    End Sub
End Class