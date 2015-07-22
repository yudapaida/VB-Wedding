Public Class FMultiBarcode
    Dim cnn As New OleDb.OleDbConnection
    Dim FontEncoder As New IDAutomation.NetAssembly.FontEncoder

    Dim nama(,) As String
    Dim dt As New DataTable


    ' <---- generate barcode 
    Private Function SetEncodedBarcode(ByVal pstrInpBarcode As String)
        Dim strEncodedBarcode As String = ""
        strEncodedBarcode = FontEncoder.Code39(pstrInpBarcode)
        Return strEncodedBarcode
    End Function
    ' end generate barcode ---->

    Private Sub FMultiBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\wedding.mdb"

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM T_Guest", cnn)
        'Dim dt As New DataTable
        'Dim nama(,) As String

        cnn.Open()
        da.Fill(dt) 'fill to the data table
        cnn.Close()
        Me.dgvData.DataSource = dt 'fill data grid view with datatable


        ReDim nama(dt.Rows.Count - 1, dt.Columns.Count - 1)
        'fill array with database record
        For j As Integer = 0 To dt.Rows.Count - 1

            For i As Integer = 0 To dt.Columns.Count - 1

                nama(j, i) = dt.Rows(j).Item(i).ToString

            Next

        Next

        'Label1.Text = nama(0, 1)

    End Sub

    Private Sub ButtonCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCetak.Click
        'generate multiple barcode
        Dim x As Integer = 10

        If dt.Rows.Count - 1 = 0 Then 'check for empty data
            MsgBox("No data to print !")
        Else
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim labelnama As New Label
                labelnama.Name = "Label" & i
                labelnama.Size = New Size(200, 98)
                labelnama.Location = New Point(x, 100)
                labelnama.Text = SetEncodedBarcode(nama(i, 1))
                labelnama.Font = New System.Drawing.Font("IDAutomationHC39M", 18, FontStyle.Regular)
                Me.Controls.Add(labelnama)
                x = x + 100

                'set posistion printing
                '
                '
                '
                'end
            Next
        End If
       
    End Sub
End Class