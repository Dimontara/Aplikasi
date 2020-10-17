Public Class FrmDosen
    Public Sub ShowMenu(ByVal Jenis As Boolean)
        Me.Text = "Pendaftaran Dosen"
        TxtKode.Enabled = True
        Awal()
        BtnSimpan.Tag = Jenis
        Me.ShowDialog()
    End Sub

    Sub Awal()
        Me.Text = "Menu Data Dosen"
        AddHandler TxtProdi.TextChanged, AddressOf TxtProdi_TextChanged
        AddHandler TxtKodeProdi.TextChanged, AddressOf TxtKodeProdi_TextChanged
        TxtKode.Clear()
        TxtNama.Clear()
        TxtNama.Clear()
        TxtKode.Clear()
        TxtAlamat.Clear()
        TxtNoHp.Clear()
        TxtEmail.Clear()
    End Sub

    Sub ubah(ByVal ID As String)
        TxtKode.Enabled = True
        If ID = "" Then MsgBox("ID Tidak ditemukan") : Exit Sub
        If Service.ExecuteNonQuery("Update tblDosen set nama ='" & Replace(TxtNama.Text, "'", "''") & "', alamat = '" & TxtAlamat.Text & "', nohp = '" & TxtNoHp.Text & "', email = '" & TxtEmail.Text & "', kodeProdi = '" & TxtKodeProdi.Text & "'  where nip='" & ID & "'", "tblDosen", "") = True Then
            MsgBox("Data berhasil di Ubah!", MsgBoxStyle.Information, "pesan")
            Awal()
            Me.Close()
        End If
    End Sub

    Public Sub CariDataUbah(ByVal ID As String, ByVal Jenis As Boolean)
        Awal()
        If Service.SqlDaAdapter("select tblDosen.*, tblProdi.NamaProdi from tblDosen, tblProdi where tblDosen.kodeProdi = tblProdi.kodeProdi and tblDosen.nip ='" & ID & "'", "Cari") = True Then
            If Service.DTSet.Tables("Cari").Rows.Count <> 0 Then
                TxtKode.Text = Service.DTSet.Tables("Cari").Rows(0)("nip")
                TxtNama.Text = Service.DTSet.Tables("Cari").Rows(0)("nama")
                TxtAlamat.Text = Service.DTSet.Tables("Cari").Rows(0)("alamat")
                TxtNoHp.Text = Service.DTSet.Tables("Cari").Rows(0)("nohp")
                TxtEmail.Text = Service.DTSet.Tables("Cari").Rows(0)("email")
                TxtKodeProdi.Text = Service.DTSet.Tables("Cari").Rows(0)("kodeProdi")
            End If
        End If
        Me.Text = "Ubah Data Dosen"
        BtnSimpan.Tag = Jenis
        TxtKode.Enabled = False
        Me.ShowDialog()
    End Sub

    Private Function salah() As Boolean
        For i As Integer = 0 To Me.TabControl1.Controls.Count - 1
            For j As Integer = 0 To Me.TabControl1.Controls(i).Controls.Count - 1
                If Me.TabControl1.Controls(i).Controls(j).GetType.Name = "TextBox" Then
                    If Me.TabControl1.Controls(i).Controls(j).Text = "" Then
                        Return True
                    End If
                ElseIf Me.TabControl1.Controls(i).Controls(j).Name = "bawahProdi" Then
                    If Me.TabControl1.Controls(i).Controls(j).Controls(0).Text = "" Then
                        Return True
                    End If
                End If
            Next
        Next
        If Not prodi().Item(0).Contains(TxtProdi.Text) Or Not prodi().Item(1).Contains(TxtKodeProdi.Text) Then
            Return True
        End If
        Return False
    End Function

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If salah() Then
            MsgBox("Masih ada yang kosong/Prodi salah input")
        Else
            If BtnSimpan.Tag = True Then
                'Insert
                If Service.SqlDaAdapter("select * from tblDosen where nip = '" & TxtKode.Text & "'", "CekDosen") = True Then
                    If Service.DTSet.Tables("CekDosen").Rows.Count <> 0 Then
                        MsgBox("Dosen " & TxtKode.Text & " telah terdaftar !", MsgBoxStyle.Exclamation, "Pesan")
                        TxtKode.Select()
                        Exit Sub
                    End If
                End If
                If Konfirmasi("simpan") = True Then
                    If Service.ExecuteNonQuery("insert into tblDosen values('" & TxtKode.Text & "', '" & TxtNama.Text & "', '" & TxtAlamat.Text & "', '" & TxtNoHp.Text & "', '" & TxtEmail.Text & "', '" & TxtKodeProdi.Text & "')", "tblDosen", TxtKode.Text) = True Then
                        Me.Dispose()
                    End If
                End If
            Else
                If Konfirmasi("ubah") = True Then
                    ubah(TxtKode.Text)
                End If
            End If
        End If
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        If Label16.Text.Chars(0) = "⏵" Then
            Label16.Text = Label16.Text.Remove(0, 1).Insert(0, "⏶")
            tambahan.TabStop = True
            TxtKodeProdi.TabStop = True            
            tambahan.Location = New Point(Label16.Location.X + 20, tambahan.Location.Y)
        Else
            Label16.Text = Label16.Text.Remove(0, 1).Insert(0, "⏵")
            tambahan.TabStop = False
            TxtKodeProdi.TabStop = False
            TxtProdi.Select()
            tambahan.Location = New Point(491, tambahan.Location.Y)
        End If
    End Sub

    Private Sub TxtNoHp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNoHp.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtProdi_Enter(sender As Object, e As EventArgs) Handles TxtProdi.Enter
        If isAutoComplete(TxtKodeProdi, Me.TabPage2.Controls) Then
            removeAutoComplete(TxtKodeProdi, TabPage2.Controls)
        End If
        If isAutoComplete(TxtProdi, Me.TabPage2.Controls) = False Then
            TabPage2.Controls.SetChildIndex(autoComplete(TxtProdi, prodi, TabPage2.Controls, 0), 0)
        End If
    End Sub

    Private Sub TxtKodeProdi_Enter(sender As Object, e As EventArgs) Handles TxtKodeProdi.Enter
        If isAutoComplete(TxtProdi, Me.TabPage2.Controls) Then
            removeAutoComplete(TxtProdi, TabPage2.Controls)
        End If
        If Not isAutoComplete(TxtKodeProdi, Me.TabPage2.Controls) Then
            TabPage2.Controls.SetChildIndex(autoComplete(TxtKodeProdi, prodi, TabPage2.Controls, 1, tambahan.Location.X + TxtKodeProdi.Location.X, tambahan.Location.Y), 0)
        End If
    End Sub

    Private Sub TxtProdi_TextChanged(sender As Object, e As EventArgs)
        If prodi.Item(0).Contains(TxtProdi.Text) Then
            If Label16.Text.Chars(0) = "⏵" Then Label16_Click(New Object, New EventArgs)
            TxtKodeProdi.Text = prodi(1).Item(prodi.Item(0).IndexOf(TxtProdi.Text))
        End If
    End Sub

    Private Sub TxtKodeProdi_TextChanged(sender As Object, e As EventArgs)
        If prodi.Item(1).Contains(TxtKodeProdi.Text) Then
            TxtProdi.Text = prodi(0).Item(prodi.Item(1).IndexOf(TxtKodeProdi.Text))
        End If
    End Sub

    Private Sub FrmDosen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSimpan_Click(New Object, New EventArgs)
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        FrmData.BtnTambah.Visible = False
        FrmData.BtnUbah.Visible = False
        FrmData.BtnHapus.Visible = False
        FrmData.BtnRefresh.Visible = False
        FrmData.PictureBox2.Visible = True
        formActiveName = "FrmDosen"
        FrmMenuUtama.MenuStrip1.Enabled = False
        FrmData.ShowMenu("Program Studi", 2)
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Me.Hide()
        FrmData.BtnTambah.Visible = False
        FrmData.BtnUbah.Visible = False
        FrmData.BtnHapus.Visible = False
        FrmData.BtnRefresh.Visible = False
        FrmData.PictureBox2.Visible = True
        formActiveName = "FrmDosen"
        FrmMenuUtama.MenuStrip1.Enabled = False
        FrmData.ShowMenu("Program Studi", 2)
    End Sub

    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics = e.Graphics
        Dim _textBrush As Brush
        Dim _tabPage As TabPage = TabControl1.TabPages(e.Index)
        Dim _tabBounds As Rectangle = TabControl1.GetTabRect(e.Index)

        If e.State = DrawItemState.Selected Then
            _textBrush = New SolidBrush(Color.White)
            g.FillRectangle(Brushes.Gray, e.Bounds)
        Else
            _textBrush = New System.Drawing.SolidBrush(e.ForeColor)
            e.DrawBackground()
        End If

        Dim _tabFont As Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        Dim _stringFlags As StringFormat = New StringFormat()
        _stringFlags.Alignment = StringAlignment.Center
        _stringFlags.LineAlignment = StringAlignment.Center
        g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, New StringFormat(_stringFlags))
    End Sub
End Class