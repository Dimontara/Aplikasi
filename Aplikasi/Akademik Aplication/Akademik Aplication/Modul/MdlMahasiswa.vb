Module MdlMahasiswa
    Public Sub ComboMahasiswa(ByVal CbFilter As ComboBox)
        CbFilter.Items.Clear()
        CbFilter.Items.Add("Nama")
        CbFilter.Items.Add("NIM")
        CbFilter.Items.Add("Email")
        CbFilter.SelectedIndex = 0
    End Sub
    Public Sub CreateColomMahasiswa(ByVal DgData As DataGridView)
        With DgData
            .Columns.Clear()
            .Columns.Add("1", "No.") : .Columns(0).Width = 30 : .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : .Columns(0).ReadOnly = True
            .Columns.Add("1", "NIM") : .Columns(1).Width = 130 : .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : .Columns(1).ReadOnly = True
            .Columns.Add("1", "Nama") : .Columns(2).Width = 350 : .Columns(2).ReadOnly = True
            .Columns.Add("1", "Alamat") : .Columns(3).Width = 200 : .Columns(3).ReadOnly = True
            .Columns.Add("1", "No HP") : .Columns(4).Width = 150 : .Columns(4).ReadOnly = True
            .Columns.Add("1", "Email") : .Columns(5).MinimumWidth = 100 : .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(5).ReadOnly = True
            .Columns.Add("1", "Prodi") : .Columns(6).MinimumWidth = 100 : .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(6).ReadOnly = True
            .Columns.Add("1", "Tahun Masuk") : .Columns(7).MinimumWidth = 100 : .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(7).ReadOnly = True
        End With
    End Sub
    Public Sub AddRowDataMahasiswa(ByVal NamaTabel As String, ByVal DgPenjualan As DataGridView)
        DgPenjualan.Rows.Clear()
        For i As Integer = 0 To Service.DTSet.Tables(NamaTabel).Rows.Count - 1
            DgPenjualan.Rows.Add(i + 1, Service.DTSet.Tables(NamaTabel).Rows(i)("nim"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("nama"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("alamat"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("nohp"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("email"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namaprodi"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("tahunmasuk"))
            DgPenjualan.Rows(i).Tag = Service.DTSet.Tables(NamaTabel).Rows(i)("nim")
        Next
        On Error Resume Next
        DgPenjualan.CurrentRow.Selected = False
    End Sub

    Public Function mahasiswa() As List(Of List(Of String))
        Service.SqlDaAdapter("select * From tblMahasiswa", "tblMahasiswa")
        Dim result As New List(Of List(Of String))
        result.Add(New List(Of String))
        result.Add(New List(Of String))
        For i As Integer = 0 To Service.DTSet.Tables("tblMahasiswa").Rows.Count - 1
            result.Item(0).Add(Service.DTSet.Tables("tblMahasiswa").Rows(i)("nama"))
            result.Item(1).Add(Service.DTSet.Tables("tblMahasiswa").Rows(i)("nim"))
        Next
        Return result
    End Function
End Module
