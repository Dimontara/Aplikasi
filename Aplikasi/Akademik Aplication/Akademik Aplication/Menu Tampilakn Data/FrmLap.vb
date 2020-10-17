Public Class FrmLap
    Private NoUrutMenu As Integer

    Public Sub ShowMenu(ByVal NamaMenu As String, ByVal NoMenu As Integer)
        DgPenjualan.DefaultCellStyle.SelectionBackColor = Color.Gray
        FrmMenuUtama.IsMdiContainer = True
        FrmMenuUtama.picdekstop.Visible = False
        MdiParent = FrmMenuUtama
        Dock = DockStyle.Fill
        Show()
        LblData.Text = NamaMenu
        NoUrutMenu = NoMenu
        Tampil()
    End Sub

    Sub gantiWarna()
        For Each row As DataGridViewRow In DgPenjualan.Rows
            row.DefaultCellStyle.BackColor = Color.White
        Next
    End Sub

    Sub Tampil()
        If NoUrutMenu = 7 Then
            CreateColomLapDosen(DgPenjualan)
            If Service.SqlDaAdapter("select * From tbldosen", "dosen") = True Then
                AddRowLapDosen("dosen", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 8 Then
            CreateColomLapMahasiswa(DgPenjualan)
            If Service.SqlDaAdapter("select vw_nilaitugasAkhir.tanggalsidang, tblMahasiswa.* from tblMahasiswa left join vw_nilaitugasAkhir on tblMahasiswa.nim = vw_nilaitugasAkhir.nim where '" & TanggalAwal.Text & "' >= tahunmasuk and vw_nilaitugasAkhir.tanggalsidang is null", "mhs") = True Then
                AddRowDataLapMahasiswa("mhs", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 9 Then
            CreateColomLapTA(DgPenjualan)
            If Service.SqlDaAdapter("select * from vw_nilaitugasakhir", "lapta") = True Then
                AddRowDataLapTA("lapta", DgPenjualan)
            End If
        End If
        gantiWarna()
    End Sub
    Sub Keluar()
        Me.Close()
        FrmMenuUtama.IsMdiContainer = False
        FrmMenuUtama.picdekstop.Visible = True
    End Sub
    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Keluar()
    End Sub
    Private Sub Mouse_Hover(ByVal sender As Object, ByVal e As System.EventArgs)
        'If sender.tag = 11 Then AnimasiTombol(BtnRefresh, 28, 28)
        'If sender.tag = 5 Then AnimasiTombol(BtnTambah, 28, 28)
        'If sender.tag = 4 Then AnimasiTombol(BtnUbah, 28, 28)
        'If sender.tag = 3 Then AnimasiTombol(BtnHapus, 28, 28)
        'If sender.tag = 2 Then AnimasiTombol(BtnCari, 20, 20)
        'If sender.tag = 1 Then AnimasiTombol(BtnKeluar, 28, 28)
    End Sub
    Private Sub Mouse_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        'If sender.tag = 11 Then AnimasiTombol(BtnRefresh, 24, 24)
        'If sender.tag = 5 Then AnimasiTombol(BtnTambah, 24, 24)
        'If sender.tag = 4 Then AnimasiTombol(BtnUbah, 24, 24)
        'If sender.tag = 3 Then AnimasiTombol(BtnHapus, 24, 24)
        'If sender.tag = 2 Then AnimasiTombol(BtnCari, 19, 19)
        'If sender.tag = 1 Then AnimasiTombol(BtnKeluar, 24, 24)
    End Sub
    Private Sub FrmData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Keluar()
    End Sub



    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tampil()
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Tampil()
    End Sub

    Private Sub BtnRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tampil()
    End Sub

    Private Sub BtnKeluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Keluar()
    End Sub

    Private Sub BtnCari_Click_1(sender As Object, e As EventArgs) Handles BtnCari.Click
        Dim Query As String = ""
        If NoUrutMenu = 9 Then
            Query = "select * from vw_nilaitugasakhir where left(tanggalsidang,4) = '" & TanggalAwal.Text & "'"
            If Service.SqlDaAdapter(Query, "ta") = True Then
                AddRowDataLapTA("ta", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 8 Then
            Query = "select vw_nilaitugasAkhir.tanggalsidang, tblMahasiswa.* from tblMahasiswa left join vw_nilaitugasAkhir on tblMahasiswa.nim = vw_nilaitugasAkhir.nim where '" & TanggalAwal.Text & "' >= tahunmasuk and vw_nilaitugasAkhir.tanggalsidang is null"
            If Service.SqlDaAdapter(Query, "mhs") = True Then
                AddRowDataLapMahasiswa("mhs", DgPenjualan)
            End If
        End If
        gantiWarna()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If NoUrutMenu = 7 Then
            PrintDosen.ShowDialog()
        ElseIf NoUrutMenu = 8 Then
            PrintMahasiswa.ShowDialog()
        ElseIf NoUrutMenu = 9 Then
            PrintTugasAkhir.ShowDialog()
        End If
    End Sub

    Private Sub DgPenjualan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgPenjualan.CellContentClick

    End Sub
End Class