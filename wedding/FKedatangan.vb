Imports System.Drawing.Printing

Public Class FKedatangan
    Dim cnn As New OleDb.OleDbConnection
    Dim FontEncoder As New IDAutomation.NetAssembly.FontEncoder
    Private WithEvents printDoc As PrintDocument

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

    ' <---- generate barcode 
    Private Function SetEncodedBarcode(ByVal pstrInpBarcode As String)
        Dim strEncodedBarcode As String = ""
        strEncodedBarcode = FontEncoder.Code39(pstrInpBarcode)
        Return strEncodedBarcode
    End Function

    Private Sub SetBarcode(ByVal pobjBarcode As Label)
        pobjBarcode.Text = SetEncodedBarcode(TextBoxScanBarcode.Text)
        pobjBarcode.Font = New System.Drawing.Font("IDAutomationHC39M", 18, FontStyle.Regular)
    End Sub
    ' end generate barcode ---->

    Private Sub printDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDoc.PrintPage

        'Dim strLabelBarcode As String = "Barcode :"

        '--BARCODE
        'e.Graphics.DrawString(strLabelBarcode, LabelFont.Font, Brushes.Black, 10, 60)
        e.Graphics.DrawString(LabelBarcode.Text, LabelBarcode.Font, Brushes.Black, 90, 60)

    End Sub

    Private Sub FKedatangan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            'update status to 'hadir'
            UpdateKehadiran()

            'generate barcode
            SetBarcode(LabelBarcode)

            'printing 
            printDoc.PrinterSettings.Copies = 1
            printDoc.Print()

            'Greeting text
            LabelGreeting.Text = "Selamat Datang " & TextBoxScanBarcode.Text
            'TextBoxScanBarcode.Text = ""
        End If

    End Sub
End Class