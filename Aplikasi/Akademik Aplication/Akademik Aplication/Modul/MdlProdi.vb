Module MdlProdi
    Public Sub ComboProdi(ByVal CbFilter As ComboBox)
        CbFilter.Items.Clear()
        CbFilter.Items.Add("Nama Prodi")
        CbFilter.Items.Add("Kode Prodi")
        CbFilter.SelectedIndex = 0
    End Sub
    Public Sub CreateColomProdi(ByVal DgData As DataGridView)
        With DgData
            .Columns.Clear()
            .Columns.Add("1", "No.") : .Columns(0).Width = 30 : .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Add("1", "Kode") : .Columns(1).MinimumWidth = 100 : .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(1).ReadOnly = True
            .Columns.Add("1", "Nama Prodi") : .Columns(2).MinimumWidth = 100 : .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(2).ReadOnly = True
        End With
    End Sub
    Public Sub AddRowDataProdi(ByVal NamaTabel As String, ByVal DgPenjualan As DataGridView)
        DgPenjualan.Rows.Clear()
        For i As Integer = 0 To Service.DTSet.Tables(NamaTabel).Rows.Count - 1
            DgPenjualan.Rows.Add(i + 1, Service.DTSet.Tables(NamaTabel).Rows(i)("kodeprodi"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namaprodi"))
            DgPenjualan.Rows(i).Tag = Service.DTSet.Tables(NamaTabel).Rows(i)("kodeprodi")
        Next
        On Error Resume Next
        DgPenjualan.CurrentRow.Selected = False
    End Sub

    Public Function prodi() As List(Of List(Of String))
        Service.SqlDaAdapter("select * From tblprodi", "tblprodi")
        Dim result As New List(Of List(Of String))
        result.Add(New List(Of String))
        result.Add(New List(Of String))
        For i As Integer = 0 To Service.DTSet.Tables("tblprodi").Rows.Count - 1
            result.Item(0).Add(Service.DTSet.Tables("tblprodi").Rows(i)("namaprodi"))
            result.Item(1).Add(Service.DTSet.Tables("tblprodi").Rows(i)("kodeprodi"))
        Next
        Return result
    End Function
End Module
