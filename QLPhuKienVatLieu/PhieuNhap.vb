Imports System.Data.OleDb

Public Class PhieuNhap
    Dim connetionString As String = "Provider=SQLOLEDB.1;Data Source=SGVULJMJH208ZX7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QLPKVL"

    Private Sub ThoatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoatToolStripMenuItem.Click
        Me.Hide()
    End Sub

    Private Sub PhieuNhap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dgvPhieunhap.AllowUserToAddRows = False 'Xóa dòng trống cuối datagridview
        dgvPhieunhapchitiet.AllowUserToAddRows = False 'Xóa dòng trống cuối datagridview

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()

        'Đổ comboxbox nhà cung cấp
        Dim adapter1 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM NHACC", connection)
        Dim dataset1 = New DataSet()
        adapter1.Fill(dataset1)
        cbMancc.DataSource = dataset1.Tables(0)
        cbMancc.DisplayMember = "Tenncc"
        cbMancc.ValueMember = "Mancc"

        'Đổ combobox sản phẩm
        Dim adapter2 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM SANPHAM", connection)
        Dim dataset2 = New DataSet()
        adapter2.Fill(dataset2)
        cbMasp.DataSource = dataset2.Tables(0)
        cbMasp.DisplayMember = "Tensanpham"
        cbMasp.ValueMember = "Masp"

        connection.Close()

        'Load các phiếu nhập đã có vào datagridview
        loadDgvphieunhap()

        'Tắt các control ở phiếu chi tiết
        cbMasp.Enabled = False
        txtSoluong.Enabled = False
        txtDongianhap.Enabled = False
        btnTaomoisanpham.Enabled = False
        btnThem.Enabled = False
        dgvPhieunhap.Columns("Mapn").HeaderText = "Mã phiếu nhập"
        dgvPhieunhap.Columns("Ngaylap").HeaderText = "Ngày lập"
        dgvPhieunhap.Columns("Tenncc").HeaderText = "Tên nhà cung cấp"
        dgvPhieunhap.Columns("Tongtien").HeaderText = "Tổng tiền"
    End Sub

    'Tạo mới phiếu nhập
    Private Sub btnTaomoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaomoi.Click
        'Tạo mới bảng ghi phiếu nhập (ban đầu cho tổng tiền là 0)
        Try
            Dim NgayLapPN As DateTime = Convert.ToDateTime(dtpNgaylap.Text)

            Dim sql As String = "INSERT INTO PHIEUNHAP(Mancc,Ngaylap,Tongtien) VALUES('" + cbMancc.SelectedValue.ToString() + "','" + NgayLapPN + "','0')"
            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()
            Dim command As OleDbCommand = New OleDbCommand(sql, connection)
            command.ExecuteNonQuery()
            connection.Close()

            MsgBox("Thêm phiếu nhập mới thành công")

            'Load lại datagridview phiếu nhập
            loadDgvphieunhap()

            'Tự chọn hàng mới thêm trong datagridview phiếu nhập
            dgvPhieunhap.FirstDisplayedScrollingRowIndex = dgvPhieunhap.RowCount - 1
            dgvPhieunhap.Rows(dgvPhieunhap.RowCount - 1).Selected = True

            'Lấy mã phiếu ở datagridview phiếu nhập mới được thêm vào đổ vào textbox txtMapn 
            Dim i As Integer = dgvPhieunhap.RowCount - 1
            txtMapn.Text = dgvPhieunhap.Rows(i).Cells("Mapn").Value.ToString()

            'Mở lại các control ở phiếu chi tiết
            cbMasp.Enabled = True
            txtSoluong.Enabled = True
            txtDongianhap.Enabled = True
            btnTaomoisanpham.Enabled = True
            btnThem.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Private Sub loadDgvphieunhap()
        Dim sql As String = "SELECT PHIEUNHAP.Mapn,PHIEUNHAP.Ngaylap,NHACC.Tenncc,PHIEUNHAP.Tongtien FROM PHIEUNHAP,NHACC WHERE PHIEUNHAP.Mancc=NHACC.Mancc"

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
        Dim dataset = New DataSet()
        adapter.Fill(dataset)
        dgvPhieunhap.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub



    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        'Kiểm tra mã sản phẩm theo mã phiếu nhập đã có trong bảng chi tiết phiếu nhập không, nếu có thì yêu cầu xóa sản phẩm đó ra khỏi phiếu nhập chi tiết rồi thêm lại
        If kiemtratontaimasptrongpnct() = True Then
            MsgBox("Đã tồn tại sản phẩm này trong phiếu nhập")
            Exit Sub
        End If


        If txtSoluong.Text = "" Then
            MsgBox("Nhập số lượng nhập")
        ElseIf txtSoluong.Text <= 0 Then
            MsgBox("Số lượng nhập phải lón hơn 0")
        ElseIf txtDongianhap.Text = "" Then
            MsgBox("Nhập đơn giá nhập")
        ElseIf txtDongianhap.Text <= 0 Then
            MsgBox("Giá nhập phải lớn hơn 0")
        Else
            Try
                Dim sql As String = "INSERT INTO CTPHIEUNHAP(Mapn,Masp,Soluong,Dongianhap,Thanhtien) VALUES('" + txtMapn.Text + "','" + cbMasp.SelectedValue.ToString() + "','" + txtSoluong.Text + "','" + txtDongianhap.Text + "','" + txtThanhtien.Text + "')"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Tạo chi tiết phiếu nhập thành công")

                loadDgvphieunhapchitiet()
                txtSoluong.Clear()
                txtDongianhap.Clear()

                'In tổng tiền vào textbox txtTongtien
                Dim tt As Double = 0
                For i = 0 To dgvPhieunhapchitiet.RowCount - 1
                    If Not (dgvPhieunhapchitiet.Rows(i).Cells("Thanhtien").Value = 0) Then
                        tt += dgvPhieunhapchitiet.Rows(i).Cells("Thanhtien").Value
                    End If
                Next
                txtTongtien.Text = tt

                'Lưu vào tổng tiền của phiếu nhập
                Dim sql2 As String = "UPDATE PHIEUNHAP SET Tongtien='" + txtTongtien.Text + "' WHERE Mapn='" + txtMapn.Text + "'"
                Dim connection2 As OleDbConnection = New OleDbConnection(connetionString)
                connection2.Open()
                Dim command2 As OleDbCommand = New OleDbCommand(sql2, connection2)
                command2.ExecuteNonQuery()
                connection2.Close()
                'Load lại datagridview phiếu nhập
                loadDgvphieunhap()
                'Nhảy về đến cuối datagridview phiếu nhập
                dgvPhieunhap.FirstDisplayedScrollingRowIndex = dgvPhieunhap.RowCount - 1
                dgvPhieunhap.Rows(dgvPhieunhap.RowCount - 1).Selected = True


            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

    End Sub

    Private Function kiemtratontaimasptrongpnct() As Boolean
        Dim sql As String = "SELECT COUNT(Masp) FROM CTPHIEUNHAP WHERE Mapn='" + txtMapn.Text + "' AND Masp='" + cbMasp.SelectedValue.ToString() + "'"

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

    Private Sub loadDgvphieunhapchitiet()
        Dim sql As String = "SELECT CTPHIEUNHAP.Mactphieunhap,SANPHAM.Tensanpham,CTPHIEUNHAP.Dongianhap,CTPHIEUNHAP.Soluong,CTPHIEUNHAP.Thanhtien FROM CTPHIEUNHAP INNER JOIN SANPHAM ON CTPHIEUNHAP.Masp=SANPHAM.Masp WHERE CTPHIEUNHAP.Mapn='" + txtMapn.Text + "'"

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
        Dim dataset = New DataSet()
        adapter.Fill(dataset)
        dgvPhieunhapchitiet.DataSource = dataset.Tables(0)
        connection.Close()
    End Sub

    'Chỉ được nhập số vào số lượng
    Private Sub txtSoluong_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSoluong.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Chỉ được nhập số vào đơn giá nhập
    Private Sub txtDongianhap_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDongianhap.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If txtSoluong.Text <> "" And txtDongianhap.Text <> "" Then
            txtThanhtien.Text = Int32.Parse(txtSoluong.Text) * Int32.Parse(txtDongianhap.Text)
        Else
            txtThanhtien.Text = ""
        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If dgvPhieunhapchitiet.SelectedRows.Count > 0 Then
            Try
                Dim i As Integer = dgvPhieunhapchitiet.CurrentRow.Index
                Dim Mactphieunhap As String = dgvPhieunhapchitiet.Rows(i).Cells("Mactphieunhap").Value

                Dim sql As String = "DELETE FROM CTPHIEUNHAP WHERE Mactphieunhap='" & Mactphieunhap & "'"

                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Xóa chi tiết phiếu nhập thành công")
                loadDgvphieunhapchitiet()

                'In lại tổng tiền vào textbox txtTongtien sau khi xóa
                Dim tt As Double = 0
                For i = 0 To dgvPhieunhapchitiet.RowCount - 1
                    If Not (dgvPhieunhapchitiet.Rows(i).Cells("Thanhtien").Value = 0) Then
                        tt += dgvPhieunhapchitiet.Rows(i).Cells("Thanhtien").Value
                    End If
                Next
                txtTongtien.Text = tt

                'Lưu vào tổng tiền của phiếu nhập
                Dim sql2 As String = "UPDATE PHIEUNHAP SET Tongtien='" + txtTongtien.Text + "' WHERE Mapn='" + txtMapn.Text + "'"
                Dim connection2 As OleDbConnection = New OleDbConnection(connetionString)
                connection2.Open()
                Dim command2 As OleDbCommand = New OleDbCommand(sql2, connection2)
                command2.ExecuteNonQuery()
                connection2.Close()
                'Load lại datagridview phiếu nhập
                loadDgvphieunhap()
                'Nhảy về đến cuối datagridview phiếu nhập
                dgvPhieunhap.FirstDisplayedScrollingRowIndex = dgvPhieunhap.RowCount - 1
                dgvPhieunhap.Rows(dgvPhieunhap.RowCount - 1).Selected = True

            Catch ex As Exception
                MsgBox(ex.Message())
            End Try
        End If
    End Sub

    Private Sub PhieuNhap_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
       
        Try
            Dim sql As String = "DELETE FROM PHIEUNHAP WHERE Tongtien='0'"

            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()
            Dim command As OleDbCommand = New OleDbCommand(sql, connection)
            command.ExecuteNonQuery()
            connection.Close()


            txtMapn.Clear()
            txtMapn.Enabled = False
            cbMasp.Enabled = False
            txtSoluong.Clear()
            txtSoluong.Enabled = False
            txtDongianhap.Clear()
            txtDongianhap.Enabled = False
            txtThanhtien.Clear()
            txtThanhtien.Enabled = False
            txtTongtien.Text = ""
            txtTongtien.Enabled = False
            dgvPhieunhapchitiet.DataSource = Nothing
            dgvPhieunhapchitiet.Rows.Clear()
            dgvPhieunhapchitiet.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub btnTaomoinhacungcap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaomoinhacungcap.Click
        NhaCC.ShowDialog()
    End Sub

    Private Sub btnTaomoisanpham_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaomoisanpham.Click
        SanPham.ShowDialog()
    End Sub

    Private Sub txtDongianhap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDongianhap.TextChanged

    End Sub

End Class