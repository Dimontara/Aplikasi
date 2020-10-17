<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintTugasAkhir
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
        Me.tblDosenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tugasakhirDataSet1 = New Akademik_Aplication.tugasakhirDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblDosenTableAdapter = New Akademik_Aplication.tugasakhirDataSet1TableAdapters.tblDosenTableAdapter()
        Me.tugasakhirDataSet2 = New Akademik_Aplication.tugasakhirDataSet2()
        Me.vw_nilaitugasAkhirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.vw_nilaitugasAkhirTableAdapter = New Akademik_Aplication.tugasakhirDataSet2TableAdapters.vw_nilaitugasAkhirTableAdapter()
        CType(Me.tblDosenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tugasakhirDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tugasakhirDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vw_nilaitugasAkhirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        ReportDataSource1.Value = Me.vw_nilaitugasAkhirBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Smart_Finance_Aplication.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(988, 337)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblDosenTableAdapter
        '
        Me.tblDosenTableAdapter.ClearBeforeFill = True
        '
        'tugasakhirDataSet2
        '
        Me.tugasakhirDataSet2.DataSetName = "tugasakhirDataSet2"
        Me.tugasakhirDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vw_nilaitugasAkhirBindingSource
        '
        Me.vw_nilaitugasAkhirBindingSource.DataMember = "vw_nilaitugasAkhir"
        Me.vw_nilaitugasAkhirBindingSource.DataSource = Me.tugasakhirDataSet2
        '
        'vw_nilaitugasAkhirTableAdapter
        '
        Me.vw_nilaitugasAkhirTableAdapter.ClearBeforeFill = True
        '
        'PrintTugasAkhir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 337)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "PrintTugasAkhir"
        Me.Text = "Print2"
        CType(Me.tblDosenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tugasakhirDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tugasakhirDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vw_nilaitugasAkhirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblDosenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tugasakhirDataSet1 As Akademik_Aplication.tugasakhirDataSet1
    Friend WithEvents tblDosenTableAdapter As Akademik_Aplication.tugasakhirDataSet1TableAdapters.tblDosenTableAdapter
    Friend WithEvents vw_nilaitugasAkhirBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tugasakhirDataSet2 As Akademik_Aplication.tugasakhirDataSet2
    Friend WithEvents vw_nilaitugasAkhirTableAdapter As Akademik_Aplication.tugasakhirDataSet2TableAdapters.vw_nilaitugasAkhirTableAdapter
End Class
