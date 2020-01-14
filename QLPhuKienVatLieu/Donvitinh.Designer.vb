<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donvitinh
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTendonvitinh = New System.Windows.Forms.TextBox()
        Me.txtMadonvitinh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTimkiem = New System.Windows.Forms.Button()
        Me.txtTimkiem = New System.Windows.Forms.TextBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.dgvDonvitinh = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDonvitinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ ĐƠN VỊ TÍNH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã đơn vị tính"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTendonvitinh)
        Me.GroupBox1.Controls.Add(Me.txtMadonvitinh)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnThem)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 144)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin đơn vị tính"
        '
        'txtTendonvitinh
        '
        Me.txtTendonvitinh.Location = New System.Drawing.Point(111, 60)
        Me.txtTendonvitinh.Name = "txtTendonvitinh"
        Me.txtTendonvitinh.Size = New System.Drawing.Size(134, 20)
        Me.txtTendonvitinh.TabIndex = 4
        '
        'txtMadonvitinh
        '
        Me.txtMadonvitinh.Location = New System.Drawing.Point(111, 26)
        Me.txtMadonvitinh.Name = "txtMadonvitinh"
        Me.txtMadonvitinh.ReadOnly = True
        Me.txtMadonvitinh.Size = New System.Drawing.Size(107, 20)
        Me.txtMadonvitinh.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên đơn vị tính"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(111, 86)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(134, 23)
        Me.btnThem.TabIndex = 0
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTimkiem)
        Me.GroupBox2.Controls.Add(Me.txtTimkiem)
        Me.GroupBox2.Controls.Add(Me.btnXoa)
        Me.GroupBox2.Controls.Add(Me.btnSua)
        Me.GroupBox2.Location = New System.Drawing.Point(342, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 144)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thao tác"
        '
        'btnTimkiem
        '
        Me.btnTimkiem.Location = New System.Drawing.Point(21, 107)
        Me.btnTimkiem.Name = "btnTimkiem"
        Me.btnTimkiem.Size = New System.Drawing.Size(125, 23)
        Me.btnTimkiem.TabIndex = 4
        Me.btnTimkiem.Text = "Tìm kiếm"
        Me.btnTimkiem.UseVisualStyleBackColor = True
        '
        'txtTimkiem
        '
        Me.txtTimkiem.Location = New System.Drawing.Point(21, 81)
        Me.txtTimkiem.Name = "txtTimkiem"
        Me.txtTimkiem.Size = New System.Drawing.Size(125, 20)
        Me.txtTimkiem.TabIndex = 3
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(21, 48)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(125, 23)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(21, 19)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(125, 23)
        Me.btnSua.TabIndex = 1
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'dgvDonvitinh
        '
        Me.dgvDonvitinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDonvitinh.Location = New System.Drawing.Point(13, 220)
        Me.dgvDonvitinh.Name = "dgvDonvitinh"
        Me.dgvDonvitinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDonvitinh.Size = New System.Drawing.Size(495, 150)
        Me.dgvDonvitinh.TabIndex = 4
        '
        'Donvitinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 389)
        Me.Controls.Add(Me.dgvDonvitinh)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Donvitinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donvitinh"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDonvitinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTendonvitinh As System.Windows.Forms.TextBox
    Friend WithEvents txtMadonvitinh As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents txtTimkiem As System.Windows.Forms.TextBox
    Friend WithEvents btnTimkiem As System.Windows.Forms.Button
    Friend WithEvents dgvDonvitinh As System.Windows.Forms.DataGridView
End Class
