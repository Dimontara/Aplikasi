Module MdlTugasAkhir
    Public Sub ComboTugasAkhir(ByVal CbFilter As ComboBox)
        CbFilter.Items.Clear()
        CbFilter.Items.Add("Judul")
        CbFilter.Items.Add("Nama Mahasiswa")
        CbFilter.Items.Add("Nama Doping")
        CbFilter.SelectedIndex = 0
    End Sub
    Public Sub CreateColomTugasAkhir(ByVal DgData As DataGridView)
        With DgData
            .Columns.Clear()
            .Columns.Add("1", "No.") : .Columns(0).Width = 30 : .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Add("1", "Nama Mahasiswa") : .Columns(1).Width = 350 : .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns.Add("1", "Nama Doping") : .Columns(2).Width = 350 : .Columns(2).ReadOnly = True
            .Columns.Add("1", "Judul") : .Columns(3).Width = 700 : .Columns(3).ReadOnly = True
        End With
    End Sub
    Public Sub AddRowDataTugasAkhir(ByVal NamaTabel As String, ByVal DgPenjualan As DataGridView)
        DgPenjualan.Rows.Clear()
        For i As Integer = 0 To Service.DTSet.Tables(NamaTabel).Rows.Count - 1
            DgPenjualan.Rows.Add(i + 1,
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namamahasiswa"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("namaDosen"),
                                 Service.DTSet.Tables(NamaTabel).Rows(i)("judul"))
            DgPenjualan.Rows(i).Tag = Service.DTSet.Tables(NamaTabel).Rows(i)("NIM")
        Next
        On Error Resume Next
        DgPenjualan.CurrentRow.Selected = False
    End Sub

    Public Function tugasakhir(Optional filter As String = "", Optional column As String = "") As List(Of List(Of String))
        Dim str As String = "select * From vw_tugasakhir"
        If filter <> "" Then
            str = str + " where " + column + " = " + "'" + filter + "'"
        End If
        Service.SqlDaAdapter(str, "tblta")
        Dim result As New List(Of List(Of String))
        result.Add(New List(Of String))
        result.Add(New List(Of String))
        result.Add(New List(Of String))
        For i As Integer = 0 To Service.DTSet.Tables("tblta").Rows.Count - 1
            result.Item(0).Add(Service.DTSet.Tables("tblta").Rows(i)("judul"))
            result.Item(1).Add(Service.DTSet.Tables("tblta").Rows(i)("nim"))
            result.Item(2).Add(Service.DTSet.Tables("tblta").Rows(i)("nipDoping"))
        Next
        Return result
    End Function
End Module
