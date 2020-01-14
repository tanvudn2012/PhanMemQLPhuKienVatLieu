<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Baocaobanhangvb
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
        Me.BaoCaoCacDonHangDaBanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New QLPhuKienVatLieu.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpBatdau = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpKetthuc = New System.Windows.Forms.DateTimePicker()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BaoCaoCacDonHangDaBanTableAdapter = New QLPhuKienVatLieu.DataSet1TableAdapters.BaoCaoCacDonHangDaBanTableAdapter()
        CType(Me.BaoCaoCacDonHangDaBanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BaoCaoCacDonHangDaBanBindingSource
        '
        Me.BaoCaoCacDonHangDaBanBindingSource.DataMember = "BaoCaoCacDonHangDaBan"
        Me.BaoCaoCacDonHangDaBanBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ngày bắt đầu"
        '
        'dtpBatdau
        '
        Me.dtpBatdau.Location = New System.Drawing.Point(118, 7)
        Me.dtpBatdau.Name = "dtpBatdau"
        Me.dtpBatdau.Size = New System.Drawing.Size(200, 20)
        Me.dtpBatdau.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ngày kết thúc"
        '
        'dtpKetthuc
        '
        Me.dtpKetthuc.Location = New System.Drawing.Point(416, 6)
        Me.dtpKetthuc.Name = "dtpKetthuc"
        Me.dtpKetthuc.Size = New System.Drawing.Size(200, 20)
        Me.dtpKetthuc.TabIndex = 3
        '
        'btnXem
        '
        Me.btnXem.Location = New System.Drawing.Point(633, 4)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(75, 23)
        Me.btnXem.TabIndex = 4
        Me.btnXem.Text = "Xem"
        Me.btnXem.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BaoCaoCacDonHangDaBanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "QLPhuKienVatLieu.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 49)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(924, 342)
        Me.ReportViewer1.TabIndex = 5
        '
        'BaoCaoCacDonHangDaBanTableAdapter
        '
        Me.BaoCaoCacDonHangDaBanTableAdapter.ClearBeforeFill = True
        '
        'Baocaobanhangvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 428)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.dtpKetthuc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpBatdau)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Baocaobanhangvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baocaobanhangvb"
        CType(Me.BaoCaoCacDonHangDaBanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpBatdau As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpKetthuc As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BaoCaoCacDonHangDaBanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As QLPhuKienVatLieu.DataSet1
    Friend WithEvents BaoCaoCacDonHangDaBanTableAdapter As QLPhuKienVatLieu.DataSet1TableAdapters.BaoCaoCacDonHangDaBanTableAdapter
End Class
