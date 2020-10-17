Module MdlNilaiTugasAkhir
    Public Sub ComboNilaiTugasAkhir(ByVal CbFilter As ComboBox)
        CbFilter.Items.Clear()
        CbFilter.Items.Add("Judul")
        CbFilter.SelectedIndex = 0
    End Sub
    Public Sub CreateColomNilaiTugasAkhir(ByVal DgData As DataGridView)
        With DgData
            .Columns.Clear()
            .Columns.Add("1", "No.") : .Columns(0).Width = 30 : .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Add("1", "Nama Mahasiswa") : .Columns(1).Width = 200 : .Columns(1).ReadOnly = True
            .Columns.Add("1", "Judul") : .Columns(2).Width = 400 : .Columns(2).ReadOnly = True
            .Columns.Add("1", "Tanggal Sidang") : .Columns(3).Width = 200 : .Columns(3).ReadOnly = True
            .Columns.Add("1", "Dosen Penguji 1") : .Columns(4).Width = 170 : .Columns(4).ReadOnly = True
            .Columns.Add("1", "Dosen Penguji 2") : .Columns(5).Width = 170 : .Columns(5).ReadOnly = True
            .Columns.Add("1", "Dosen Pembimbing") : .Columns(6).MinimumWidth = 100 : .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(6).ReadOnly = True
            .Columns.Add("1", "Nilai") : .Columns(7).MinimumWidth = 100 : .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(7).ReadOnly = True
        End With
    End Sub
    Public Sub AddRowDataNilaiTugasAkhir(ByVal NamaTabel As String, ByVal DgPenjualan As DataGridView)
        DgPenjualan.Rows.Clear()
        For i As Integer = 0 To Service.DTSet.Tables(NamaTabel).Rows.Count - 1
            DgPenjualan.Rows.Add(i + 1,
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namamahasiswa"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("judul"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("tanggalsidang"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namadosen1"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namadosen2"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namadoping"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("nilaitotal"))
            DgPenjualan.Rows(i).Tag = Service.DTSet.Tables(NamaTabel).Rows(i)("NIM")
        Next
        On Error Resume Next
        DgPenjualan.CurrentRow.Selected = False
    End Sub
End Module
