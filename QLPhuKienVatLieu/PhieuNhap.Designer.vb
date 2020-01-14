<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhieuNhap
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
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbMancc = New System.Windows.Forms.ComboBox()
        Me.ThoatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDongianhap = New System.Windows.Forms.TextBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbMasp = New System.Windows.Forms.ComboBox()
        Me.btnTaomoisanpham = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtThanhtien = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dgvPhieunhap = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTaomoinhacungcap = New System.Windows.Forms.Button()
        Me.btnTaomoi = New System.Windows.Forms.Button()
        Me.dtpNgaylap = New System.Windows.Forms.DateTimePicker()
        Me.dgvPhieunhapchitiet = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMapn = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTongtien = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPhieunhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPhieunhapchitiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.Image = Global.QLPhuKienVatLieu.My.Resources.Resources.tải_xuống__13_
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ giúp"
        '
        'cbMancc
        '
        Me.cbMancc.FormattingEnabled = True
        Me.cbMancc.Location = New System.Drawing.Point(129, 27)
        Me.cbMancc.Name = "cbMancc"
        Me.cbMancc.Size = New System.Drawing.Size(136, 21)
        Me.cbMancc.TabIndex = 2
        '
        'ThoatToolStripMenuItem
        '
        Me.ThoatToolStripMenuItem.Image = Global.QLPhuKienVatLieu.My.Resources.Resources.tải_xuống
        Me.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem"
        Me.ThoatToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ThoatToolStripMenuItem.Text = "Thoat"
        '
        'txtDongianhap
        '
        Me.txtDongianhap.Location = New System.Drawing.Point(129, 139)
        Me.txtDongianhap.Name = "txtDongianhap"
        Me.txtDongianhap.Size = New System.Drawing.Size(136, 20)
        Me.txtDongianhap.TabIndex = 1
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(129, 82)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(136, 20)
        Me.txtSoluong.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbMasp)
        Me.GroupBox2.Controls.Add(Me.btnTaomoisanpham)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtThanhtien)
        Me.GroupBox2.Controls.Add(Me.txtDongianhap)
        Me.GroupBox2.Controls.Add(Me.txtSoluong)
        Me.GroupBox2.Controls.Add(Me.btnThem)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 240)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chi tiết phiếu nhập"
        '
        'cbMasp
        '
        Me.cbMasp.FormattingEnabled = True
        Me.cbMasp.Location = New System.Drawing.Point(129, 16)
        Me.cbMasp.Name = "cbMasp"
        Me.cbMasp.Size = New System.Drawing.Size(136, 21)
        Me.cbMasp.TabIndex = 37
        '
        'btnTaomoisanpham
        '
        Me.btnTaomoisanpham.Location = New System.Drawing.Point(129, 48)
        Me.btnTaomoisanpham.Name = "btnTaomoisanpham"
        Me.btnTaomoisanpham.Size = New System.Drawing.Size(136, 23)
        Me.btnTaomoisanpham.TabIndex = 36
        Me.btnTaomoisanpham.Text = "Tạo mới sản phẩm"
        Me.btnTaomoisanpham.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Thành tiền"
        '
        'txtThanhtien
        '
        Me.txtThanhtien.Location = New System.Drawing.Point(129, 172)
        Me.txtThanhtien.Name = "txtThanhtien"
        Me.txtThanhtien.ReadOnly = True
        Me.txtThanhtien.Size = New System.Drawing.Size(136, 20)
        Me.txtThanhtien.TabIndex = 33
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(129, 205)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(136, 22)
        Me.btnThem.TabIndex = 32
        Me.btnThem.Text = "Thêm "
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Đơn giá nhập"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Số lượng nhập"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Tên sản phẩm"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoatToolStripMenuItem, Me.TrợGiúpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(332, 446)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(449, 22)
        Me.btnXoa.TabIndex = 31
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'dgvPhieunhap
        '
        Me.dgvPhieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieunhap.Location = New System.Drawing.Point(332, 39)
        Me.dgvPhieunhap.Name = "dgvPhieunhap"
        Me.dgvPhieunhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPhieunhap.Size = New System.Drawing.Size(449, 160)
        Me.dgvPhieunhap.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mã nhà cung cấp"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Ngày nhập"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTaomoinhacungcap)
        Me.GroupBox1.Controls.Add(Me.btnTaomoi)
        Me.GroupBox1.Controls.Add(Me.dtpNgaylap)
        Me.GroupBox1.Controls.Add(Me.cbMancc)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 160)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Phiếu Nhập"
        '
        'btnTaomoinhacungcap
        '
        Me.btnTaomoinhacungcap.Location = New System.Drawing.Point(129, 55)
        Me.btnTaomoinhacungcap.Name = "btnTaomoinhacungcap"
        Me.btnTaomoinhacungcap.Size = New System.Drawing.Size(136, 23)
        Me.btnTaomoinhacungcap.TabIndex = 5
        Me.btnTaomoinhacungcap.Text = "Tạo mới nhà cung cấp"
        Me.btnTaomoinhacungcap.UseVisualStyleBackColor = True
        '
        'btnTaomoi
        '
        Me.btnTaomoi.Location = New System.Drawing.Point(129, 126)
        Me.btnTaomoi.Name = "btnTaomoi"
        Me.btnTaomoi.Size = New System.Drawing.Size(136, 23)
        Me.btnTaomoi.TabIndex = 4
        Me.btnTaomoi.Text = "Tạo mới phiếu nhập"
        Me.btnTaomoi.UseVisualStyleBackColor = True
        '
        'dtpNgaylap
        '
        Me.dtpNgaylap.CustomFormat = "yyyy-MM-dd"
        Me.dtpNgaylap.Enabled = False
        Me.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaylap.Location = New System.Drawing.Point(129, 90)
        Me.dtpNgaylap.Name = "dtpNgaylap"
        Me.dtpNgaylap.Size = New System.Drawing.Size(136, 20)
        Me.dtpNgaylap.TabIndex = 3
        '
        'dgvPhieunhapchitiet
        '
        Me.dgvPhieunhapchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPhieunhapchitiet.Location = New System.Drawing.Point(332, 211)
        Me.dgvPhieunhapchitiet.Name = "dgvPhieunhapchitiet"
        Me.dgvPhieunhapchitiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPhieunhapchitiet.Size = New System.Drawing.Size(449, 193)
        Me.dgvPhieunhapchitiet.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Mã phiếu nhập"
        '
        'txtMapn
        '
        Me.txtMapn.Location = New System.Drawing.Point(142, 211)
        Me.txtMapn.Name = "txtMapn"
        Me.txtMapn.ReadOnly = True
        Me.txtMapn.Size = New System.Drawing.Size(136, 20)
        Me.txtMapn.TabIndex = 33
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(608, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Tổng tiền"
        '
        'txtTongtien
        '
        Me.txtTongtien.Location = New System.Drawing.Point(679, 414)
        Me.txtTongtien.Name = "txtTongtien"
        Me.txtTongtien.ReadOnly = True
        Me.txtTongtien.Size = New System.Drawing.Size(101, 20)
        Me.txtTongtien.TabIndex = 36
        '
        'PhieuNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 489)
        Me.Controls.Add(Me.txtTongtien)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMapn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.dgvPhieunhapchitiet)
        Me.Controls.Add(Me.dgvPhieunhap)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PhieuNhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhieuNhap"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPhieunhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPhieunhapchitiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDongianhap As System.Windows.Forms.TextBox
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents dgvPhieunhap As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPhieunhapchitiet As System.Windows.Forms.DataGridView
    Friend WithEvents btnTaomoi As System.Windows.Forms.Button
    Friend WithEvents dtpNgaylap As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMapn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtThanhtien As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTongtien As System.Windows.Forms.TextBox
    Friend WithEvents btnTaomoinhacungcap As System.Windows.Forms.Button
    Friend WithEvents btnTaomoisanpham As System.Windows.Forms.Button
    Public WithEvents cbMancc As System.Windows.Forms.ComboBox
    Public WithEvents cbMasp As System.Windows.Forms.ComboBox
End Class
