Public Class MainForm

   
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub KEDATANGANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KEDATANGANToolStripMenuItem.Click
        IsMdiContainer = True
        FKedatangan.MdiParent = Me
        GroupBox1.Visible = False
        FKedatangan.Show()

        FSumbangan.Close()
        'FKedatangan.Close()
        FSingleBarcode.Close()
        FMultiBarcode.Close()
        FLaporan.Close()
        FData.Close()

    End Sub

    Private Sub SUMBANGANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUMBANGANToolStripMenuItem.Click
        IsMdiContainer = True
        FSumbangan.MdiParent = Me
        GroupBox1.Visible = False
        FSumbangan.Show()

        'FSumbangan.Close()
        FKedatangan.Close()
        FSingleBarcode.Close()
        FMultiBarcode.Close()
        FLaporan.Close()
        FData.Close()
    End Sub

    Private Sub SINGLEBARCODEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SINGLEBARCODEToolStripMenuItem.Click
        IsMdiContainer = True
        FSingleBarcode.MdiParent = Me
        GroupBox1.Visible = False
        FSingleBarcode.Show()

        FSumbangan.Close()
        FKedatangan.Close()
        'FSingleBarcode.Close()
        FMultiBarcode.Close()
        FLaporan.Close()
        FData.Close()
    End Sub

    Private Sub MULTIBARCODEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MULTIBARCODEToolStripMenuItem.Click
        IsMdiContainer = True
        FMultiBarcode.MdiParent = Me
        GroupBox1.Visible = False
        FMultiBarcode.Show()

        FSumbangan.Close()
        FKedatangan.Close()
        FSingleBarcode.Close()
        'FMultiBarcode.Close()
        FLaporan.Close()
        FData.Close()
    End Sub

    Private Sub DATAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAToolStripMenuItem.Click
        IsMdiContainer = True
        FData.MdiParent = Me
        GroupBox1.Visible = False
        FData.Show()

        FSumbangan.Close()
        FKedatangan.Close()
        FSingleBarcode.Close()
        FMultiBarcode.Close()
        FLaporan.Close()
        'FData.Close()
    End Sub

    Private Sub LAPORANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAPORANToolStripMenuItem.Click
        IsMdiContainer = True
        FLaporan.MdiParent = Me
        GroupBox1.Visible = False
        FLaporan.Show()

        FSumbangan.Close()
        FKedatangan.Close()
        FSingleBarcode.Close()
        FMultiBarcode.Close()
        'FLaporan.Close()
        FData.Close()
    End Sub
End Class
