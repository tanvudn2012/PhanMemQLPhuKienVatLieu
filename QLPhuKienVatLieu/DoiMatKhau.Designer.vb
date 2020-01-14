<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoiMatKhau
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnXacnhan = New System.Windows.Forms.Button()
        Me.txtTendangnhap = New System.Windows.Forms.TextBox()
        Me.txtNhaplaipassmoi = New System.Windows.Forms.TextBox()
        Me.txtPassmoi = New System.Windows.Forms.TextBox()
        Me.txtPasscu = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrợGiúpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(529, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.Image = Global.QLPhuKienVatLieu.My.Resources.Resources.tải_xuống__13_
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ giúp"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnHuy)
        Me.GroupBox4.Controls.Add(Me.btnXacnhan)
        Me.GroupBox4.Controls.Add(Me.txtTendangnhap)
        Me.GroupBox4.Controls.Add(Me.txtNhaplaipassmoi)
        Me.GroupBox4.Controls.Add(Me.txtPassmoi)
        Me.GroupBox4.Controls.Add(Me.txtPasscu)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(504, 304)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'btnHuy
        '
        Me.btnHuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuy.Location = New System.Drawing.Point(392, 248)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(83, 39)
        Me.btnHuy.TabIndex = 3
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnXacnhan
        '
        Me.btnXacnhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXacnhan.Location = New System.Drawing.Point(230, 248)
        Me.btnXacnhan.Name = "btnXacnhan"
        Me.btnXacnhan.Size = New System.Drawing.Size(83, 39)
        Me.btnXacnhan.TabIndex = 3
        Me.btnXacnhan.Text = "Xác Nhận"
        Me.btnXacnhan.UseVisualStyleBackColor = True
        '
        'txtTendangnhap
        '
        Me.txtTendangnhap.Location = New System.Drawing.Point(230, 30)
        Me.txtTendangnhap.Name = "txtTendangnhap"
        Me.txtTendangnhap.Size = New System.Drawing.Size(245, 20)
        Me.txtTendangnhap.TabIndex = 2
        '
        'txtNhaplaipassmoi
        '
        Me.txtNhaplaipassmoi.Location = New System.Drawing.Point(230, 209)
        Me.txtNhaplaipassmoi.Name = "txtNhaplaipassmoi"
        Me.txtNhaplaipassmoi.Size = New System.Drawing.Size(245, 20)
        Me.txtNhaplaipassmoi.TabIndex = 2
        '
        'txtPassmoi
        '
        Me.txtPassmoi.Location = New System.Drawing.Point(230, 145)
        Me.txtPassmoi.Name = "txtPassmoi"
        Me.txtPassmoi.Size = New System.Drawing.Size(245, 20)
        Me.txtPassmoi.TabIndex = 2
        '
        'txtPasscu
        '
        Me.txtPasscu.Location = New System.Drawing.Point(230, 88)
        Me.txtPasscu.Name = "txtPasscu"
        Me.txtPasscu.Size = New System.Drawing.Size(245, 20)
        Me.txtPasscu.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(55, 213)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 16)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Nhập lại mật khẩu mới:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(55, 149)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Nhập mật khẩu mới:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(55, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 16)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Nhập mật khẩu cũ   :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(55, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Tên đăng nhập         :"
        '
        'frmDoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 347)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmDoiMatKhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoiMatKhau"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPasscu As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTendangnhap As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnXacnhan As System.Windows.Forms.Button
    Friend WithEvents txtNhaplaipassmoi As System.Windows.Forms.TextBox
    Friend WithEvents txtPassmoi As System.Windows.Forms.TextBox
End Class
