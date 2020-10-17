Module MdlLapTA
    Public Sub CreateColomLapTA(ByVal DgData As DataGridView)
        With DgData
            .Columns.Clear()
            .Columns.Add("1", "No.") : .Columns(0).Width = 30 : .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Add("1", "Nama Mahasiswa") : .Columns(1).Width = 200 : .Columns(1).ReadOnly = True
            .Columns.Add("1", "Dosen Pembimbing") : .Columns(2).Width = 150 : .Columns(2).ReadOnly = True
            .Columns.Add("1", "Judul") : .Columns(3).Width = 400 : .Columns(3).ReadOnly = True
            .Columns.Add("1", "Dosen Penguji 1") : .Columns(4).Width = 200 : .Columns(4).ReadOnly = True
            .Columns.Add("1", "Dosen Penguji 2") : .Columns(5).Width = 200 : .Columns(5).ReadOnly = True
            .Columns.Add("1", "Nilai Total") : .Columns(6).MinimumWidth = 100 : .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(6).ReadOnly = True
            .Columns.Add("1", "Tahun") : .Columns(6).MinimumWidth = 100 : .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(6).ReadOnly = True
        End With
    End Sub
    Public Sub AddRowDataLapTA(ByVal NamaTabel As String, ByVal DgPenjualan As DataGridView)
        DgPenjualan.Rows.Clear()
        For i As Integer = 0 To Service.DTSet.Tables(NamaTabel).Rows.Count - 1
            DgPenjualan.Rows.Add(i + 1,
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namamahasiswa"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namadoping"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("judul"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namadosen1"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namadosen2"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("nilaitotal"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("tanggalsidang"))
            DgPenjualan.Rows(i).Tag = Service.DTSet.Tables(NamaTabel).Rows(i)("NIM")
        Next
        On Error Resume Next
        DgPenjualan.CurrentRow.Selected = False
    End Sub
End Module
