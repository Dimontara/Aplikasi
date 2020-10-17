Public Class FrmData
    Private NoUrutMenu As Integer
    Public Sub ShowMenu(ByVal NamaMenu As String, ByVal NoMenu As Integer)
        DgPenjualan.DefaultCellStyle.SelectionBackColor = Color.Gray
        'DgPenjualan.DefaultCellStyle.SelectionForeColor = Color.Gray
        FrmMenuUtama.IsMdiContainer = True
        FrmMenuUtama.picdekstop.Visible = False
        MdiParent = FrmMenuUtama
        Dock = DockStyle.Fill
        If FrmMenuUtama.sudah = False Then
            Me.Show()
            'FrmMenuUtama.sudah = True
        End If
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
        If NoUrutMenu = 1 Then
            CreateColomOperator(DgPenjualan)
            ComboOperator(CbFilter)
            If Service.SqlDaAdapter("select * From tbloperator", "operator") = True Then
                AddRowDataOperator("operator", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 2 Then
            CreateColomProdi(DgPenjualan)
            ComboProdi(CbFilter)
            If Service.SqlDaAdapter("select * From tblProdi", "prodi") = True Then
                AddRowDataProdi("prodi", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 3 Then
            CreateColomDosen(DgPenjualan)
            ComboDosen(CbFilter)
            If Service.SqlDaAdapter("select tblDosen.*, tblProdi.NamaProdi from tblDosen, tblProdi where tblDosen.kodeProdi = tblProdi.kodeProdi", "dosen") = True Then
                AddRowDataDosen("dosen", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 4 Then
            CreateColomMahasiswa(DgPenjualan)
            ComboMahasiswa(CbFilter)
            If Service.SqlDaAdapter("select tblMahasiswa.*, tblProdi.NamaProdi from tblMahasiswa, tblProdi where tblMahasiswa.kodeProdi = tblProdi.kodeProdi;", "mahasiswa") = True Then
                AddRowDataMahasiswa("mahasiswa", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 5 Then
            CreateColomTugasAkhir(DgPenjualan)
            ComboTugasAkhir(CbFilter)
            If Service.SqlDaAdapter("select * from vw_tugasakhir", "tugasAkhir") = True Then
                AddRowDataTugasAkhir("tugasAkhir", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 6 Then
            CreateColomNilaiTugasAkhir(DgPenjualan)
            ComboNilaiTugasAkhir(CbFilter)
            If Service.SqlDaAdapter("select * from vw_nilaitugasakhir", "NilaitugasAkhir") = True Then
                AddRowDataNilaiTugasAkhir("NilaitugasAkhir", DgPenjualan)
            End If
        End If
        gantiWarna()
    End Sub
    Sub Tambah()
        If NoUrutMenu = 1 Then
            FrmOperator.ShowMenu(True)
        ElseIf NoUrutMenu = 2 Then
            FrmProdi.ShowMenu(True)
        ElseIf NoUrutMenu = 3 Then
            FrmDosen.ShowMenu(True)
        ElseIf NoUrutMenu = 4 Then
            FrmMahasiswa.ShowMenu(True)
        ElseIf NoUrutMenu = 5 Then
            FrmTugasAkhir.ShowMenu(True)
        ElseIf NoUrutMenu = 6 Then
            FrmNilaiTugasAkhir.ShowMenu(True)
        End If
        Tampil()
    End Sub
    Sub Ubah()
        If DgPenjualan.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        If NoUrutMenu = 1 Then
            FrmOperator.CariDataUbah(DgPenjualan.CurrentRow.Tag, False)
        ElseIf NoUrutMenu = 2 Then
            FrmProdi.CariDataUbah(DgPenjualan.CurrentRow.Tag, False)
        ElseIf NoUrutMenu = 3 Then
            FrmDosen.CariDataUbah(DgPenjualan.CurrentRow.Tag, False)
        ElseIf NoUrutMenu = 4 Then
            FrmMahasiswa.CariDataUbah(DgPenjualan.CurrentRow.Tag, False)
        ElseIf NoUrutMenu = 5 Then
            FrmTugasAkhir.CariDataUbah(DgPenjualan.CurrentRow.Tag, False)
        ElseIf NoUrutMenu = 6 Then
            FrmNilaiTugasAkhir.CariDataUbah(DgPenjualan.CurrentRow.Tag, False)
        End If
        Tampil()
    End Sub
    Sub Hapus()
        If Konfirmasi("Hapus") = True Then
            Dim i = 0
            For i = 0 To DgPenjualan.SelectedRows.Count - 1
                If NoUrutMenu = 1 Then
                    Service.ExecuteNonQuery("Delete from TblOperator where IdUser='" & DgPenjualan.SelectedRows(i).Tag & "'", "tbloperator", "01")
                ElseIf NoUrutMenu = 2 Then
                    Service.ExecuteNonQuery("Delete from tblProdi where kodeProdi='" & DgPenjualan.SelectedRows(i).Tag & "'", "tblOperator", "02")
                ElseIf NoUrutMenu = 3 Then
                    Service.ExecuteNonQuery("Delete from tblDosen where nip='" & DgPenjualan.SelectedRows(i).Tag & "'", "tblDosen", "03")
                ElseIf NoUrutMenu = 4 Then
                    Service.ExecuteNonQuery("Delete from tblMahasiswa where nim = '" & DgPenjualan.SelectedRows(i).Tag & "'", "tblMahasiswa", "04")
                ElseIf NoUrutMenu = 5 Then
                    Service.ExecuteNonQuery("Delete from tblTugasAkhir2 where nim='" & DgPenjualan.SelectedRows(i).Tag & "'", "tblTugasAkhir", "05")
                ElseIf NoUrutMenu = 6 Then

                End If
            Next
            MsgBox(i & " baris berhasil di Hapus!", MsgBoxStyle.Information, "Pesan")
            Tampil()
        End If
    End Sub
    Sub Keluar()
        If formActiveName <> "" Then
            BtnTambah.Visible = True
            BtnUbah.Visible = True
            BtnHapus.Visible = True
            BtnRefresh.Visible = True
            PictureBox2.Visible = False
            FrmMenuUtama.MenuStrip1.Enabled = True
            Dim temp = formActiveName
            formActiveName = ""
            If temp = "FrmMahasiswa" Then
                If DgPenjualan.SelectedRows.Count > 0 Then
                    FrmMahasiswa.TxtKodeProdi.Text = DgPenjualan.SelectedRows(0).Cells(1).Value
                End If
                ShowMenu("Mahasiswa", 4)
                FrmMahasiswa.ShowDialog()
            ElseIf temp = "FrmDosen" Then
                If DgPenjualan.SelectedRows.Count > 0 Then
                    FrmDosen.TxtKodeProdi.Text = DgPenjualan.SelectedRows(0).Cells(1).Value
                End If
                ShowMenu("Dosen", 3)
                FrmDosen.ShowDialog()
            ElseIf temp = "FrmTugasAkhir1" Then
                If DgPenjualan.SelectedRows.Count > 0 Then
                    FrmTugasAkhir.TxtNimMahasiswa.Text = DgPenjualan.CurrentRow.Tag
                End If
                ShowMenu("Tugas Akhir", 5)
                FrmTugasAkhir.BtnSimpan.Tag = True
                FrmTugasAkhir.Visible = True
            ElseIf temp = "FrmTugasAkhir2" Then
                If DgPenjualan.SelectedRows.Count > 0 Then
                    FrmTugasAkhir.TxtNipDosen.Text = DgPenjualan.CurrentRow.Tag
                End If
                ShowMenu("Tugas Akhir", 5)
                FrmTugasAkhir.BtnSimpan.Tag = True
                FrmTugasAkhir.Visible = True
            ElseIf temp = "FrmNilaiTugasAkhir1" Then
                If DgPenjualan.SelectedRows.Count > 0 Then
                    FrmNilaiTugasAkhir.TxtNimMahasiswa.Text = DgPenjualan.CurrentRow.Tag
                End If
                ShowMenu("Nilai Tugas Akhir", 6)
                FrmNilaiTugasAkhir.BtnSimpan.Tag = True
                FrmNilaiTugasAkhir.Visible = True
            ElseIf temp = "FrmNilaiTugasAkhir2" Then
                If DgPenjualan.SelectedRows.Count > 0 Then
                    FrmNilaiTugasAkhir.TxtNipDosen.Text = DgPenjualan.CurrentRow.Tag
                End If
                ShowMenu("Nilai Tugas Akhir", 6)
                FrmNilaiTugasAkhir.BtnSimpan.Tag = True
                FrmNilaiTugasAkhir.Visible = True
            ElseIf temp = "FrmNilaiTugasAkhir3" Then
                If DgPenjualan.SelectedRows.Count > 0 Then
                    FrmNilaiTugasAkhir.TxtNipDosen1.Text = DgPenjualan.CurrentRow.Tag
                End If
                ShowMenu("Nilai Tugas Akhir", 6)
                FrmNilaiTugasAkhir.BtnSimpan.Tag = True
                FrmNilaiTugasAkhir.Visible = True
            ElseIf temp = "FrmNilaiTugasAkhir4" Then
                If DgPenjualan.SelectedRows.Count > 0 Then
                    FrmNilaiTugasAkhir.TxtNipDosen2.Text = DgPenjualan.CurrentRow.Tag
                End If
                ShowMenu("Nilai Tugas Akhir", 6)
                FrmNilaiTugasAkhir.BtnSimpan.Tag = True
                FrmNilaiTugasAkhir.Visible = True
            End If
        Else
            Me.Close()
            FrmMenuUtama.IsMdiContainer = False
            FrmMenuUtama.picdekstop.Visible = True
        End If
    End Sub

    Public Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Keluar()
    End Sub

    Private Sub Mouse_Hover(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.tag = 11 Then AnimasiTombol(BtnRefresh, 28, 28)
        If sender.tag = 5 Then AnimasiTombol(BtnTambah, 28, 28)
        If sender.tag = 4 Then AnimasiTombol(BtnUbah, 28, 28)
        If sender.tag = 3 Then AnimasiTombol(BtnHapus, 28, 28)
        If sender.tag = 2 Then AnimasiTombol(BtnCari, 20, 20)
        If sender.tag = 1 Then AnimasiTombol(BtnKeluar, 28, 28)
    End Sub
    Private Sub Mouse_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.tag = 11 Then AnimasiTombol(BtnRefresh, 24, 24)
        If sender.tag = 5 Then AnimasiTombol(BtnTambah, 24, 24)
        If sender.tag = 4 Then AnimasiTombol(BtnUbah, 24, 24)
        If sender.tag = 3 Then AnimasiTombol(BtnHapus, 24, 24)
        If sender.tag = 2 Then AnimasiTombol(BtnCari, 19, 19)
        If sender.tag = 1 Then AnimasiTombol(BtnKeluar, 24, 24)
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tambah()
    End Sub
    Private Sub FrmData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Keluar()
        If e.Control And e.KeyCode = Keys.T Then
            Tambah()
        End If
        If (e.Control And e.KeyCode = Keys.H) Or e.KeyCode = Keys.Delete Then
            Hapus()
        End If
        If e.Control And e.KeyCode = Keys.U Then
            Ubah()
        End If
        If e.Control And e.KeyCode = Keys.C Then
            CbFilter.Select()
        End If
        If e.KeyCode = Keys.F5 Then
            Refresh()
        End If
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ubah()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Hapus()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs)
        Tampil()
    End Sub

    Private Sub BtnCari_Click_1(sender As Object, e As EventArgs) Handles BtnCari.Click
        Dim Query As String = ""
        If NoUrutMenu = 1 Then
            If CbFilter.SelectedIndex = 0 Then
                Query = "select * From  tblOperator where nama like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            ElseIf CbFilter.SelectedIndex = 1 Then
                Query = "select * From tblOperator where username like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            End If
            If Service.SqlDaAdapter(Query, "operator") = True Then
                AddRowDataOperator("operator", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 2 Then
            If CbFilter.SelectedIndex = 0 Then
                Query = "select * From  tblProdi where namaprodi like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            ElseIf CbFilter.SelectedIndex = 1 Then
                Query = "select * From tblProdi where kodeprodi like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            End If
            If Service.SqlDaAdapter(Query, "prodi") = True Then
                AddRowDataProdi("prodi", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 3 Then
            If CbFilter.SelectedIndex = 0 Then
                Query = "select tblDosen.*, tblProdi.NamaProdi from tblDosen, tblProdi where tblDosen.kodeProdi = tblProdi.kodeProdi and nama like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            ElseIf CbFilter.SelectedIndex = 1 Then
                Query = "select tblDosen.*, tblProdi.NamaProdi from tblDosen, tblProdi where tblDosen.kodeProdi = tblProdi.kodeProdi and nip like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            ElseIf CbFilter.SelectedIndex = 2 Then
                Query = "select tblDosen.*, tblProdi.NamaProdi from tblDosen, tblProdi where tblDosen.kodeProdi = tblProdi.kodeProdi and email like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            End If
            If Service.SqlDaAdapter(Query, "dosen") = True Then
                AddRowDataDosen("dosen", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 4 Then
            If CbFilter.SelectedIndex = 0 Then
                Query = "select tblMahasiswa.*, tblProdi.NamaProdi from tblMahasiswa, tblProdi where tblMahasiswa.kodeProdi = tblProdi.kodeProdi and nama like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            ElseIf CbFilter.SelectedIndex = 1 Then
                Query = "select tblMahasiswa.*, tblProdi.NamaProdi from tblMahasiswa, tblProdi where tblMahasiswa.kodeProdi = tblProdi.kodeProdi and nim like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            ElseIf CbFilter.SelectedIndex = 2 Then
                Query = "select tblMahasiswa.*, tblProdi.NamaProdi from tblMahasiswa, tblProdi where tblMahasiswa.kodeProdi = tblProdi.kodeProdi and email like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            End If
            If Service.SqlDaAdapter(Query, "mahasiswa") = True Then
                AddRowDataMahasiswa("mahasiswa", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 5 Then
            If CbFilter.SelectedIndex = 0 Then
                Query = "select * from vw_tugasakhir where judul like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            ElseIf CbFilter.SelectedIndex = 1 Then
                Query = "select * from vw_tugasakhir where namaMahasiswa like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            ElseIf CbFilter.SelectedIndex = 2 Then
                Query = "select * from vw_tugasakhir where namaDosen like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            End If
            If Service.SqlDaAdapter(Query, "tugasakhir") = True Then
                AddRowDataTugasAkhir("tugasakhir", DgPenjualan)
            End If
        ElseIf NoUrutMenu = 6 Then
            If CbFilter.SelectedIndex = 0 Then
                Query = "select * from vw_nilaitugasakhir where judul like '%" & Replace(TxtPencarian.Text, "'", "''") & "%'"
            End If
            If Service.SqlDaAdapter(Query, "nilaitugasakhir") = True Then
                AddRowDataNilaiTugasAkhir("nilaitugasakhir", DgPenjualan)
            End If
        End If
        gantiWarna()
    End Sub

    Private Sub BtnTambah_Click_1(sender As Object, e As EventArgs)
        Tambah()
    End Sub

    Private Sub BtnUbah_Click_1(sender As Object, e As EventArgs)
        Ubah()
    End Sub

    Private Sub BtnHapus_Click_1(sender As Object, e As EventArgs)
        Hapus()
    End Sub

    Private Sub BtnRefresh_Click_1(sender As Object, e As EventArgs)
        Tampil()
    End Sub

    Private Sub FrmData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPencarian.KeyDown
        If e.KeyCode = Keys.Enter Then
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Keluar()
    End Sub

    Private Sub BtnTambah_Click_2(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Tambah()
    End Sub

    Private Sub BtnUbah_Click_2(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Ubah()
    End Sub

    Private Sub BtnHapus_Click_2(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Hapus()
    End Sub

    Private Sub BtnRefresh_Click_2(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Tampil()
    End Sub

    Private Sub BtnKeluar_Click_1(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Keluar()
    End Sub
End Class