Public Class FrmNilaiTugasAkhir
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
        TxtJudul.Text = "Update tblTugasAkhir2 set judul = '" & TxtJudul.Text & "', nipDoping = '" & TxtNipDosen.Text & "', txtnipdosen1 = '" & TxtNipDosen1.Text & "' , nilaidosen1 = '" & txtnilaidosen1.Text & "', nipdosen2 = '" & TxtNipDosen2.Text & "', nilaidosen2 = '" & TxtNilaiDosen2.Text & "'  where nim ='" & TxtNimMahasiswa.Text & "'"
        Exit Sub
        If Service.ExecuteNonQuery("Update tblTugasAkhir2 set judul = '" & TxtJudul.Text & "', nipDoping = '" & TxtNipDosen.Text & "', txtnipdosen1 = '" & TxtNipDosen1.Text & "' , nilaidosen1 = '" & txtnilaidosen1.Text & "', nipdosen2 = '" & TxtNipDosen2.Text & "', nilaidosen2 = '" & TxtNilaiDosen2.Text & "'  where nim ='" & TxtNimMahasiswa.Text & "'", "tblDosen", "") = True Then
            MsgBox("Data berhasil di Ubah!", MsgBoxStyle.Information, "pesan")
            Awal()
            Me.Close()
        End If
    End Sub

    Public Sub CariDataUbah(ByVal ID As String, ByVal Jenis As Boolean)
        Awal()
        TxtNamaMahasiswa.Enabled = False
        TxtNimMahasiswa.Enabled = False
        Service.SqlDaAdapter("select * from vw_nilaitugasakhir where nim ='" & ID & "'", "Cari")
        Dim datatble As DataTable = Service.DTSet.Tables("Cari").Copy()
        TxtNimMahasiswa.Text = datatble.Rows(0)("nim")
        TxtNipDosen.Text = datatble.Rows(0)("nipDoping")
        TxtNipDosen1.Text = datatble.Rows(0)("nipDosen1")
        txtnilaidosen1.Text = datatble.Rows(0)("nilaiDosen1")
        TxtNipDosen2.Text = datatble.Rows(0)("nipDosen2")
        TxtNilaiDosen2.Text = datatble.Rows(0)("nilaiDosen2")
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
        If Not mahasiswa.Item(0).Contains(TxtNamaMahasiswa.Text) Or Not mahasiswa.Item(1).Contains(TxtNimMahasiswa.Text) Or Not dosen.Item(0).Contains(TxtNamaDosen.Text) Or Not dosen.Item(1).Contains(TxtNipDosen.Text) Then
            Return True
        End If
        If Not dosen.Item(0).Contains(TxtNamaDosen1.Text) Or Not dosen.Item(1).Contains(TxtNipDosen1.Text) Or Not dosen.Item(0).Contains(TxtNamaDosen2.Text) Or Not dosen.Item(1).Contains(TxtNipDosen2.Text) Or Not dosen.Item(0).Contains(TxtNamaDosen.Text) Or Not dosen.Item(1).Contains(TxtNipDosen.Text) Then
            Return True
        End If
        If TxtNilaiAkhir.Text = "" Then
            Return True
        End If
        Return False
    End Function

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If salah() Then
            MsgBox("Salah!")
        Else
            If BtnSimpan.Tag = True Then
                If Konfirmasi("simpan") = True Then
                    If Service.ExecuteNonQuery("update tblTugasAkhir2 set judul =  '" & TxtJudul.Text & "', nipDoping = '" & TxtNipDosen.Text & "', nipDosen1 = '" & TxtNipDosen1.Text & "', nipDosen2  = '" & TxtNipDosen2.Text & "', nilaiDosen1 = '" & txtnilaidosen1.Text & "', nilaidosen2 ='" & TxtNilaiDosen2.Text & "', nilaitotal = '" & TxtNilaiAkhir.Text & "', tanggalsidang = '" & tgl.Text & "' where nim = '" & TxtNimMahasiswa.Text & "'", "tblDosen", TxtNimMahasiswa.Text) = True Then
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
            TxtNipDosen.Text = tugasakhir(mahasiswa(1).Item(mahasiswa.Item(0).IndexOf(TxtNamaMahasiswa.Text)), "nim").Item(2).Item(0)
            TxtJudul.Text = tugasakhir(mahasiswa(1).Item(mahasiswa.Item(0).IndexOf(TxtNamaMahasiswa.Text)), "nim").Item(0).Item(0)
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
            TxtNipDosen.Text = tugasakhir(TxtNimMahasiswa.Text, "nim").Item(2).Item(0)
            TxtJudul.Text = tugasakhir(TxtNimMahasiswa.Text, "nim").Item(0).Item(0)
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
        formActiveName = "FrmNilaiTugasAkhir1"
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
            'TxtNimMahasiswa.Text = tugasakhir(dosen.Item(1).Item(dosen.Item(0).IndexOf(TxtNamaDosen.Text)), "nipDoping").Item(1).Item(0)
            'TxtJudul.Text = tugasakhir(dosen.Item(1).Item(dosen.Item(0).IndexOf(TxtNamaDosen.Text)), "nipDoping").Item(0).Item(0)
            TxtNipDosen.Text = dosen.Item(1).Item(dosen.Item(0).IndexOf(TxtNamaDosen.Text))
        End If
    End Sub

    Private Sub TxtNipDosen_TextChanged(sender As Object, e As EventArgs) Handles TxtNipDosen.TextChanged
        If dosen.Item(1).Contains(TxtNipDosen.Text) Then
            'TxtJudul.Text = tugasakhir(TxtNipDosen.Text, "nipDoping").Item(0).Item(0)
            'TxtNimMahasiswa.Text = tugasakhir(TxtNipDosen.Text, "nipDoping").Item(1).Item(0)
            TxtNamaDosen.Text = dosen.Item(0).Item(dosen.Item(1).IndexOf(TxtNipDosen.Text))
        End If
    End Sub


    Private Sub FrmTugasAkhir_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSimpan_Click(New Object, New EventArgs)
        End If
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        If Label18.Text.Chars(0) = "⏵" Then
            Label18.Text = Label18.Text.Remove(0, 1).Insert(0, "⏶")
            sisa1.Location = New Point(sisa1.Location.X, sisa1.Location.Y + 30)
            tambahan3.Location = New Point(sisa1.Location.X, tambahan3.Location.Y)
        Else
            Label18.Text = Label18.Text.Remove(0, 1).Insert(0, "⏵")
            sisa1.Location = New Point(sisa1.Location.X, sisa1.Location.Y - 30)
            tambahan3.Location = New Point(500, tambahan3.Location.Y)
        End If
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        If Label28.Text.Chars(0) = "⏵" Then
            Label28.Text = Label28.Text.Remove(0, 1).Insert(0, "⏶")
            sisa2.Location = New Point(sisa2.Location.X, sisa2.Location.Y + 30)
            tambahan4.Location = New Point(sisa1.Location.X, tambahan3.Location.Y)
        Else
            Label28.Text = Label28.Text.Remove(0, 1).Insert(0, "⏵")
            sisa2.Location = New Point(sisa2.Location.X, sisa2.Location.Y - 30)
            tambahan4.Location = New Point(500, tambahan4.Location.Y)
        End If
    End Sub

    Private Sub TxtNamaDosen1_Enter(sender As Object, e As EventArgs) Handles TxtNamaDosen1.Enter
        If isAutoComplete(TxtNipDosen1, Me.TabPage4.Controls) Then
            removeAutoComplete(TxtNipDosen1, TabPage4.Controls)
        End If
        If isAutoComplete(TxtNamaDosen1, Me.TabPage4.Controls) = False Then
            TabPage4.Controls.SetChildIndex(autoComplete(TxtNamaDosen1, dosen, TabPage4.Controls, 0), 0)
        End If
    End Sub

    Private Sub TxtNipDosen1_Enter(sender As Object, e As EventArgs) Handles TxtNipDosen1.Enter
        If isAutoComplete(TxtNamaDosen1, Me.TabPage4.Controls) Then
            removeAutoComplete(TxtNamaDosen1, TabPage4.Controls)
        End If
        If isAutoComplete(TxtNipDosen1, Me.TabPage4.Controls) = False Then
            TabPage4.Controls.SetChildIndex(autoComplete(TxtNipDosen1, dosen, TabPage4.Controls, 1, Label18.Location.X + 150, Label18.Location.Y + 30), 0)
        End If
    End Sub

    Private Sub TxtNamaDosen2_Enter(sender As Object, e As EventArgs) Handles TxtNamaDosen2.Enter
        If isAutoComplete(TxtNipDosen2, Me.TabPage3.Controls) Then
            removeAutoComplete(TxtNipDosen2, TabPage3.Controls)
        End If
        If isAutoComplete(TxtNamaDosen2, Me.TabPage3.Controls) = False Then
            TabPage3.Controls.SetChildIndex(autoComplete(TxtNamaDosen2, dosen, TabPage3.Controls, 0), 0)
        End If
    End Sub

    Private Sub TxtNipDosen2_Enter(sender As Object, e As EventArgs) Handles TxtNipDosen2.Enter
        If isAutoComplete(TxtNamaDosen2, Me.TabPage3.Controls) Then
            removeAutoComplete(TxtNamaDosen2, TabPage5.Controls)
        End If
        If isAutoComplete(TxtNipDosen2, Me.TabPage3.Controls) = False Then
            TabPage3.Controls.SetChildIndex(autoComplete(TxtNipDosen2, dosen, TabPage3.Controls, 1, Label28.Location.X + 150, Label28.Location.Y + 30), 0)
        End If
    End Sub

    Private Sub TxtNamaDosen1_TextChanged(sender As Object, e As EventArgs) Handles TxtNamaDosen1.TextChanged
        If dosen.Item(0).Contains(TxtNamaDosen1.Text) Then
            If Label18.Text.Chars(0) = "⏵" Then Label18_Click(New Object, New EventArgs)
            TxtNipDosen1.Text = dosen.Item(1).Item(dosen.Item(0).IndexOf(TxtNamaDosen1.Text))
        End If
    End Sub

    Private Sub TxtNipDosen1_TextChanged(sender As Object, e As EventArgs) Handles TxtNipDosen1.TextChanged
        If dosen.Item(1).Contains(TxtNipDosen1.Text) Then
            TxtNamaDosen1.Text = dosen.Item(0).Item(dosen.Item(1).IndexOf(TxtNipDosen1.Text))
        End If
    End Sub

    Private Sub TxtNamaDosen2_TextChanged(sender As Object, e As EventArgs) Handles TxtNamaDosen2.TextChanged
        If dosen.Item(0).Contains(TxtNamaDosen2.Text) Then
            If Label28.Text.Chars(0) = "⏵" Then Label28_Click(New Object, New EventArgs)
            TxtNipDosen2.Text = dosen.Item(1).Item(dosen.Item(0).IndexOf(TxtNamaDosen2.Text))
        End If
    End Sub

    Private Sub TxtNipDosen2_TextChanged(sender As Object, e As EventArgs) Handles TxtNipDosen2.TextChanged
        If dosen.Item(1).Contains(TxtNipDosen2.Text) Then
            TxtNamaDosen2.Text = dosen.Item(0).Item(dosen.Item(1).IndexOf(TxtNipDosen2.Text))
        End If
    End Sub

    Private Sub FrmNilaiTugasAkhir_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub TxtJudul_Enter(sender As Object, e As EventArgs) Handles TxtJudul.Enter
        If isAutoComplete(TxtJudul, Me.TabPage5.Controls) = False Then
            TabPage5.Controls.SetChildIndex(autoComplete(TxtJudul, tugasakhir, TabPage5.Controls, 0), 0)
        End If
    End Sub

    Sub dopingCari()
        Me.Hide()
        FrmData.BtnTambah.Visible = False
        FrmData.BtnUbah.Visible = False
        FrmData.BtnHapus.Visible = False
        FrmData.BtnRefresh.Visible = False
        FrmData.PictureBox2.Visible = True
        formActiveName = "FrmNilaiTugasAkhir2"
        FrmMenuUtama.MenuStrip1.Enabled = False
        FrmData.ShowMenu("Dosen", 3)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        dopingCari()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        dopingCari()
    End Sub

    Sub dosen1Cari()
        Me.Hide()
        FrmData.BtnTambah.Visible = False
        FrmData.BtnUbah.Visible = False
        FrmData.BtnHapus.Visible = False
        FrmData.BtnRefresh.Visible = False
        FrmData.PictureBox2.Visible = True
        formActiveName = "FrmNilaiTugasAkhir3"
        FrmMenuUtama.MenuStrip1.Enabled = False
        FrmData.ShowMenu("Dosen", 3)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        dosen1Cari()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        dosen1Cari()
    End Sub

    Sub dosen2cari()
        Me.Hide()
        FrmData.BtnTambah.Visible = False
        FrmData.BtnUbah.Visible = False
        FrmData.BtnHapus.Visible = False
        FrmData.BtnRefresh.Visible = False
        FrmData.PictureBox2.Visible = True
        formActiveName = "FrmNilaiTugasAkhir4"
        FrmMenuUtama.MenuStrip1.Enabled = False
        FrmData.ShowMenu("Dosen", 3)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        dosen2cari()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        dosen2cari()
    End Sub

    Private Sub TxtJudul_TextChanged(sender As Object, e As EventArgs) Handles TxtJudul.TextChanged
        If tugasakhir.Item(0).Contains(TxtJudul.Text) Then
            TxtNipDosen.Text = tugasakhir(TxtJudul.Text, "judul").Item(0).Item(0)
            TxtNimMahasiswa.Text = tugasakhir(TxtJudul.Text, "judul").Item(1).Item(0)
        End If
    End Sub

    Private Sub nilaidosen1_TextChanged(sender As Object, e As EventArgs) Handles txtnilaidosen1.TextChanged
        Dim nilai1 = txtnilaidosen1.Text, nilai2 = TxtNilaiDosen2.Text
        If nilai1 = "" Then
            nilai1 = "0"
        End If
        If nilai2 = "" Then
            nilai2 = "0"
        End If
        TxtNilaiAkhir.Text = Convert.ToInt32(nilai1) + Convert.ToInt32(nilai2)
    End Sub

    Private Sub TxtNilaiDosen2_TextChanged(sender As Object, e As EventArgs) Handles TxtNilaiDosen2.TextChanged
        Dim nilai1 = txtnilaidosen1.Text, nilai2 = TxtNilaiDosen2.Text
        If nilai1 = "" Then
            nilai1 = "0"
        End If
        If nilai2 = "" Then
            nilai2 = "0"
        End If
        TxtNilaiAkhir.Text = Convert.ToInt32(nilai1) + Convert.ToInt32(nilai2)
    End Sub

    Private Sub nilaidosen1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnilaidosen1.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNilaiDosen2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNilaiDosen2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class