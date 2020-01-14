<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanPham
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
        Me.dgvSanpham = New System.Windows.Forms.DataGridView()
        Me.cbMadonvitinh = New System.Windows.Forms.ComboBox()
        Me.cbMaloaisanpham = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDongiaban = New System.Windows.Forms.TextBox()
        Me.txtSoluongton = New System.Windows.Forms.TextBox()
        Me.txtTensanpham = New System.Windows.Forms.TextBox()
        Me.txtMasp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTimkiem = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnTimkiem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnThemloaisanpham = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnTaodonvitinh = New System.Windows.Forms.Button()
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSanpham
        '
        Me.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanpham.Location = New System.Drawing.Point(7, 278)
        Me.dgvSanpham.Name = "dgvSanpham"
        Me.dgvSanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSanpham.Size = New System.Drawing.Size(693, 203)
        Me.dgvSanpham.TabIndex = 0
        '
        'cbMadonvitinh
        '
        Me.cbMadonvitinh.DisplayMember = "DonViTinh.MaDVT"
        Me.cbMadonvitinh.FormattingEnabled = True
        Me.cbMadonvitinh.Location = New System.Drawing.Point(98, 162)
        Me.cbMadonvitinh.Name = "cbMadonvitinh"
        Me.cbMadonvitinh.Size = New System.Drawing.Size(224, 21)
        Me.cbMadonvitinh.TabIndex = 12
        Me.cbMadonvitinh.ValueMember = "DonViTinh.MaDVT"
        '
        'cbMaloaisanpham
        '
        Me.cbMaloaisanpham.DisplayMember = "LoaiSanPham.MaLoai"
        Me.cbMaloaisanpham.FormattingEnabled = True
        Me.cbMaloaisanpham.Location = New System.Drawing.Point(98, 84)
        Me.cbMaloaisanpham.Name = "cbMaloaisanpham"
        Me.cbMaloaisanpham.Size = New System.Drawing.Size(224, 21)
        Me.cbMaloaisanpham.TabIndex = 12
        Me.cbMaloaisanpham.ValueMember = "LoaiSanPham.MaLoai"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(212, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(305, 24)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "QUẢN LÝ THÔNG TIN SẢN PHẨM"
        '
        'txtDongiaban
        '
        Me.txtDongiaban.Location = New System.Drawing.Point(98, 191)
        Me.txtDongiaban.Name = "txtDongiaban"
        Me.txtDongiaban.Size = New System.Drawing.Size(224, 20)
        Me.txtDongiaban.TabIndex = 1
        '
        'txtSoluongton
        '
        Me.txtSoluongton.Location = New System.Drawing.Point(98, 119)
        Me.txtSoluongton.Name = "txtSoluongton"
        Me.txtSoluongton.ReadOnly = True
        Me.txtSoluongton.Size = New System.Drawing.Size(224, 20)
        Me.txtSoluongton.TabIndex = 1
        '
        'txtTensanpham
        '
        Me.txtTensanpham.Location = New System.Drawing.Point(98, 56)
        Me.txtTensanpham.Name = "txtTensanpham"
        Me.txtTensanpham.Size = New System.Drawing.Size(349, 20)
        Me.txtTensanpham.TabIndex = 1
        '
        'txtMasp
        '
        Me.txtMasp.Location = New System.Drawing.Point(98, 25)
        Me.txtMasp.Name = "txtMasp"
        Me.txtMasp.ReadOnly = True
        Me.txtMasp.Size = New System.Drawing.Size(161, 20)
        Me.txtMasp.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Đơn giá"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Đơn vị tính"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTimkiem)
        Me.GroupBox3.Controls.Add(Me.btnThem)
        Me.GroupBox3.Controls.Add(Me.btnTimkiem)
        Me.GroupBox3.Controls.Add(Me.btnXoa)
        Me.GroupBox3.Controls.Add(Me.btnSua)
        Me.GroupBox3.Location = New System.Drawing.Point(500, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 222)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thao tác"
        '
        'txtTimkiem
        '
        Me.txtTimkiem.Location = New System.Drawing.Point(20, 143)
        Me.txtTimkiem.Name = "txtTimkiem"
        Me.txtTimkiem.Size = New System.Drawing.Size(158, 20)
        Me.txtTimkiem.TabIndex = 18
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(20, 19)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(158, 32)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "Thêm "
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnTimkiem
        '
        Me.btnTimkiem.Location = New System.Drawing.Point(20, 173)
        Me.btnTimkiem.Name = "btnTimkiem"
        Me.btnTimkiem.Size = New System.Drawing.Size(158, 32)
        Me.btnTimkiem.TabIndex = 14
        Me.btnTimkiem.Text = "Tìm Kiếm"
        Me.btnTimkiem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(20, 57)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(158, 32)
        Me.btnXoa.TabIndex = 16
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(20, 100)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(158, 32)
        Me.btnSua.TabIndex = 15
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tên loại"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Số lượng tồn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã sản phẩm"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTaodonvitinh)
        Me.GroupBox1.Controls.Add(Me.btnThemloaisanpham)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbMadonvitinh)
        Me.GroupBox1.Controls.Add(Me.cbMaloaisanpham)
        Me.GroupBox1.Controls.Add(Me.txtDongiaban)
        Me.GroupBox1.Controls.Add(Me.txtSoluongton)
        Me.GroupBox1.Controls.Add(Me.txtTensanpham)
        Me.GroupBox1.Controls.Add(Me.txtMasp)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 221)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Sản Phẩm"
        '
        'btnThemloaisanpham
        '
        Me.btnThemloaisanpham.Location = New System.Drawing.Point(325, 82)
        Me.btnThemloaisanpham.Name = "btnThemloaisanpham"
        Me.btnThemloaisanpham.Size = New System.Drawing.Size(122, 23)
        Me.btnThemloaisanpham.TabIndex = 14
        Me.btnThemloaisanpham.Text = "Thêm loại sản phẩm"
        Me.btnThemloaisanpham.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(95, 146)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(240, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Thêm mới sản phẩm thì số lượng tồn ban đầu là 0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(513, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 108)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông Tin Sản Phẩm"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(98, 154)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(199, 20)
        Me.TextBox6.TabIndex = 1
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(98, 123)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(199, 20)
        Me.TextBox7.TabIndex = 1
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(98, 87)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(199, 20)
        Me.TextBox8.TabIndex = 1
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(98, 56)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(199, 20)
        Me.TextBox9.TabIndex = 1
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(98, 25)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(199, 20)
        Me.TextBox10.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Đơn giá"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Đơn vị tính"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tên loại"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Tên sản phẩm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Mã sản phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên sản phẩm"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Location = New System.Drawing.Point(322, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "VNĐ"
        '
        'btnTaodonvitinh
        '
        Me.btnTaodonvitinh.Location = New System.Drawing.Point(329, 162)
        Me.btnTaodonvitinh.Name = "btnTaodonvitinh"
        Me.btnTaodonvitinh.Size = New System.Drawing.Size(118, 23)
        Me.btnTaodonvitinh.TabIndex = 15
        Me.btnTaodonvitinh.Text = "Tạo đơn vị tính"
        Me.btnTaodonvitinh.UseVisualStyleBackColor = True
        '
        'SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 493)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvSanpham)
        Me.Name = "SanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SanPham"
        CType(Me.dgvSanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSanpham As System.Windows.Forms.DataGridView
    Friend WithEvents cbMadonvitinh As System.Windows.Forms.ComboBox
    Friend WithEvents cbMaloaisanpham As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDongiaban As System.Windows.Forms.TextBox
    Friend WithEvents txtSoluongton As System.Windows.Forms.TextBox
    Friend WithEvents txtTensanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtMasp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTimkiem As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnTimkiem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnThemloaisanpham As System.Windows.Forms.Button
    Friend WithEvents btnTaodonvitinh As System.Windows.Forms.Button
End Class
