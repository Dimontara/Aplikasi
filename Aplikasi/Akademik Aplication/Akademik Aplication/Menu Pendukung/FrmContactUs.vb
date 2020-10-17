Imports System.Net.Mail
Public Class FrmContactUs
    Sub Menunggu()
        Me.Cursor = Cursors.WaitCursor
        BtnSend.Cursor = Cursors.WaitCursor
    End Sub
    Sub aktif()
        Me.Cursor = Cursors.Default
        BtnSend.Cursor = Cursors.Hand
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSend.Click
        If TxtName.Text.Trim = "" Then MsgBox("Name can not blank !", MsgBoxStyle.Exclamation, "Message") : TxtName.Select() : Exit Sub
        If TxtEmail.Text.Trim = "" Then MsgBox("Email can not blank !", MsgBoxStyle.Exclamation, "Message") : TxtEmail.Select() : Exit Sub
        If TxtNoHp.Text.Trim = "" Then MsgBox("Phone no can not blank !", MsgBoxStyle.Exclamation, "Message") : TxtNoHp.Select() : Exit Sub
        If TxtPesan.Text.Trim = "" Then MsgBox("Message can not blank !", MsgBoxStyle.Exclamation, "Message") : TxtPesan.Select() : Exit Sub
        Dim Pesan As String = MsgBox("Are you sure you want to send this message ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Message confirmation")
        If Pesan = MsgBoxResult.Yes Then
            Menunggu()
            If SendBack() = False Then aktif() : TxtEmail.Select() : Exit Sub
            Dim smtpServer As New SmtpClient()
            Dim mail As New MailMessage
            smtpServer.Credentials = New Net.NetworkCredential(TextBox1.Text & "@gmail.com", TextBox2.Text)
            smtpServer.Port = 587
            smtpServer.Host = "smtp.gmail.com"
            smtpServer.EnableSsl = True
            mail.From = New MailAddress(TextBox1.Text & "@gmail.com")
            If RadioButton1.Checked = True Then
                mail.To.Add("91" & TextBox3.Text & "@m3m.in")
            ElseIf RadioButton2.Checked = True Then
                mail.To.Add(TextBox3.Text)
            End If
            mail.Subject = TextBox4.Text
            mail.Body = "Name : " & TxtName.Text & " Email : " & TxtEmail.Text & "  Pesan : " & TxtPesan.Text()
            smtpServer.Send(mail)
            Awal()
            aktif()
            MsgBox("Your message has been sent successfully. Thanks !", MsgBoxStyle.Information, "Message")
        End If
    End Sub
    Function SendBack() As Boolean
        SendBack = True
        Try
            Dim smtpServer As New SmtpClient()
            Dim mail As New MailMessage
            smtpServer.Credentials = New Net.NetworkCredential(TextBox1.Text & "@gmail.com", TextBox2.Text)
            smtpServer.Port = 587
            smtpServer.Host = "smtp.gmail.com"
            smtpServer.EnableSsl = True
            mail.From = New MailAddress(TextBox1.Text & "@gmail.com")
            mail.To.Add(TxtEmail.Text)
            mail.Subject = My.Application.Info.AssemblyName
            mail.Body = "Your message has been sent successfully."
            smtpServer.Send(mail)
        Catch ex As Exception
            SendBack = False
            MsgBox("Please check your email !", MsgBoxStyle.Exclamation, "Message")
        End Try
        Return SendBack
    End Function
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox3.Enabled = True
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox3.Enabled = True
    End Sub
    Sub Awal()
        TxtName.Clear()
        TxtNoHp.Clear()
        TxtEmail.Clear()
        TxtPesan.Clear()
        TxtName.Select()
    End Sub
    Private Sub FrmContactUs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
    Private Sub FrmContactUs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton2.Checked = True
        Awal()
    End Sub
    Private Sub TxtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtName.KeyDown
        If e.KeyCode = 13 Then TxtEmail.Select()
    End Sub
    Private Sub TxtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.TextChanged
        TextBox4.Text = TxtName.Text
    End Sub
    Private Sub TxtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmail.KeyDown
        If e.KeyCode = 13 Then TxtNoHp.Select()
    End Sub
    Private Sub TxtNoHp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNoHp.KeyDown
        If e.KeyCode = 13 Then TxtPesan.Select()
    End Sub
End Class
