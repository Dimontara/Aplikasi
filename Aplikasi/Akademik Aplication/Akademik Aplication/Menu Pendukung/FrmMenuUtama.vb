Public Class FrmMenuUtama
    Public sudah As Boolean = False
    Sub Dekstop()
        Try
            If Service.GetValueRegeti("Desktop") = "Bismillah" Then
                asli()
            Else
                BtnAsli.Checked = False : BtnUbah.Checked = True
                btmasli.Checked = False : Btmubah.Checked = True
                picdekstop.Image = Image.FromFile(Service.GetValueRegeti("Desktop"))
            End If
            picdekstop.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            asli()
        End Try

    End Sub
    Sub asli()
        picdekstop.Image = Nothing
        Try
            picdekstop.Image = Image.FromFile("Dekstop\1.jpg")
        Catch ex As Exception
            picdekstop.BackColor = Color.WhiteSmoke
            '   picdekstop.Image = Resources._1
        End Try
        Service.SetValueRegdit("Desktop", "Bismillah")
        BtnAsli.Checked = True : BtnUbah.Checked = False
        btmasli.Checked = True : Btmubah.Checked = False
        picdekstop.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
    Sub CekDataLogin()
        LblID.Text = Service.GetValueRegeti("Operator")
        If Service.SqlDaAdapter("select * from tblOperator where Iduser= '" & LblID.Text & "'", "DtLogin") = True Then
            Lbluser.Text = UCase(Service.DTSet.Tables("Dtlogin").Rows(0)("Nama"))
            Lbluser.Tag = Service.DTSet.Tables("Dtlogin").Rows(0)("password")
            'Lblakses.Text = UCase(Service.DTSet.Tables("Dtlogin").Rows(0)("HakAkses"))
        End If
        LblNameComputer.Text = "Name Computer : " & My.Computer.Name
        LblOs.Text = "Operating System : " & My.Computer.Info.OSFullName & "-" & My.Computer.Info.OSPlatform
    End Sub
    Private Sub FrmMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CekDataLogin()
        Dekstop()
    End Sub
    Sub Runtext()


    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Runtext()
        If LblID.ForeColor = Color.Green Then
            LblID.ForeColor = Color.Gray
            Lbluser.ForeColor = Color.Gray
            Lblakses.ForeColor = Color.Gray
            LblTime.ForeColor = Color.Gray
        Else
            LblID.ForeColor = Color.Green
            Lbluser.ForeColor = Color.Green
            Lblakses.ForeColor = Color.Green
            LblTime.ForeColor = Color.Green
        End If
        LblTime.Text = "Time : " & Format(Now, "HH:mm:ss")
        LblTanggal.Text = "Date : " & Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub BtnPerusahaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmPerusahaan.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmContactUs.ShowDialog()
    End Sub

    Private Sub BtnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogout.Click
        Me.IsMdiContainer = True
        Me.Hide()
        FrmLogin.Show()
        'On Error Resume Next
        'Process.Start(Application.StartupPath & "\" & My.Application.Info.AssemblyName & ".exe")
        'End
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        FrmMenuUtama_FormClosed(New Object, New FormClosedEventArgs(CloseReason.None))
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        Dim Open As New OpenFileDialog
        '    Open.InitialDirectory = Application.StartupPath & "\Dekstop"
        Open.Filter = "File Gambar(*.jpg;*.Png;*.Gif) '|*.JPG;*.png;*.Gif"
        If Open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dekstop()
            'Try
            picdekstop.Image = Image.FromFile(Open.FileName)
            Service.SetValueRegdit("Desktop", Open.FileName)
            BtnAsli.Checked = False : BtnUbah.Checked = True
            btmasli.Checked = False : Btmubah.Checked = True
            'Catch ex As Exception
        Else
            Exit Sub
            'asli()
        End If
        picdekstop.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub BtnAsli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAsli.Click
        asli()
    End Sub

    Private Sub Btmubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btmubah.Click
        BtnUbah_Click(sender, e)
    End Sub

    Private Sub btmasli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmasli.Click
        BtnAsli_Click(sender, e)
    End Sub

    Private Sub btmlogouet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmlogouet.Click
        BtnLogout_Click(sender, e)

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.Refresh()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.Close()
    End Sub

    Private Sub OperatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperatorToolStripMenuItem.Click
        FrmData.ShowMenu("Operator", 1)
    End Sub

    Private Sub ProdiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdiToolStripMenuItem.Click
        FrmData.ShowMenu("Program Studi", 2)
    End Sub

    Private Sub DosenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DosenToolStripMenuItem1.Click
        FrmData.ShowMenu("Dosen", 3)
    End Sub

    Private Sub MahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MahasiswaToolStripMenuItem.Click
        FrmData.ShowMenu("Mahasiswa", 4)
    End Sub

    Private Sub TugasAkhirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TugasAkhirToolStripMenuItem.Click
        FrmData.ShowMenu("Tugas Akhir", 5)
    End Sub

    Private Sub PenilaianTugasAkhirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenilaianTugasAkhirToolStripMenuItem.Click
        FrmData.ShowMenu("Penilaian Tugas Akhir", 6)
    End Sub

    Private Sub LaporanReguKerjaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanReguKerjaToolStripMenuItem.Click
        FrmLap.ShowMenu("Laporan Dosen", 7)
    End Sub

    Private Sub TugasAkhirPerTahunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TugasAkhirPerTahunToolStripMenuItem.Click
        FrmLap.ShowMenu("Laporan Tugas Akhir", 9)
    End Sub

    Private Sub MahasiswaPerTahunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MahasiswaPerTahunToolStripMenuItem.Click
        FrmLap.ShowMenu("Laporan Mahasiswa", 8)
    End Sub

    Private Sub FrmMenuUtama_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.Close()
    End Sub
End Class
