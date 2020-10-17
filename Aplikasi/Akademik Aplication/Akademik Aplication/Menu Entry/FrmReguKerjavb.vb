Public Class FrmReguKerjavb
    Private IdRegu As String
    Public Sub ShowMenu(ByVal Jenis As Boolean)
        Me.Text = "Menu Regu Kerja"
        Awal()
        BtnSimpan.Tag = Jenis
        Me.ShowDialog()
    End Sub
    Public Sub CariDataUbah(ByVal IDRegu As String, ByVal Jenis As Boolean)
        Awal()
        If Service.SqlDaAdapter("select * from TblReguKerja where IDUser='" & IDRegu & "'", "Cari") = True Then
            IDRegu = IDRegu
            TxtNamaRegu.Text = Service.DTSet.Tables("Cari").Rows(0)("NamaRegu")
            TxtSektor.Text = Service.DTSet.Tables("Cari").Rows(0)("NamaRegu")
            TxtKet.Text = Service.DTSet.Tables("Cari").Rows(0)("NamaRegu")
            CariDataAnggota(Service.DTSet.Tables("Cari").Rows(0)("IDKepalaRegu").ToString)
            TxtNamaRegu.Select()
        End If
        Me.Text = "Ubah Regu Kerja"
        BtnSimpan.Tag = Jenis
        Me.ShowDialog()
    End Sub
    Sub Awal()
        NomorOtomatis()
        Me.Text = "Menu Regu Kerja"
        TxtNamaRegu.Clear()
        TxtSektor.Clear()
        TxtKet.Clear()
        ClearDataKepalaRegu()
        TxtIdAnggota.Clear()
        TxtNamaRegu.Select()
    End Sub
    Sub NomorOtomatis()
        IdRegu = Service.nomorotomatis("IDRegu", "TblReguKerja", "RK", 4)
    End Sub
    Sub ClearDataKepalaRegu()
        TxtNama.Clear()
        TxtNoReg.Clear()
        TxtJabatan.Clear()
        TxtAgama.Clear()
        TxtAlamat.Clear()
    End Sub
    Sub CariDataAnggota(ByVal IdAnggota As String)
        IdAnggota = Replace(IdAnggota, "'", "''")
        If Service.SqlDaAdapter("select * from ViewAnggota where IDAnggota='" & IdAnggota & "' or NoReg='" & IdAnggota & "' ", "ViewAnggota") Then
            If Service.DTSet.Tables("ViewAnggota").Rows.Count = 0 Then
                ClearDataKepalaRegu()
            Else
                TxtIdAnggota.Text = Service.DTSet.Tables("ViewAnggota").Rows(0)("NoReg")
                TxtIdAnggota.Tag = Service.DTSet.Tables("ViewAnggota").Rows(0)("IDAnggota")
                TxtNama.Text = Service.DTSet.Tables("ViewAnggota").Rows(0)("Nama").ToString
                TxtJabatan.Text = Service.DTSet.Tables("ViewAnggota").Rows(0)("jabatan").ToString
                TxtNoReg.Text = Service.DTSet.Tables("ViewAnggota").Rows(0)("TempatLahir").ToString & " - " & Service.DTSet.Tables("ViewAnggota").Rows(0)("TglLahir").ToString
                TxtAlamat.Text = Service.DTSet.Tables("ViewAnggota").Rows(0)("Alamat").ToString
                TxtAgama.Text = Service.DTSet.Tables("ViewAnggota").Rows(0)("Agama").ToString
            End If
        End If
    End Sub
    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtNamaRegu.Text.Trim = "" Then MsgBox("Nama regu tidak boleh kososng !", MsgBoxStyle.Exclamation, "Pesan") : TxtNamaRegu.Select() : Exit Sub
        CariDataAnggota(TxtIdAnggota.Text)
        If TxtNama.Text.Trim = "" Then MsgBox("Data kepala regu tidak boleh kososng !", MsgBoxStyle.Exclamation, "Pesan") : TxtNama.Select() : Exit Sub
        If BtnSimpan.Tag = True Then
            If Konfirmasi("simpan") = True Then
                NomorOtomatis()
                If Service.ExecuteNonQuery("insert into TblReguKerja (IDRegu,NamaRegu,Sektor,IDKepalaRegu,Ket) values ('" & IdRegu & "','" & Replace(TxtNamaRegu.Text, "'", "''") & "','" & Replace(TxtSektor.Text, "'", "''") & "','" & TxtIdAnggota.Tag & "','" & Replace(TxtKet.Text, "'", "''") & "')", "TblReguKerja", IdRegu) = True Then
                    MsgBox("Data regu berhasil di simpan !", MsgBoxStyle.Information, "Pesan")
                    Awal()
                End If
            End If
        End If
    End Sub
    Private Sub TxtIdAnggota_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtIdAnggota.KeyDown
        If e.KeyCode = 13 Then CariDataAnggota(TxtIdAnggota.Text)
    End Sub
End Class