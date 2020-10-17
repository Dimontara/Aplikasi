Imports System.Data.SqlClient
Public Class FrmConfigurasiServer
    Dim SRV As New Service
    Sub Awal()
        Me.ShowDialog()
    End Sub
    Sub CreateText()
        Txt_server.Text = "DESKTOP-67FGBH2"
        txt_databse.Text = "tugasakhir"
        CbSecurity.SelectedIndex = 0
        Txt_username.Text = "sa"
        txt_password.Text = "123456"
        Txt_server.Select()
    End Sub
    Sub menunggu()
        Btn_save.Cursor = Cursors.WaitCursor
        Btn_test.Cursor = Cursors.WaitCursor
        Me.Cursor = Cursors.WaitCursor
        Txt_server.Cursor = Cursors.WaitCursor
        txt_databse.Cursor = Cursors.WaitCursor
        Txt_username.Cursor = Cursors.WaitCursor
        txt_password.Cursor = Cursors.WaitCursor
    End Sub
    Sub aman()
        Btn_save.Cursor = Cursors.Hand
        Btn_test.Cursor = Cursors.Hand
        Me.Cursor = Cursors.Default
        Txt_server.Cursor = Cursors.IBeam
        txt_databse.Cursor = Cursors.IBeam
        Txt_username.Cursor = Cursors.IBeam
        txt_password.Cursor = Cursors.IBeam
    End Sub
    Function ConncetionTest() As Boolean
        ConncetionTest = False
        If Txt_server.Text.Trim = "" Then Txt_server.Focus() : Exit Function
        If txt_databse.Text.Trim = "" Then txt_databse.Focus() : Exit Function
        If Txt_username.Text.Trim = "" Then Txt_username.Focus() : Exit Function
        If txt_password.Text.Trim = "" Then txt_password.Focus() : Exit Function
        If CbSecurity.SelectedIndex = 1 Then
            Query = New String("Server=" & UCase(Txt_server.Text) & "; database=" & UCase(txt_databse.Text) & ";integrated security=true ; pooling='true'; Max Pool Size=250" & "")
        Else
            Query = New String("Server=" & UCase(Txt_server.Text) & "; database=" & UCase(txt_databse.Text) & ";user=" & Txt_username.Text & ";password=" & txt_password.Text & "; pooling='true'; Max Pool Size=250" & "")
        End If
        Dim koneksi As SqlConnection = New SqlConnection(Query)
        Try
            menunggu()
            koneksi.Open()
            koneksi.Close()
            aman()
            ConncetionTest = True
        Catch ex As Exception
            MsgBox("Please check your network, computer client must be connect  with computer server.", MsgBoxStyle.Critical, "Connection failed")
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\temp.txt", vbCrLf & Format(CDate(Now), "yyyy-MM-dd") & " " & Format(CDate(Now), "long time") & vbCrLf & ex.Message.ToString, True)
            aman()
        End Try
        Return ConncetionTest
    End Function
    Private Sub Btn_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_test.Click
        If ConncetionTest() = True Then MsgBox("Connect successfully, please save this configuration!", MsgBoxStyle.Information, "Success message")
    End Sub
    Private Sub Txt_server_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_server.KeyDown
        If e.KeyCode = 13 Then txt_databse.Focus()
    End Sub
    Private Sub txt_databse_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_databse.KeyDown
        If e.KeyCode = 13 Then            Txt_username.Focus()

    End Sub
    Private Sub Txt_username_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_username.KeyDown
        If e.KeyCode = 13 Then            txt_password.Focus()
    End Sub
    Private Sub txt_password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = 13 Then If ConncetionTest() = True Then MsgBox("Connect successfully, please save this configuration!", MsgBoxStyle.Information, "Success Message")
    End Sub

    Private Sub FrmConfigurasiServer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Clo = True Then Exit Sub
        If MsgBox("Are you sure you want to exit ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Message") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmConfigurasiServer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        On Error Resume Next
        Txt_username.Text = New String(L01.Decrypt(SRV.GetValueRegeti("User Name")))
        txt_password.Text = New String(L01.Decrypt(SRV.GetValueRegeti("Password")))
        Txt_server.Text = New String(L01.Decrypt(SRV.GetValueRegeti("Server")))
        txt_databse.Text = New String(L01.Decrypt(SRV.GetValueRegeti("Database")))
        If Txt_username.Text.Trim <> "" Then
            CbSecurity.SelectedIndex = 0
        Else
            CbSecurity.SelectedIndex = 1
        End If
        'If Txt_server.Text.Trim = "" Then CreateText()
    End Sub
    Private Clo As Boolean
    Private Sub Btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_save.Click
        If ConncetionTest() = True Then
            Dim Pesan As String = MsgBox("Are you sure want to keep this configuration?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
            If Pesan = MsgBoxResult.No Then Exit Sub
            My.Computer.Registry.SetValue(Regedit, "Server", L01.Encrypt(Txt_server.Text))
            My.Computer.Registry.SetValue(Regedit, "Database", L01.Encrypt(txt_databse.Text).ToString)
            My.Computer.Registry.SetValue(Regedit, "User Name", L01.Encrypt(Txt_username.Text))
            My.Computer.Registry.SetValue(Regedit, "Password", L01.Encrypt(txt_password.Text))
            My.Computer.Registry.SetValue(Regedit, "Query", L01.Encrypt(Query))
            MsgBox("Configuration has been saved !", MsgBoxStyle.Information, "Configuration message")
            Clo = True
            Close()
        End If
    End Sub
    Private Sub CbSecurity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSecurity.SelectedIndexChanged
        If CbSecurity.SelectedIndex = 1 Then
            GbSecurity.Enabled = False
        Else
            GbSecurity.Enabled = True
            Txt_username.Select()
        End If
    End Sub
End Class
