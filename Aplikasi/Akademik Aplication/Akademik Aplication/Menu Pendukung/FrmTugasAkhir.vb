Public Class FrmTugasAkhir
    Public Sub ShowMenu(ByVal Jenis As Boolean)
        Awal()
        Me.Text = "Pendaftaran Tugas Akhir"
        BtnSimpan.Tag = Jenis
        Me.ShowDialog()
    End Sub

    Sub Awal()
        TxtNamaMahasiswa.Enabled = True
        TxtNimMahasiswa.Enabled = True
    End Sub

    Sub ubah()
        If Service.ExecuteNonQuery("Update tblTugasAkhir2 set judul = '" & TxtJudul.Text & "', nipDoping = '" & TxtNipDosen.Text & "'  where nim ='" & TxtNimMahasiswa.Text & "'", "tblDosen", "") = True Then
            MsgBox("Data berhasil di Ubah!", MsgBoxStyle.Information, "pesan")
            Awal()
            Me.Close()
        End If
    End Sub

    Public Sub CariDataUbah(ByVal ID As String, ByVal Jenis As Boolean)
        Awal()
        TxtNamaMahasiswa.Enabled = False
        TxtNimMahasiswa.Enabled = False
        Service.SqlDaAdapter("select * from vw_tugasakhir where nim ='" & ID & "'", "Cari")
        Dim datatble As DataTable = Service.DTSet.Tables("Cari").Copy()
        TxtNimMahasiswa.Text = datatble.Rows(0)("nim")
        TxtNipDosen.Text = datatble.Rows(0)("nipDoping")
        TxtJudul.Text = datatble.Rows(0)("judul")
        Me.Text = "Ubah Data Tugas Akhir"
        BtnSimpan.Tag = Jenis
        Me.ShowDialog()
    End Sub

    Private Function salah() As Boolean
        For i As Integer = 0 To Me.TabControl1.Controls.Count - 1
            For j As Integer = 0 To Me.TabControl1.Controls(i).Controls.Count - 1
                If Me.TabControl1.Controls(i).Controls(j).GetType.Name = "TextBox" Then
                    If Me.TabControl1.Controls(i).Controls(j).Text = "" Then
                        Return True
                    End If
                End If
            Next
        Next
        If TxtJudul.Text = "" Then
            Return True
        End If
        If Not mahasiswa.Item(0).Contains(TxtNamaMahasiswa.Text) Or Not mahasiswa.Item(1).Contains(TxtNimMahasiswa.Text) Or Not dosen.Item(0).Contains(TxtNamaDosen.Text) Or Not dosen.Item(1).Contains(TxtNipDosen.Text) Then
            Return True
        End If
        Return False
    End Function

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If salah() Then
            MsgBox("Salah!")
        Else
            If BtnSimpan.Tag = True Then
                'Insert
                If Service.SqlDaAdapter("select * from vw_tugasakhir where nim = '" & TxtNimMahasiswa.Text & "'", "cektugasakhir") = True Then
                    If Service.DTSet.Tables("cektugasakhir").Rows.Count <> 0 Then
                        MsgBox("Tugas Akhir telah terdaftar", MsgBoxStyle.Exclamation, "Pesan")
                        Exit Sub
                    End If
                End If
                If Konfirmasi("simpan") = True Then
                    If Service.ExecuteNonQuery("insert into tblTugasAkhir2 (nim,judul,nipDoping) values('" & TxtNimMahasiswa.Text & "', '" & TxtJudul.Text & "', '" & TxtNipDosen.Text & "')", "tblDosen", TxtNimMahasiswa.Text) = True Then
                        Me.Dispose()
                    End If
                End If
            Else
                If Konfirmasi("ubah") = True Then
                    ubah()
                End If
            End If
        End If
    End Sub

    Private Sub TxtNamaMahasiswa_Enter(sender As Object, e As EventArgs) Handles TxtNamaMahasiswa.Enter
        If isAutoComplete(TxtNimMahasiswa, Me.tambahan1.Controls) Then
            removeAutoComplete(TxtNimMahasiswa, tambahan1.Controls)
        End If
        If isAutoComplete(TxtNamaMahasiswa, Me.TabPage1.Controls) = False Then
            TabPage1.Controls.SetChildIndex(autoComplete(TxtNamaMahasiswa, mahasiswa, TabPage1.Controls, 0), 0)
        End If
    End Sub

    Private Sub TxtNimMahasiswa_Enter(sender As Object, e As EventArgs) Handles TxtNimMahasiswa.Enter
        If isAutoComplete(TxtNamaMahasiswa, Me.TabPage1.Controls) Then
            removeAutoComplete(TxtNamaMahasiswa, TabPage1.Controls)
        End If
        If isAutoComplete(TxtNimMahasiswa, Me.tambahan1.Controls) = False Then
            tambahan1.Controls.SetChildIndex(autoComplete(TxtNimMahasiswa, mahasiswa, tambahan1.Controls, 1), 0)
        End If
    End Sub

    Private Sub TxtNamaMahasiswa_TextChanged(sender As Object, e As EventArgs) Handles TxtNamaMahasiswa.TextChanged
        If mahasiswa.Item(0).Contains(TxtNamaMahasiswa.Text) Then
            If Label11.Text.Chars(0) = "⏵" Then Label11_Click(New Object, New EventArgs)
            TxtNimMahasiswa.Text = mahasiswa(1).Item(mahasiswa.Item(0).IndexOf(TxtNamaMahasiswa.Text))
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        If Label11.Text.Chars(0) = "⏵" Then
            Label11.Text = Label11.Text.Remove(0, 1).Insert(0, "⏶")
            tambahan1.Visible = True
        Else
            Label11.Text = Label11.Text.Remove(0, 1).Insert(0, "⏵")
            tambahan1.Visible = False
        End If
    End Sub

    Private Sub TxtNimMahasiswa_TextChanged(sender As Object, e As EventArgs) Handles TxtNimMahasiswa.TextChanged
        If mahasiswa.Item(1).Contains(TxtNimMahasiswa.Text) Then
            TxtNamaMahasiswa.Text = mahasiswa(0).Item(mahasiswa.Item(1).IndexOf(TxtNimMahasiswa.Text))
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        mahasiswaCari()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        mahasiswaCari()
    End Sub

    Private Sub mahasiswaCari()
        Me.Visible = False
        FrmData.BtnTambah.Visible = False
        FrmData.BtnUbah.Visible = False
        FrmData.BtnHapus.Visible = False
        FrmData.BtnRefresh.Visible = False
        FrmData.PictureBox2.Visible = True
        formActiveName = "FrmTugasAkhir1"
        FrmMenuUtama.MenuStrip1.Enabled = False
        FrmData.ShowMenu("Mahasiswa", 4)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        If Label10.Text.Chars(0) = "⏵" Then
            Label10.Text = Label10.Text.Remove(0, 1).Insert(0, "⏶")
            tambahan2.Visible = True
        Else
            Label10.Text = Label10.Text.Remove(0, 1).Insert(0, "⏵")
            tambahan2.Visible = False
        End If
    End Sub

    Private Sub TxtNamaDosen_Enter(sender As Object, e As EventArgs) Handles TxtNamaDosen.Enter
        If isAutoComplete(TxtNipDosen, Me.tambahan2.Controls) Then
            removeAutoComplete(TxtNipDosen, tambahan2.Controls)
        End If
        If isAutoComplete(TxtNamaDosen, Me.TabPage2.Controls) = False Then
            TabPage2.Controls.SetChildIndex(autoComplete(TxtNamaDosen, dosen, TabPage2.Controls, 0), 0)
        End If
    End Sub

    Private Sub TxtNipDosen_Enter(sender As Object, e As EventArgs) Handles TxtNipDosen.Enter
        If isAutoComplete(TxtNamaDosen, Me.TabPage2.Controls) Then
            removeAutoComplete(TxtNamaDosen, TabPage2.Controls)
        End If
        If isAutoComplete(TxtNipDosen, Me.tambahan2.Controls) = False Then
            tambahan2.Controls.SetChildIndex(autoComplete(TxtNipDosen, dosen, tambahan2.Controls, 1), 0)
        End If
    End Sub

    Private Sub TxtNamaDosen_TextChanged(sender As Object, e As EventArgs) Handles TxtNamaDosen.TextChanged
        If dosen.Item(0).Contains(TxtNamaDosen.Text) Then
            If Label10.Text.Chars(0) = "⏵" Then Label10_Click(New Object, New EventArgs)
            TxtNipDosen.Text = dosen.Item(1).Item(dosen.Item(0).IndexOf(TxtNamaDosen.Text))
        End If
    End Sub

    Private Sub TxtNipDosen_TextChanged(sender As Object, e As EventArgs) Handles TxtNipDosen.TextChanged
        If dosen.Item(1).Contains(TxtNipDosen.Text) Then
            TxtNamaDosen.Text = dosen.Item(0).Item(dosen.Item(1).IndexOf(TxtNipDosen.Text))
        End If
    End Sub

    
    Private Sub FrmTugasAkhir_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSimpan_Click(New Object, New EventArgs)
        End If
    End Sub

    Private Sub FrmTugasAkhir_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub


    Private Sub dopingCari()
        Me.Hide()
        FrmData.BtnTambah.Visible = False
        FrmData.BtnUbah.Visible = False
        FrmData.BtnHapus.Visible = False
        FrmData.BtnRefresh.Visible = False
        FrmData.PictureBox2.Visible = True
        formActiveName = "FrmTugasAkhir2"
        FrmMenuUtama.MenuStrip1.Enabled = False
        FrmData.ShowMenu("Dosen", 3)
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        dopingCari()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        dopingCari()
    End Sub
End Class