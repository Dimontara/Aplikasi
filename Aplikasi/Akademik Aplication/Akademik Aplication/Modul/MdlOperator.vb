Module MdlDataRegu
    Public Sub ComboOperator(ByVal CbFilter As ComboBox)
        CbFilter.Items.Clear()
        CbFilter.Items.Add("Nama Operator")
        CbFilter.Items.Add("Username")
        CbFilter.SelectedIndex = 0
    End Sub
    Public Sub CreateColomOperator(ByVal DgData As DataGridView)
        With DgData
            .Columns.Clear()
            .Columns.Add("1", "No.") : .Columns(0).Width = 40 : .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Add("1", "Nama") : .Columns(1).Width = 100 : .Columns(1).ReadOnly = True
            .Columns.Add("1", "Tanggal Lahir") : .Columns(2).Width = 100 : .Columns(2).ReadOnly = True
            .Columns.Add("1", "Alamat") : .Columns(3).Width = 120 : .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : .Columns(3).ReadOnly = True
            .Columns.Add("1", "No HP") : .Columns(4).MinimumWidth = 100 : .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(4).ReadOnly = True
            .Columns.Add("1", "Email") : .Columns(5).MinimumWidth = 100 : .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(5).ReadOnly = True
            .Columns.Add("1", "User Name") : .Columns(6).MinimumWidth = 100 : .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(6).ReadOnly = True
        End With
    End Sub
    Public Sub AddRowDataOperator(ByVal NamaTabel As String, ByVal DgPenjualan As DataGridView)
        DgPenjualan.Rows.Clear()
        For i As Integer = 0 To Service.DTSet.Tables(NamaTabel).Rows.Count - 1
            DgPenjualan.Rows.Add(i + 1,
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("nama"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("Tgllahir"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("alamat"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("nohp"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("email"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("username"))
            DgPenjualan.Rows(i).Tag = Service.DTSet.Tables(NamaTabel).Rows(i)("iduser")
        Next
        On Error Resume Next
        DgPenjualan.CurrentRow.Selected = False
    End Sub
End Module
