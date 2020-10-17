Public Class FrmPerusahaan
  
 Dim Photo() As Byte
  
    Sub TampilDataPerusahaan()
        Service.SqlDaAdapter("select * from TblPerusahaan", "TblPerusahaan")
        TxtIDPerusahaan.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)(0).ToString
        TxtNamaPerusahaan.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("Nama").ToString
        TxtAlamat.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("Alamat").ToString
        TxtKota.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("kota").ToString
        TxtProvinsi.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("Provinsi").ToString
        TxtNegara.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("Negara").ToString
        TxtEmail.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("Email").ToString
        TxtNoTlpn.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("NoTel").ToString
        TxtKontak.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("NoHp").ToString
        TxtFax.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("Fax").ToString
        TxtWeb.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("Website").ToString
        Txtselogan.Text = Service.DTSet.Tables("TblPerusahaan").Rows(0)("Slogan").ToString
        TxtNamaPerusahaan.Select()
        Try
            Photo = Service.DTSet.Tables("TblPerusahaan").Rows(0)("Logo")
            PicPerusahaan.Image = Image.FromStream(New IO.MemoryStream(Photo))
        Catch ex As Exception
            PicPerusahaan.Image = Nothing
        End Try
        LOKASIFOTO = ""
    End Sub
    Dim LOKASIFOTO, QuerySql As String
    Sub Simpan()

        If LOKASIFOTO = "NULL" Then
            QuerySql = New String("update TblPerusahaan set nama='" & Replace(TxtNamaPerusahaan.Text, "'", "''") & "',Alamat='" & Replace(TxtAlamat.Text, "'", "''") & "',Kota='" & Replace(TxtKota.Text, "'", "''") & "',Negara='" & Replace(TxtNegara.Text, "'", "''") & "',Provinsi='" & Replace(TxtProvinsi.Text, "'", "''") & "',NoTel='" & Replace(TxtNoTlpn.Text, "'", "''") & "',NoHp='" & Replace(TxtKontak.Text, "'", "''") & "',fax='" & Replace(TxtFax.Text, "'", "''") & "',Email='" & Replace(TxtEmail.Text, "'", "''") & "',Website='" & Replace(TxtWeb.Text, "'", "''") & "',Slogan='" & Replace(Txtselogan.Text, "'", "''") & "', Logo=NULL ")
        ElseIf LOKASIFOTO = "" Then
            QuerySql = New String("update TblPerusahaan set nama='" & Replace(TxtNamaPerusahaan.Text, "'", "''") & "',Alamat='" & Replace(TxtAlamat.Text, "'", "''") & "',Kota='" & Replace(TxtKota.Text, "'", "''") & "',Negara='" & Replace(TxtNegara.Text, "'", "''") & "',Provinsi='" & Replace(TxtProvinsi.Text, "'", "''") & "',NoTel='" & Replace(TxtNoTlpn.Text, "'", "''") & "',NoHp='" & Replace(TxtKontak.Text, "'", "''") & "',fax='" & Replace(TxtFax.Text, "'", "''") & "',Email='" & Replace(TxtEmail.Text, "'", "''") & "',Website='" & Replace(TxtWeb.Text, "'", "''") & "',Slogan='" & Replace(Txtselogan.Text, "'", "''") & "'")
        Else
            QuerySql = New String("update TblPerusahaan set nama='" & Replace(TxtNamaPerusahaan.Text, "'", "''") & "',Alamat='" & Replace(TxtAlamat.Text, "'", "''") & "',Kota='" & Replace(TxtKota.Text, "'", "''") & "',Negara='" & Replace(TxtNegara.Text, "'", "''") & "',Provinsi='" & Replace(TxtProvinsi.Text, "'", "''") & "',NoTel='" & Replace(TxtNoTlpn.Text, "'", "''") & "',NoHp='" & Replace(TxtKontak.Text, "'", "''") & "',fax='" & Replace(TxtFax.Text, "'", "''") & "',Email='" & Replace(TxtEmail.Text, "'", "''") & "',Website='" & Replace(TxtWeb.Text, "'", "''") & "',Slogan='" & Replace(Txtselogan.Text, "'", "''") & "', Logo=(select Bulkcolumn from Openrowset(Bulk '" & Replace(LOKASIFOTO, "'", "''") & "',Single_blob) as image) ")
        End If
        If Service.ExecuteNonQuery(QuerySql, "TblPerusahaan", "S01") = True Then
            MsgBox("Data berhasil di ubah!", MsgBoxStyle.Information, "pesan")
            Me.Close()
        End If

    End Sub
    Sub buka_gambar()
        Dim Open As New OpenFileDialog
        Open.Filter = "File Gambar(*.jpg;*.Png) '|*.JPG;*.png"
        Open.InitialDirectory = Application.StartupPath & "\Dekstop"
        If Open.ShowDialog() = vbOK Then
            PicPerusahaan.Image = Image.FromFile(Open.FileName)
        End If
        LOKASIFOTO = Open.FileName
        PicPerusahaan.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Sub menunggu()
        Me.Cursor = Cursors.WaitCursor
        BtnKeluar.Cursor = Cursors.WaitCursor
        BtnSimpan.Cursor = Cursors.WaitCursor
    End Sub
    Sub aktif()
        Me.Cursor = Cursors.Default
        BtnKeluar.Cursor = Cursors.Hand
        BtnSimpan.Cursor = Cursors.Hand
    End Sub
    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        menunggu()
        Simpan()
        aktif()
    End Sub
    Private Sub PicPerusahaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicPerusahaan.Click
        buka_gambar()
    End Sub
    Private Sub CariToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariToolStripMenuItem.Click
        buka_gambar()
    End Sub

    Private Sub HapusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        PicPerusahaan.Image = Nothing
        LOKASIFOTO = "NULL"
    End Sub
    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub TxtIDPerusahaan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtIDPerusahaan.KeyDown
        If e.KeyCode = 13 Then
            TxtNamaPerusahaan.Select()
        End If
    End Sub

    Private Sub TxtNamaPerusahaan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNamaPerusahaan.KeyDown
        If e.KeyCode = 13 Then
            TxtAlamat.Select()
        End If
    End Sub

    Private Sub TxtAlamat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAlamat.KeyDown
        If e.KeyCode = 13 Then
            TxtNegara.Select()
        End If
    End Sub

    Private Sub TxtNegara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNegara.KeyDown
        If e.KeyCode = 13 Then
            TxtKota.Select()
        End If
    End Sub
    Private Sub TxtKota_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtKota.KeyDown
        If e.KeyCode = 13 Then TxtProvinsi.Select()
    End Sub
    Private Sub TxtProvinsi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProvinsi.KeyDown
        If e.KeyCode = 13 Then TxtEmail.Select()
    End Sub
    Private Sub TxtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmail.KeyDown
        If e.KeyCode = 13 Then TxtNoTlpn.Select()

    End Sub
    Private Sub TxtNoTlpn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNoTlpn.KeyDown
        If e.KeyCode = 13 Then TxtKontak.Select()
    End Sub
    Private Sub TxtKontak_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtKontak.KeyDown
        If e.KeyCode = 13 Then TxtFax.Select()
    End Sub
    Private Sub TxtFax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFax.KeyDown
        If e.KeyCode = 13 Then TxtWeb.Select()
    End Sub
    Private Sub TxtWeb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtWeb.KeyDown
        If e.KeyCode = 13 Then Txtselogan.Select()
    End Sub
    Private Sub Txtselogan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtselogan.KeyDown
        If e.KeyCode = 13 Then BtnSimpan_Click(sender, e)
    End Sub
    Private Sub FrmPerusahaan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click
        CariToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub FrmPerusahaan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilDataPerusahaan()
    End Sub
End Class