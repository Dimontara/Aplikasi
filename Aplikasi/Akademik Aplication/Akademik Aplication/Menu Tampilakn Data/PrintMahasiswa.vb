Public Class PrintMahasiswa
    Private Sub Print2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'tugasakhirDataSet.tblMahasiswa' table. You can move, or remove it, as needed.
        Me.tblMahasiswaTableAdapter.Fill(Me.tugasakhirDataSet.tblMahasiswa)
        'TODO: This line of code loads data into the 'tugasakhirDataSet1.tblDosen' table. You can move, or remove it, as needed.
        Me.tblDosenTableAdapter.Fill(Me.tugasakhirDataSet1.tblDosen)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class