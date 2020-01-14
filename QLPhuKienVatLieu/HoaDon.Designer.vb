<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HoaDon
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
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.dgvHoadon = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTaomoikhachhang = New System.Windows.Forms.Button()
        Me.btnTaomoi = New System.Windows.Forms.Button()
        Me.dtpNgaylaphd = New System.Windows.Forms.DateTimePicker()
        Me.cbMakh = New System.Windows.Forms.ComboBox()
        Me.txtMahd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTongtien = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ThoatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbMasp = New System.Windows.Forms.ComboBox()
        Me.txtThanhtien = New System.Windows.Forms.TextBox()
        Me.txtDongia = New System.Windows.Forms.TextBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvChitiethoadon = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvHoadon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvChitiethoadon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(323, 511)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(474, 27)
        Me.btnXoa.TabIndex = 23
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(129, 217)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(136, 32)
        Me.btnThem.TabIndex = 24
        Me.btnThem.Text = "Thêm "
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'dgvHoadon
        '
        Me.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoadon.Location = New System.Drawing.Point(320, 33)
        Me.dgvHoadon.Name = "dgvHoadon"
        Me.dgvHoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHoadon.Size = New System.Drawing.Size(483, 217)
        Me.dgvHoadon.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTaomoikhachhang)
        Me.GroupBox1.Controls.Add(Me.btnTaomoi)
        Me.GroupBox1.Controls.Add(Me.dtpNgaylaphd)
        Me.GroupBox1.Controls.Add(Me.cbMakh)
        Me.GroupBox1.Controls.Add(Me.txtMahd)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 223)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hóa Đơn"
        '
        'btnTaomoikhachhang
        '
        Me.btnTaomoikhachhang.Location = New System.Drawing.Point(129, 103)
        Me.btnTaomoikhachhang.Name = "btnTaomoikhachhang"
        Me.btnTaomoikhachhang.Size = New System.Drawing.Size(136, 23)
        Me.btnTaomoikhachhang.TabIndex = 6
        Me.btnTaomoikhachhang.Text = "Tạo mới khách hàng"
        Me.btnTaomoikhachhang.UseVisualStyleBackColor = True
        '
        'btnTaomoi
        '
        Me.btnTaomoi.Location = New System.Drawing.Point(129, 179)
        Me.btnTaomoi.Name = "btnTaomoi"
        Me.btnTaomoi.Size = New System.Drawing.Size(136, 23)
        Me.btnTaomoi.TabIndex = 5
        Me.btnTaomoi.Text = "Tạo mới hóa đơn"
        Me.btnTaomoi.UseVisualStyleBackColor = True
        '
        'dtpNgaylaphd
        '
        Me.dtpNgaylaphd.CustomFormat = "yyyy-MM-dd"
        Me.dtpNgaylaphd.Enabled = False
        Me.dtpNgaylaphd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaylaphd.Location = New System.Drawing.Point(129, 138)
        Me.dtpNgaylaphd.Name = "dtpNgaylaphd"
        Me.dtpNgaylaphd.Size = New System.Drawing.Size(136, 20)
        Me.dtpNgaylaphd.TabIndex = 4
        '
        'cbMakh
        '
        Me.cbMakh.FormattingEnabled = True
        Me.cbMakh.Location = New System.Drawing.Point(129, 75)
        Me.cbMakh.Name = "cbMakh"
        Me.cbMakh.Size = New System.Drawing.Size(136, 21)
        Me.cbMakh.TabIndex = 2
        '
        'txtMahd
        '
        Me.txtMahd.Location = New System.Drawing.Point(129, 13)
        Me.txtMahd.Name = "txtMahd"
        Me.txtMahd.ReadOnly = True
        Me.txtMahd.Size = New System.Drawing.Size(136, 20)
        Me.txtMahd.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Ngày lập "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã Khách hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hóa đơn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(768, 489)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "VNĐ"
        '
        'txtTongtien
        '
        Me.txtTongtien.Location = New System.Drawing.Point(668, 486)
        Me.txtTongtien.Name = "txtTongtien"
        Me.txtTongtien.ReadOnly = True
        Me.txtTongtien.Size = New System.Drawing.Size(94, 20)
        Me.txtTongtien.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(550, 493)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tổng tiền"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoatToolStripMenuItem, Me.TrợGiúpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(815, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ThoatToolStripMenuItem
        '
        Me.ThoatToolStripMenuItem.Image = Global.QLPhuKienVatLieu.My.Resources.Resources.tải_xuống
        Me.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem"
        Me.ThoatToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ThoatToolStripMenuItem.Text = "Thoat"
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.Image = Global.QLPhuKienVatLieu.My.Resources.Resources.tải_xuống__13_
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ giúp"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbMasp)
        Me.GroupBox2.Controls.Add(Me.txtThanhtien)
        Me.GroupBox2.Controls.Add(Me.btnThem)
        Me.GroupBox2.Controls.Add(Me.txtDongia)
        Me.GroupBox2.Controls.Add(Me.txtSoluong)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 273)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chi tiết hóa đơn"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(229, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "VNĐ"
        '
        'cbMasp
        '
        Me.cbMasp.FormattingEnabled = True
        Me.cbMasp.Location = New System.Drawing.Point(129, 19)
        Me.cbMasp.Name = "cbMasp"
        Me.cbMasp.Size = New System.Drawing.Size(136, 21)
        Me.cbMasp.TabIndex = 2
        '
        'txtThanhtien
        '
        Me.txtThanhtien.Location = New System.Drawing.Point(129, 179)
        Me.txtThanhtien.Name = "txtThanhtien"
        Me.txtThanhtien.ReadOnly = True
        Me.txtThanhtien.Size = New System.Drawing.Size(94, 20)
        Me.txtThanhtien.TabIndex = 1
        '
        'txtDongia
        '
        Me.txtDongia.Location = New System.Drawing.Point(129, 119)
        Me.txtDongia.Name = "txtDongia"
        Me.txtDongia.ReadOnly = True
        Me.txtDongia.Size = New System.Drawing.Size(136, 20)
        Me.txtDongia.TabIndex = 1
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(129, 75)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(136, 20)
        Me.txtSoluong.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Thành tiền"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Đơn giá"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Số lượng"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Mã sản phẩm"
        '
        'dgvChitiethoadon
        '
        Me.dgvChitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChitiethoadon.Location = New System.Drawing.Point(323, 258)
        Me.dgvChitiethoadon.Name = "dgvChitiethoadon"
        Me.dgvChitiethoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChitiethoadon.Size = New System.Drawing.Size(480, 222)
        Me.dgvChitiethoadon.TabIndex = 19
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'HoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 560)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.txtTongtien)
        Me.Controls.Add(Me.dgvChitiethoadon)
        Me.Controls.Add(Me.dgvHoadon)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "HoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HoaDon"
        CType(Me.dgvHoadon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvChitiethoadon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents dgvHoadon As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMahd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ThoatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtThanhtien As System.Windows.Forms.TextBox
    Friend WithEvents txtDongia As System.Windows.Forms.TextBox
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpNgaylaphd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvChitiethoadon As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTongtien As System.Windows.Forms.TextBox
    Friend WithEvents btnTaomoi As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnTaomoikhachhang As System.Windows.Forms.Button
    Public WithEvents cbMasp As System.Windows.Forms.ComboBox
    Public WithEvents cbMakh As System.Windows.Forms.ComboBox
End Class
