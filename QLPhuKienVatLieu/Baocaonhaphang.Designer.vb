<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baocaonhaphang
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpBatdau = New System.Windows.Forms.DateTimePicker()
        Me.dtpKetthuc = New System.Windows.Forms.DateTimePicker()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.DataSet1 = New QLPhuKienVatLieu.DataSet1()
        Me.BaoCaoNhapKhoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaoCaoNhapKhoTableAdapter = New QLPhuKienVatLieu.DataSet1TableAdapters.BaoCaoNhapKhoTableAdapter()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaoCaoNhapKhoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.BaoCaoNhapKhoBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "QLPhuKienVatLieu.Report2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(23, 44)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(668, 353)
        Me.ReportViewer2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ngày bắt đầu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ngày kết thúc"
        '
        'dtpBatdau
        '
        Me.dtpBatdau.Location = New System.Drawing.Point(101, 7)
        Me.dtpBatdau.Name = "dtpBatdau"
        Me.dtpBatdau.Size = New System.Drawing.Size(200, 20)
        Me.dtpBatdau.TabIndex = 3
        '
        'dtpKetthuc
        '
        Me.dtpKetthuc.Location = New System.Drawing.Point(397, 7)
        Me.dtpKetthuc.Name = "dtpKetthuc"
        Me.dtpKetthuc.Size = New System.Drawing.Size(200, 20)
        Me.dtpKetthuc.TabIndex = 4
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(604, 8)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(87, 23)
        Me.btnXem.TabIndex = 5
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BaoCaoNhapKhoBindingSource
        '
        Me.BaoCaoNhapKhoBindingSource.DataMember = "BaoCaoNhapKho"
        Me.BaoCaoNhapKhoBindingSource.DataSource = Me.DataSet1
        '
        'BaoCaoNhapKhoTableAdapter
        '
        Me.BaoCaoNhapKhoTableAdapter.ClearBeforeFill = True
        '
        'Baocaonhaphang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 409)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.dtpKetthuc)
        Me.Controls.Add(Me.dtpBatdau)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Name = "Baocaonhaphang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baocaonhaphang"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaoCaoNhapKhoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpBatdau As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpKetthuc As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents BaoCaoNhapKhoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As QLPhuKienVatLieu.DataSet1
    Friend WithEvents BaoCaoNhapKhoTableAdapter As QLPhuKienVatLieu.DataSet1TableAdapters.BaoCaoNhapKhoTableAdapter
End Class
