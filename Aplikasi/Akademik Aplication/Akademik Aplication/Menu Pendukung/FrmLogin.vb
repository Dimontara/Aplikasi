Public Class FrmLogin
    Dim STLOGIN As Boolean
    Dim Uji As Integer
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Service.OpenKOneksi()
        If Service.StatusKoneksi = False Then End
    End Sub

    Sub CekUji()
        If Uji = 2 Then
            MsgBox("Batas login anda telah habis, silahkan coba lain waktu !", MsgBoxStyle.Critical, "Pesan") : End
        Else
            Uji = Uji + 1
        End If

    End Sub
    Sub lOGIN(ByVal Username As String, ByVal Password As String)
        'Try
        If Service.SqlDaAdapter("SELECT * FROM TblOperator WHERE [USERNAME]='" & Replace(Username, "'", "''") & "'", "Username") = True Then
            If Service.DTSet.Tables("Username").Rows.Count = 0 Then CekUji() : MsgBox("Username anda salah!", MsgBoxStyle.Exclamation, "Pesan") : UsernameTextBox.Select() : Exit Sub
            For i As Integer = 0 To Service.DTSet.Tables("Username").Rows.Count - 1
                If UCase(Password) = UCase(Lib02.Decrypt(Service.DTSet.Tables("Username").Rows(i)("password"))) Then
                    'If UCase(Password) = UCase(Service.DTSet.Tables("Username").Rows(i)("password")) Then
                    STLOGIN = False
                    Service.SetValueRegdit("Operator", Service.DTSet.Tables("username").Rows(i)("Iduser"))
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Me.Hide()
                    If FrmMenuUtama.Visible Then
                        FrmMenuUtama.Show()
                    Else
                        FrmMenuUtama.ShowDialog()
                    End If
                    Exit Sub
                End If
            Next
            CekUji()
            MsgBox("Password anda salah!", MsgBoxStyle.Exclamation, "Pesan")
            PasswordTextBox.Select()
        End If
        'Catch ex As Exception
        'CekUji()
        'MsgBox("Password anda salah!", MsgBoxStyle.Exclamation, "Pesan")
        'PasswordTextBox.Select()
        'End Try
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text.Trim = "" Then UsernameTextBox.Select() : Exit Sub
        If PasswordTextBox.Text.Trim = "" Then PasswordTextBox.Select() : Exit Sub
        lOGIN(UsernameTextBox.Text, PasswordTextBox.Text)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        FrmOperator.ShowMenu(True)
    End Sub
End Class
