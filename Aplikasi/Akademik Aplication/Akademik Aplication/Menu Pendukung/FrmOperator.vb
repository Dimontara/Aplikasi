Public Class FrmOperator
    Dim IDUSer As String
    Public Sub ShowMenu(ByVal Jenis As Boolean)
        NomorOtomatis()
        Me.Text = "Pendaftaran Operator Baru"
        TxtNama.Clear()
        TxtEmail.Clear()
        DtTglLahir.Checked = False
        TxtAlamat.Clear()
        TxtPassword.Clear()
        TxtUsername.Clear()
        TxtPassword.PasswordChar = FrmLogin.PasswordTextBox.PasswordChar
        BtnSimpan.Tag = Jenis
        TxtNama.Select()
        Me.ShowDialog()
    End Sub
    Sub NomorOtomatis()
        IDUSer = Service.nomorotomatis("IdUser", "TblOperator", "IU", 3)
    End Sub

    Sub Awal()
        Me.Text = "Menu Data Operator"
        TxtNama.Clear()
        DtTglLahir.Value = Now
        TxtNoHp.Clear()
        TxtAlamat.Clear()
        TxtEmail.Clear()
        TxtUsername.Clear()
        TxtPassword.Clear()
    End Sub

    Sub ubah(ByVal ID As String)
        If ID = "" Then MsgBox("ID Tidak ditemukan") : Exit Sub
        If Service.ExecuteNonQuery("Update tblOperator set Nama='" & Replace(TxtNama.Text, "'", "''") & "', tgllahir='" & Format(DtTglLahir.Value, "yyyy-MM-dd") & "',alamat='" & Replace(TxtAlamat.Text, "'", "''") & "',nohp='" & Replace(TxtNoHp.Text, "'", "''") & "',email='" & Replace(TxtEmail.Text, "'", "''") & "',Username='" & Replace(TxtUsername.Text, "'", "''") & "',Password='" & Replace(Lib02.Encrypt(TxtPassword.Text), "'", "''") & "' where IdUser='" & ID & "'", "tbloperator", "") = True Then
            MsgBox("Data berhasil di Ubah!", MsgBoxStyle.Information, "pesan")
            Awal()
            Me.Close()
        End If
    End Sub

    Public Sub CariDataUbah(ByVal ID As String, ByVal Jenis As Boolean)
        Awal()
        If Service.SqlDaAdapter("select * from tbloperator where IDUser='" & ID & "'", "Cari") = True Then
            If Service.DTSet.Tables("Cari").Rows.Count <> 0 Then
                TxtNama.Text = Service.DTSet.Tables("Cari").Rows(0)("nama")
                TxtAlamat.Text = Service.DTSet.Tables("Cari").Rows(0)("Alamat")
                DtTglLahir.Value = Service.DTSet.Tables("Cari").Rows(0)("tgllahir")
                TxtNoHp.Text = Service.DTSet.Tables("Cari").Rows(0)("NoHP")
                TxtEmail.Text = Service.DTSet.Tables("Cari").Rows(0)("Email")
                TxtUsername.Text = Service.DTSet.Tables("Cari").Rows(0)("Username")
                TxtPassword.Text = Lib02.Decrypt(Service.DTSet.Tables("Cari").Rows(0)("Password"))
                IDUSer = ID
            End If
        End If
        Me.Text = "Ubah Data Operator"
        BtnSimpan.Tag = Jenis
        Me.ShowDialog()

    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtNama.Text.Trim = "" Then MsgBox("Nama tidak boleh kososng !", MsgBoxStyle.Exclamation, "Pesan") : TxtNama.Select() : Exit Sub
        If TxtUsername.Text.Trim = "" Then MsgBox("Username tidak boleh kososng !", MsgBoxStyle.Exclamation, "Pesan") : TxtUsername.Select() : Exit Sub
        If TxtPassword.Text.Trim = "" Then MsgBox("Password tidak boleh kososng !", MsgBoxStyle.Exclamation, "Pesan") : TxtPassword.Select() : Exit Sub
        If Service.SqlDaAdapter("select * from TblOperator where iduser <> '" & IDUSer & "' and username='" & Replace(TxtUsername.Text, "'", "''") & "'", "CekUser") = True Then
            If Service.DTSet.Tables("CekUser").Rows.Count <> 0 Then
                MsgBox("Username " & TxtUsername.Text & " telah terdaftar !", MsgBoxStyle.Exclamation, "Pesan")
                TxtUsername.Select()
                Exit Sub
            End If
        End If

        'Perintah Simpan dan ubah
        If BtnSimpan.Tag = True Then
            'Insert
            If Konfirmasi("simpan") = True Then
                NomorOtomatis()
                If Service.ExecuteNonQuery("insert into TblOperator (IdUser,Nama,TglLahir,Alamat,NoHp,Email,Username,Password) values ('" & IDUSer & "','" & Replace(TxtNama.Text, "'", "''") & "', '" & Format(DtTglLahir.Value, "yyyy-MM-dd") & "','" & Replace(TxtAlamat.Text, "'", "''") & "' ,'" & Replace(TxtNoHp.Text, "'", "''") & "', '" & Replace(TxtEmail.Text, "'", "''") & "','" & Replace(TxtUsername.Text, "'", "''") & "','" & Replace(Lib02.Encrypt(TxtPassword.Text), "'", "''") & "')", "TblOperator", IDUSer) = True Then
                    Me.Dispose()
                End If
            End If
        Else
            If Konfirmasi("ubah") = True Then
                ubah(IDUSer)
            End If
        End If
    End Sub
End Class