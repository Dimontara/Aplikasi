Imports System.Data.SqlClient
Public Class Service
    Public DTSet As New DataSet
    Public StatusKoneksi As Boolean
    Public IP As String = System.Net.Dns.GetHostByName(My.Computer.Name).AddressList(0).ToString()
    Public Reg As String = Regedit
    Private Cmd As SqlCommand
    Private SqlDA As SqlDataAdapter
    Private SqlCMD As SqlCommand
    Public Server, Database, Username, Password As String
    Public Function GetValueRegeti(ByVal Path As String)
        GetValueRegeti = My.Computer.Registry.GetValue(Regedit, Path, "")
        Return GetValueRegeti
    End Function
    Public Sub SetValueRegdit(ByVal Path As String, ByVal Value As String)
        My.Computer.Registry.SetValue(Regedit, Path, Value)
    End Sub
    Function Decrypt() As Boolean
        Try
            Username = New String(L01.Decrypt(GetValueRegeti("User Name")))
            Password = New String(L01.Decrypt(GetValueRegeti("Password")))
            Server = New String(L01.Decrypt(GetValueRegeti("Server")))
            Database = New String(L01.Decrypt(GetValueRegeti("Database")))
            Query = New String(L01.Decrypt(GetValueRegeti("Query")))
            Decrypt = True
        Catch ex As Exception
            Decrypt = False
            MsgBox("Database service is not ready, please configure test !", MsgBoxStyle.Critical, "Please configure")
            FCOnfigurasi.Awal()
        End Try
        Return Decrypt
    End Function
    Public Function OpenKOneksi() As SqlConnection
        Dim Conn As New SqlConnection
        If Decrypt() = True Then
            Conn = New SqlConnection(Query)
            Try
                Conn.Open()
                StatusKoneksi = True
            Catch ex As Exception
                StatusKoneksi = False
                MsgBox("Database service is not ready, please configure !", MsgBoxStyle.Exclamation, "Please configure")
                My.Computer.FileSystem.WriteAllText("temp.txt", vbCrLf & Format(CDate(Now), "yyyy-MM-dd") & " " & Format(CDate(Now), "long time") & vbCrLf & ex.Message.ToString, True)
                FCOnfigurasi.Awal()
            End Try
        Else
            StatusKoneksi = False
        End If
        Return Conn
    End Function
    Public Function nomorotomatis(ByVal PrimaryKey As String, ByVal Tabel As String, ByVal DgitPertama As String, ByVal JumKarakter As Integer) As String
        JumDigitAutoNumber = ""
        SqlDaAdapter("select isnull(right(" & PrimaryKey & "," & JumKarakter & " ),0) as nomor from " & Tabel & " order by " & PrimaryKey & " desc", "NM")
        If DTSet.Tables("NM").Rows.Count = 0 Then
            nomorotomatis = 0
        Else
            nomorotomatis = Format(DTSet.Tables("NM").Rows(0)("nomor"))
        End If
        For i As Integer = 0 To JumKarakter - 1
            JumDigitAutoNumber = JumDigitAutoNumber & 0
        Next
        If DgitPertama.Trim = "" Then
            nomorotomatis = Format(Val(nomorotomatis) + 1, JumDigitAutoNumber)
        Else
            nomorotomatis = DgitPertama & Format(Val(nomorotomatis) + 1, JumDigitAutoNumber)
        End If
        Return nomorotomatis
    End Function
    Public Function ExecuteNonQuery(ByVal Query As String, ByVal Tabel As String, ByVal Kode As String) As Boolean
        SqlCMD = New SqlCommand(Query, OpenKOneksi)
        Try
            SqlCMD.ExecuteNonQuery()
            ExecuteNonQuery = True
            'CreateHistory(Tabel, Kode, Query, "True")
        Catch ex As Exception
            MsgBox("Database can not receive commands from an application1, please try again  !", MsgBoxStyle.Critical, "Error message !")
            CreateHistory(Tabel, Kode, Query, ex.Message.ToString)
            ExecuteNonQuery = False
        End Try
        Return ExecuteNonQuery
    End Function
    Public Function SqlDaAdapter(ByVal Query As String, ByVal Tabel As String) As Boolean
        DTSet.Clear()
        SqlDA = New SqlClient.SqlDataAdapter(Query, OpenKOneksi)
        Try
            SqlDA.Fill(DTSet, (Tabel))
            SqlDaAdapter = True
        Catch ex As Exception
            MsgBox("Database can not receive commands from an application2, please try again  !", MsgBoxStyle.Critical, "Error message !")
            CreateHistory(Tabel, "Tampil", Query, ex.Message.ToString)
            SqlDaAdapter = False
        End Try
        Return SqlDaAdapter
    End Function
    Sub CreateHistory(ByVal Tabel As String, ByVal Kode As String, ByVal Query As String, ByVal Pesan As String)
        Try
            SqlCMD = New SqlCommand("insert into TblMaintenance values('" & nomorotomatis("Kode", "TblMaintenance", "", 20) & "','" & Replace(Tabel, "'", "''") & "','" & Kode & "','" & Format(CDate(Now), "yyyy-MM-dd") & " " & Format(CDate(Now), "long time") & "','" & Replace(Query, "'", "''") & "','" & Replace(My.Computer.Name & "-" & IP, "'", "''") & "','" & Replace(Pesan, "'", "''") & "','" & GetValueRegeti("Operator") & "')", OpenKOneksi)
            SqlCMD.ExecuteNonQuery()
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\temp.txt", vbCrLf & Format(CDate(Now), "yyyy-MM-dd") & " " & Format(CDate(Now), "long time") & vbCrLf & ex.Message.ToString, True)
        End Try
    End Sub
End Class
