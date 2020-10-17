Module MdlPendukung
    Public Lib01 As New LibraryProc.Numeric
    Public Lib02 As New LibraryProc.Security
    Public Service As New Service_Application.Service
    Private listData As List(Of String)
    Public IndexformPendukung As Integer
    Public formActiveName As String

    Function Konfirmasi(ByVal JenisKonfirmasi As String)
        If MsgBox("Benarkah data ini akan di " & JenisKonfirmasi & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Konfirmasi = True
        Else
            Konfirmasi = False
        End If
        Return Konfirmasi
    End Function

    Public Sub getallforms(ByVal sender As Object)
        Dim Forms As New List(Of Form)()
        Dim formType As Type = Type.GetType("System.Windows.Forms.Form")
        For Each t As Type In sender.GetType().Assembly.GetTypes()
            If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then
                MsgBox(t.Name)
            End If
        Next
    End Sub

    Public Sub AnimasiTombol(ByVal Tombol As PictureBox, ByVal S_X As Integer, ByVal S_Y As Integer)
        Tombol.Size = New Point(S_X, S_Y)
    End Sub
End Module
