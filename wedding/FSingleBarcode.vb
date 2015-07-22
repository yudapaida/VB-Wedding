Public Class FSingleBarcode
    Dim FontEncoder As New IDAutomation.NetAssembly.FontEncoder
    Dim cnn As New OleDb.OleDbConnection

    Private Sub FSingleBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'databases
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\wedding.mdb"
        '
        Me.RefreshData()

        'disable print button
        BtnPrint.Enabled = False
        'disable textbox nama
        TBInputBarcode.Enabled = False

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

        'resize data table to fit data grid view
        'Me.dgvData.AutoResizeColumn(DataGridViewAutoSizeColumnMode.AllCellsExceptHeader)

        'close connection
        cnn.Close()
    End Sub

    ' <---- generate barcode 
    Private Function SetEncodedBarcode(ByVal pstrInpBarcode As String)
        Dim strEncodedBarcode As String = ""
        strEncodedBarcode = FontEncoder.Code39(pstrInpBarcode)
        Return strEncodedBarcode
    End Function

    Private Sub SetBarcode(ByVal pobjBarcode As Label)
        pobjBarcode.Text = SetEncodedBarcode(TBInputBarcode.Text)
        pobjBarcode.Font = New System.Drawing.Font("IDAutomationHC39M", 18, FontStyle.Regular)
    End Sub
    ' end generate barcode ---->

    ' set printing
    Private Sub printDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc.PrintPage

        'Dim strLabelBarcode As String = "Barcode :"


        '--BARCODE
        'e.Graphics.DrawString(strLabelBarcode, LabelFont.Font, Brushes.Black, 10, 60)
        e.Graphics.DrawString(LabelBarcode.Text, LabelBarcode.Font, Brushes.Black, 90, 60)

    End Sub

    Private Sub BtnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerate.Click
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

                'Me.TextBoxId.Text = intStdID
                Me.TBInputBarcode.Text = dt.Rows(0).Item("nama")
                'Me.TextBoxAlamat.Text = dt.Rows(0).Item("alamat")
                'Me.ComboBoxGender.Text = dt.Rows(0).Item("jenis_kelamin")
                'Me.ComboBoxStatus.Text = dt.Rows(0).Item("status")
                'Me.TextBoxSumbangan.Text = dt.Rows(0).Item("sumbangan")                '
                
                cnn.Close()
            End If
        End If

        SetBarcode(LabelBarcode)
        BtnPrint.Enabled = True
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        printDoc.PrinterSettings.Copies = 1
        printDoc.Print()

        TBInputBarcode.Text = ""
    End Sub

    Private Sub LabelBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelBarcode.Click

    End Sub
End Class