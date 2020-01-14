Imports System.Data.OleDb

Public Class HoaDon
    Dim connetionString As String = "Provider=SQLOLEDB.1;Data Source=SGVULJMJH208ZX7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QLPKVL"


    Private Sub ThoatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.Hide()
    End Sub



    Private Sub HoaDon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvHoadon.AllowUserToAddRows = False 'Xóa dòng trống cuối datagridview
        dgvHoadon.AllowUserToAddRows = False 'Xóa dòng trống cuối datagridview

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()

        'Đổ comboxbox khách hàng
        Dim adapter1 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM KHACHHANG", connection)
        Dim dataset1 = New DataSet()
        adapter1.Fill(dataset1)
        cbMakh.DataSource = dataset1.Tables(0)
        cbMakh.DisplayMember = "Hoten"
        cbMakh.ValueMember = "Makh"

        'Đổ combobox sản phẩm
        Dim adapter2 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM SANPHAM", connection)
        Dim dataset2 = New DataSet()
        adapter2.Fill(dataset2)
        cbMasp.DataSource = dataset2.Tables(0)
        cbMasp.DisplayMember = "Tensanpham"
        cbMasp.ValueMember = "Masp"

        connection.Close()

        'Load các hóa đơn đã có vào datagridview
        loadDgvhoadon()

        'Tắt các control ở hóa đơn chi tiết
        cbMasp.Enabled = False
        txtSoluong.Enabled = False

    End Sub




    Private Sub loadDgvhoadon()
        Dim sql As String = "SELECT HOADON.Mahd,HOADON.Ngaylaphd,KHACHHANG.Hoten,HOADON.Tongtien,NHANVIEN.tendangnhap FROM HOADON,NHANVIEN,KHACHHANG WHERE HOADON.Makh=KHACHHANG.Makh AND HOADON.Manhanvien=NHANVIEN.Manhanvien"

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
        Dim dataset = New DataSet()
        adapter.Fill(dataset)
        dgvHoadon.DataSource = dataset.Tables(0)
        connection.Close()
        dgvHoadon.Columns("Mahd").HeaderText = "Mã hóa đơn"
        dgvHoadon.Columns("Ngaylaphd").HeaderText = "Ngày lập hóa đơn"
        dgvHoadon.Columns("Tongtien").HeaderText = "Tổng tiền"
        dgvHoadon.Columns("Tendangnhap").HeaderText = "Tên nhân viên"
        dgvHoadon.Columns("Hoten").HeaderText = "Họ tên khách hàng"

    End Sub


    Private Sub btnTaomoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaomoi.Click
        'Tạo mới bảng ghi hóa đơn (ban đầu cho tổng tiền là 0)
        Try
            Dim NgayLapHD As DateTime = Convert.ToDateTime(dtpNgaylaphd.Text)

            Dim sql As String = "INSERT INTO HOADON(Makh,Ngaylaphd,Tongtien,Manhanvien) VALUES('" + cbMakh.SelectedValue.ToString() + "','" + NgayLapHD + "','0','" + frmDangNhap.Manhanvien + "')"
            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()
            Dim command As OleDbCommand = New OleDbCommand(sql, connection)
            command.ExecuteNonQuery()
            connection.Close()

            MsgBox("Thêm hóa đơn mới thành công")

            'Load lại datagridview hóa đơn
            loadDgvhoadon()

            'Tự chọn hàng mới thêm trong datagridview hóa đơn
            dgvHoadon.FirstDisplayedScrollingRowIndex = dgvHoadon.RowCount - 1
            dgvHoadon.Rows(dgvHoadon.RowCount - 1).Selected = True

            'Lấy mã phiếu ở datagridview hóa đơn mới được thêm vào đổ vào textbox txtMahd 
            Dim i As Integer = dgvHoadon.RowCount - 1
            txtMahd.Text = dgvHoadon.Rows(i).Cells("Mahd").Value.ToString()

            'Mở lại các control ở hóa đơn chi tiết
            cbMasp.Enabled = True
            txtSoluong.Enabled = True
            txtDongia.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Private Sub txtSoluong_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSoluong.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDongia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If txtSoluong.Text <> "" And txtDongia.Text <> "" Then
            txtThanhtien.Text = Int32.Parse(txtSoluong.Text) * Int32.Parse(txtDongia.Text)
        Else
            txtThanhtien.Text = ""
        End If
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        'Kiểm tra mã sản phẩm đã có trong phiếu hóa đơn chi tiết theo mã phiếu hóa đơn hiện tại không 
        If kiemtratontaimasptronghdct() = True Then
            MsgBox("Đã tồn tại sản phẩm này trong hóa đơn")
            Exit Sub
        End If
        'Kiểm tra xem có bán vượt quá số lượng tồn kho của sản phẩm không

        If txtSoluong.Text = "" Then
            MsgBox("Nhập số lượng bán")
        ElseIf txtSoluong.Text <= 0 Then
            MsgBox("Số lượng bán phải lón hơn 0")
        Else
            Try
                Dim sql As String = "INSERT INTO CHITIETHD(Mahd,Masp,Soluong,Dongia,Thanhtien) VALUES('" + txtMahd.Text + "','" + cbMasp.SelectedValue.ToString() + "','" + txtSoluong.Text + "','" + txtDongia.Text + "','" + txtThanhtien.Text + "')"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Tạo hóa đơn chi tiết thành công")

                loadDgvhoadonchitiet()

                'In tổng tiền vào textbox txtTongtien
                Dim tt As Double = 0
                For i = 0 To dgvChitiethoadon.RowCount - 1
                    If Not (dgvChitiethoadon.Rows(i).Cells("Thanhtien").Value = 0) Then
                        tt += dgvChitiethoadon.Rows(i).Cells("Thanhtien").Value
                    End If
                Next
                txtTongtien.Text = tt

                'Lưu vào tổng tiền của phiếu nhập
                Dim sql2 As String = "UPDATE HOADON SET Tongtien='" + txtTongtien.Text + "' WHERE Mahd='" + txtMahd.Text + "'"
                Dim connection2 As OleDbConnection = New OleDbConnection(connetionString)
                connection2.Open()
                Dim command2 As OleDbCommand = New OleDbCommand(sql2, connection2)
                command2.ExecuteNonQuery()
                connection2.Close()

                'Load lại datagridview hóa đơn
                loadDgvhoadon()
                'Nhảy về đến cuối datagridview hóa đơn
                dgvHoadon.FirstDisplayedScrollingRowIndex = dgvHoadon.RowCount - 1
                dgvHoadon.Rows(dgvHoadon.RowCount - 1).Selected = True
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub


    Private Function kiemtratontaimasptronghdct() As Boolean
        Dim sql As String = "SELECT COUNT(Masp) FROM CHITIETHD WHERE Mahd='" + txtMahd.Text + "' AND Masp='" + cbMasp.SelectedValue.ToString() + "'"

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
        Dim dataset = New DataSet()
        adapter.Fill(dataset)
        If dataset.Tables(0).Rows(0)(0) > 0 Then
            Return True
        Else
            Return False
        End If

        connection.Close()
    End Function

    Private Function kiemtravuotquatonkho(ByVal masp As String, ByVal soluongban As Integer) As Boolean
        Dim sql As String = "SELECT Soluongton FROM SANPHAM WHERE Masp='" + cbMasp.SelectedValue.ToString + "'"

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
        Dim dataset = New DataSet()
        adapter.Fill(dataset)

        Dim Soluongtonhientai As Integer = Int32.Parse(dataset.Tables(0).Rows(0)("Soluongton"))

        If Soluongtonhientai > soluongban Then
            Return True
        Else
            Return False
        End If

        connection.Close()
    End Function

    Private Sub loadDgvhoadonchitiet()
        Dim sql As String = "SELECT CHITIETHD.Machitiethoadon,SANPHAM.Tensanpham,CHITIETHD.Dongia,CHITIETHD.Soluong,CHITIETHD.Thanhtien FROM CHITIETHD INNER JOIN SANPHAM ON CHITIETHD.Masp=SANPHAM.Masp WHERE CHITIETHD.Mahd='" + txtMahd.Text + "'"

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
        Dim dataset = New DataSet()
        adapter.Fill(dataset)
        dgvChitiethoadon.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub

    Private Sub cbMasp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("a")
    End Sub

    'Chọn combobox sản phẩm thì lấy giá bán đổ vào textbox đơn giá
    Private Sub cbMasp_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMasp.SelectionChangeCommitted
        Dim Masp As String = cbMasp.SelectedValue.ToString()

        Dim sql As String = "SELECT SANPHAM.Dongiaban FROM SANPHAM WHERE SANPHAM.Masp='" + Masp + "'"

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
        Dim dataset = New DataSet()
        adapter.Fill(dataset)

        'Nếu số lượng tồn trong kho lớn hơn 0 thì mới lấy giá bán
        If dataset.Tables(0).Rows(0)("Dongiaban") > 0 Then
            txtDongia.Text = dataset.Tables(0).Rows(0)("Dongiaban")
        Else
            MsgBox("Sản phẩm này đã hết hàng")
        End If

    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If dgvChitiethoadon.SelectedRows.Count > 0 Then
            Try
                Dim i As Integer = dgvChitiethoadon.CurrentRow.Index
                Dim Machitiethoadon As String = dgvChitiethoadon.Rows(i).Cells("Machitiethoadon").Value

                Dim sql As String = "DELETE FROM CHITIETHD WHERE Machitiethoadon='" & Machitiethoadon & "'"

                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Xóa hóa đơn chi tiết thành công")
                loadDgvhoadonchitiet()

                'In lại tổng tiền vào textbox txtTongtien sau khi xóa
                Dim tt As Double = 0
                For i = 0 To dgvChitiethoadon.RowCount - 1
                    If Not (dgvChitiethoadon.Rows(i).Cells("Thanhtien").Value = 0) Then
                        tt += dgvChitiethoadon.Rows(i).Cells("Thanhtien").Value
                    End If
                Next
                txtTongtien.Text = tt

                'Lưu vào tổng tiền của phiếu nhập
                Dim sql2 As String = "UPDATE HOADON SET Tongtien='" + txtTongtien.Text + "' WHERE Mahd='" + txtMahd.Text + "'"
                Dim connection2 As OleDbConnection = New OleDbConnection(connetionString)
                connection2.Open()
                Dim command2 As OleDbCommand = New OleDbCommand(sql2, connection2)
                command2.ExecuteNonQuery()
                connection2.Close()

                'Load lại datagridview hóa đơn
                loadDgvhoadon()
                'Nhảy về đến cuối datagridview hóa đơn
                dgvHoadon.FirstDisplayedScrollingRowIndex = dgvHoadon.RowCount - 1
                dgvHoadon.Rows(dgvHoadon.RowCount - 1).Selected = True

            Catch ex As Exception
                MsgBox(ex.Message())
            End Try
        End If
    End Sub

    Private Sub HoaDon_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        Try
            Dim sql As String = "DELETE FROM HOADON WHERE Tongtien='0'"

            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()
            Dim command As OleDbCommand = New OleDbCommand(sql, connection)
            command.ExecuteNonQuery()
            connection.Close()


            cbMasp.Enabled = False
            txtSoluong.Clear()
            txtDongia.Clear()
            txtThanhtien.Clear()
            txtSoluong.Enabled = False
            txtDongia.Enabled = False

            dgvChitiethoadon.DataSource = Nothing
            dgvChitiethoadon.Rows.Clear()
            dgvChitiethoadon.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub


    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btnTaomoikhachhang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaomoikhachhang.Click
        KhachHang.ShowDialog()
    End Sub


    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class