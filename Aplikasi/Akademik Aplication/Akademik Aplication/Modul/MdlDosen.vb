Module MdlDosen
    Public Sub ComboDosen(ByVal CbFilter As ComboBox)
        CbFilter.Items.Clear()
        CbFilter.Items.Add("Nama")
        CbFilter.Items.Add("NIP")
        CbFilter.Items.Add("Email")
        CbFilter.SelectedIndex = 0
    End Sub
    Public Sub CreateColomDosen(ByVal DgData As DataGridView)
        With DgData
            .Columns.Clear()
            .Columns.Add("1", "No.") : .Columns(0).Width = 30 : .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Add("1", "NIP") : .Columns(1).Width = 130 : .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Add("1", "Nama") : .Columns(2).Width = 350 : .Columns(2).ReadOnly = True
            .Columns.Add("1", "Alamat") : .Columns(3).Width = 350 : .Columns(3).ReadOnly = True
            .Columns.Add("1", "No HP") : .Columns(4).Width = 200 : .Columns(4).ReadOnly = True
            .Columns.Add("1", "Email") : .Columns(5).MinimumWidth = 100 : .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(5).ReadOnly = True
            .Columns.Add("1", "Prodi") : .Columns(6).MinimumWidth = 100 : .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(5).ReadOnly = True

        End With
    End Sub
    Public Sub AddRowDataDosen(ByVal NamaTabel As String, ByVal DgPenjualan As DataGridView)
        DgPenjualan.Rows.Clear()
        For i As Integer = 0 To Service.DTSet.Tables(NamaTabel).Rows.Count - 1
            DgPenjualan.Rows.Add(i + 1, Service.DTSet.Tables(NamaTabel).Rows(i)("nip"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("nama"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("alamat"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("nohp"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("email"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namaProdi"))
            DgPenjualan.Rows(i).Tag = Service.DTSet.Tables(NamaTabel).Rows(i)("nip")
        Next
        On Error Resume Next
        DgPenjualan.CurrentRow.Selected = False
    End Sub

    Public Function dosen() As List(Of List(Of String))
        Service.SqlDaAdapter("select * From tbldosen", "tbldosen")
        Dim result As New List(Of List(Of String))
        result.Add(New List(Of String))
        result.Add(New List(Of String))
        For i As Integer = 0 To Service.DTSet.Tables("tbldosen").Rows.Count - 1
            result.Item(0).Add(Service.DTSet.Tables("tbldosen").Rows(i)("nama"))
            result.Item(1).Add(Service.DTSet.Tables("tbldosen").Rows(i)("nip"))
        Next
        Return result
    End Function
End Module
