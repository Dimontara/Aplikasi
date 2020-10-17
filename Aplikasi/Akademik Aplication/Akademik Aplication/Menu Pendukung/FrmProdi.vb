Public Class FrmProdi
    Public Sub ShowMenu(ByVal Jenis As Boolean)
        Me.Text = "Pendaftaran Prodi Baru"
        TxtNama.Clear()
        TxtKode.Clear()
        TxtKode.Enabled = True
        BtnSimpan.Tag = Jenis
        TxtKode.Select()
        Me.ShowDialog()
    End Sub

    Sub Awal()
        Me.Text = "Menu Data Prodi"
        TxtKode.Clear()
        TxtNama.Clear()
    End Sub

    Sub ubah(ByVal ID As String)
        TxtKode.Enabled = True
        If ID = "" Then MsgBox("ID Tidak ditemukan") : Exit Sub
        If Service.ExecuteNonQuery("Update tblProdi set NamaProdi='" & Replace(TxtNama.Text, "'", "''") & "'  where kodeprodi='" & ID & "'", "tblProdi", "") = True Then
            MsgBox("Data berhasil di Ubah!", MsgBoxStyle.Information, "pesan")
            Awal()
            Me.Close()
        End If
    End Sub

    Public Sub CariDataUbah(ByVal ID As String, ByVal Jenis As Boolean)
        Awal()
        If Service.SqlDaAdapter("select * from tblProdi where kodeprodi ='" & ID & "'", "Cari") = True Then
            If Service.DTSet.Tables("Cari").Rows.Count <> 0 Then
                TxtKode.Text = Service.DTSet.Tables("Cari").Rows(0)("kodeprodi")
                TxtNama.Text = Service.DTSet.Tables("Cari").Rows(0)("namaprodi")
            End If
        End If
        Me.Text = "Ubah Data Prodi"
        BtnSimpan.Tag = Jenis
        TxtKode.Enabled = False
        Me.ShowDialog()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtKode.Text.Trim = "" Then MsgBox("Kode tidak boleh kososng !", MsgBoxStyle.Exclamation, "Pesan") : TxtKode.Select() : Exit Sub
        If TxtNama.Text.Trim = "" Then MsgBox("Nama tidak boleh kososng !", MsgBoxStyle.Exclamation, "Pesan") : TxtNama.Select() : Exit Sub
        'Perintah Simpan dan ubah
        If BtnSimpan.Tag = True Then
            'Insert
            If Service.SqlDaAdapter("select * from tblProdi where kodeprodi = '" & TxtKode.Text & "'", "CekProdi") = True Then
                If Service.DTSet.Tables("CekProdi").Rows.Count <> 0 Then
                    MsgBox("Prodi " & TxtKode.Text & " telah terdaftar !", MsgBoxStyle.Exclamation, "Pesan")
                    TxtNama.Select()
                    Exit Sub
                End If
            End If
            If Konfirmasi("simpan") = True Then
                If Service.ExecuteNonQuery("insert into tblProdi values('" & TxtKode.Text & "', '" & TxtNama.Text & "')", "tblProdi", TxtKode.Text) = True Then
                    Me.Dispose()
                End If
            End If
        Else
            If Konfirmasi("ubah") = True Then
                ubah(TxtKode.Text)
            End If
        End If
    End Sub
End Class