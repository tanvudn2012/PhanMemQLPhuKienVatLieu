<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoaiSanPham
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTenloaisanpham = New System.Windows.Forms.TextBox()
        Me.txtMaloaisanpham = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvLoaiSanPham = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvLoaiSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ LOẠI SẢN PHẨM"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTenloaisanpham)
        Me.GroupBox1.Controls.Add(Me.txtMaloaisanpham)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 213)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin loại sản phẩm"
        '
        'txtTenloaisanpham
        '
        Me.txtTenloaisanpham.Location = New System.Drawing.Point(107, 78)
        Me.txtTenloaisanpham.Name = "txtTenloaisanpham"
        Me.txtTenloaisanpham.Size = New System.Drawing.Size(107, 20)
        Me.txtTenloaisanpham.TabIndex = 3
        '
        'txtMaloaisanpham
        '
        Me.txtMaloaisanpham.Location = New System.Drawing.Point(107, 28)
        Me.txtMaloaisanpham.Name = "txtMaloaisanpham"
        Me.txtMaloaisanpham.ReadOnly = True
        Me.txtMaloaisanpham.Size = New System.Drawing.Size(107, 20)
        Me.txtMaloaisanpham.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên loại sản phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã loại sản phẩm"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTimKiem)
        Me.GroupBox2.Controls.Add(Me.btnTimKiem)
        Me.GroupBox2.Controls.Add(Me.btnXoa)
        Me.GroupBox2.Controls.Add(Me.btnSua)
        Me.GroupBox2.Controls.Add(Me.btnThem)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 213)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thao tác"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(23, 141)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(157, 20)
        Me.txtTimKiem.TabIndex = 4
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(23, 167)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(157, 23)
        Me.btnTimKiem.TabIndex = 3
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(23, 92)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(157, 23)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(23, 58)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(157, 23)
        Me.btnSua.TabIndex = 1
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(23, 25)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(157, 23)
        Me.btnThem.TabIndex = 0
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvLoaiSanPham
        '
        Me.dgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoaiSanPham.Location = New System.Drawing.Point(32, 278)
        Me.dgvLoaiSanPham.Name = "dgvLoaiSanPham"
        Me.dgvLoaiSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLoaiSanPham.Size = New System.Drawing.Size(446, 150)
        Me.dgvLoaiSanPham.TabIndex = 3
        '
        'LoaiSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 441)
        Me.Controls.Add(Me.dgvLoaiSanPham)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoaiSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoaiSanPham"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvLoaiSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLoaiSanPham As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTenloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtMaloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents txtTimKiem As System.Windows.Forms.TextBox
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
End Class
