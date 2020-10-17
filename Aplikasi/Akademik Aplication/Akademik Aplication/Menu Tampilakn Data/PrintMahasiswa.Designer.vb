<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintMahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblMahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tugasakhirDataSet = New Akademik_Aplication.tugasakhirDataSet()
        Me.tblDosenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tugasakhirDataSet1 = New Akademik_Aplication.tugasakhirDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblDosenTableAdapter = New Akademik_Aplication.tugasakhirDataSet1TableAdapters.tblDosenTableAdapter()
        Me.tblMahasiswaTableAdapter = New Akademik_Aplication.tugasakhirDataSetTableAdapters.tblMahasiswaTableAdapter()
        CType(Me.tblMahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tugasakhirDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblDosenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tugasakhirDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblMahasiswaBindingSource
        '
        Me.tblMahasiswaBindingSource.DataMember = "tblMahasiswa"
        Me.tblMahasiswaBindingSource.DataSource = Me.tugasakhirDataSet
        '
        'tugasakhirDataSet
        '
        Me.tugasakhirDataSet.DataSetName = "tugasakhirDataSet"
        Me.tugasakhirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblDosenBindingSource
        '
        Me.tblDosenBindingSource.DataMember = "tblDosen"
        Me.tblDosenBindingSource.DataSource = Me.tugasakhirDataSet1
        '
        'tugasakhirDataSet1
        '
        Me.tugasakhirDataSet1.DataSetName = "tugasakhirDataSet1"
        Me.tugasakhirDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblMahasiswaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Smart_Finance_Aplication.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(988, 337)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblDosenTableAdapter
        '
        Me.tblDosenTableAdapter.ClearBeforeFill = True
        '
        'tblMahasiswaTableAdapter
        '
        Me.tblMahasiswaTableAdapter.ClearBeforeFill = True
        '
        'PrintMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 337)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "PrintMahasiswa"
        Me.Text = "Print2"
        CType(Me.tblMahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tugasakhirDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblDosenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tugasakhirDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblDosenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tugasakhirDataSet1 As Akademik_Aplication.tugasakhirDataSet1
    Friend WithEvents tblDosenTableAdapter As Akademik_Aplication.tugasakhirDataSet1TableAdapters.tblDosenTableAdapter
    Friend WithEvents tblMahasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tugasakhirDataSet As Akademik_Aplication.tugasakhirDataSet
    Friend WithEvents tblMahasiswaTableAdapter As Akademik_Aplication.tugasakhirDataSetTableAdapters.tblMahasiswaTableAdapter
End Class
