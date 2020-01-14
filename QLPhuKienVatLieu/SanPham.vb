Imports System.Data.OleDb

Public Class SanPham
    Dim connetionString As String = "Provider=SQLOLEDB.1;Data Source=SGVULJMJH208ZX7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QLPKVL"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDatagridview()

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()

        Dim adapter1 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM LOAISANPHAM", connection)
        Dim dataset1 = New DataSet()
        adapter1.Fill(dataset1)
        cbMaloaisanpham.DataSource = dataset1.Tables(0)
        cbMaloaisanpham.DisplayMember = "Tenloaisanpham"
        cbMaloaisanpham.ValueMember = "Maloaisanpham"

        Dim adapter2 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM DONVITINH", connection)
        Dim dataset2 = New DataSet()
        adapter2.Fill(dataset2)
        cbMadonvitinh.DataSource = dataset2.Tables(0)
        cbMadonvitinh.DisplayMember = "Tendonvitinh"
        cbMadonvitinh.ValueMember = "Madonvitinh"

        connection.Close()
    End Sub

    Private Sub LoadDatagridview()
        Try
            Dim sql As String = "SELECT SANPHAM.Masp,SANPHAM.Tensanpham,SANPHAM.Soluongton,DONVITINH.Tendonvitinh,SANPHAM.Dongiaban,LOAISANPHAM.Tenloaisanpham,LOAISANPHAM.Maloaisanpham,DONVITINH.Madonvitinh FROM SANPHAM,LOAISANPHAM,DONVITINH WHERE SANPHAM.Maloaisanpham=LOAISANPHAM.Maloaisanpham AND SANPHAM.Madonvitinh=DONVITINH.Madonvitinh"

            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()
            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
            Dim dataset = New DataSet()
            adapter.Fill(dataset)
            dgvSanpham.DataSource = dataset.Tables(0)
            connection.Close()
            dgvSanpham.Columns("masp").HeaderText = "Mã sản phẩm"
            dgvSanpham.Columns("Tensanpham").HeaderText = "Tên sản phẩm"
            dgvSanpham.Columns("Maloaisanpham").HeaderText = "Mã loại sản phẩm"
            dgvSanpham.Columns("Soluongton").HeaderText = "Số lượng tồn"
            dgvSanpham.Columns("Madonvitinh").HeaderText = "Mã đơn vị tinh"
            dgvSanpham.Columns("Dongiaban").HeaderText = "Đơn giá bán"
            dgvSanpham.Columns("Tendonvitinh").HeaderText = "Tên đơn vị tính"
            dgvSanpham.Columns("Tenloaisanpham").HeaderText = "Tên loại sản phẩm"
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSanpham.CellClick
        Dim i As Integer = dgvSanpham.CurrentRow.Index
        txtMasp.Text = dgvSanpham.Rows(i).Cells("Masp").Value.ToString()
        txtTensanpham.Text = dgvSanpham.Rows(i).Cells("Tensanpham").Value.ToString()
        cbMaloaisanpham.SelectedValue = dgvSanpham.Rows(i).Cells("Maloaisanpham").Value.ToString()
        txtSoluongton.Text = dgvSanpham.Rows(i).Cells("Soluongton").Value.ToString()
        cbMadonvitinh.SelectedValue = dgvSanpham.Rows(i).Cells("Madonvitinh").Value.ToString()
        txtDongiaban.Text = dgvSanpham.Rows(i).Cells("Dongiaban").Value.ToString()
    End Sub

    Private Sub btnTimkiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimkiem.Click
        If txtTimkiem.Text = "" Then
            MsgBox("Nhập tên sản phẩm cần tìm")
        Else
            Try
                Dim sql As String = "SELECT SANPHAM.Masp,SANPHAM.Tensanpham,SANPHAM.Soluongton,DONVITINH.Tendonvitinh,SANPHAM.Dongiaban,LOAISANPHAM.Tenloaisanpham,LOAISANPHAM.Maloaisanpham,DONVITINH.Madonvitinh FROM SANPHAM,LOAISANPHAM,DONVITINH WHERE SANPHAM.Maloaisanpham=LOAISANPHAM.Maloaisanpham AND SANPHAM.Madonvitinh=DONVITINH.Madonvitinh AND Tensanpham LIKE '%" & txtTimkiem.Text & "%'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
                Dim dataset = New DataSet()
                adapter.Fill(dataset)
                dgvSanpham.DataSource = dataset.Tables(0)
                connection.Close()

            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If dgvSanpham.SelectedRows.Count > 0 Then
            Try
                Dim i As Integer = dgvSanpham.CurrentRow.Index
                Dim Masp As String = dgvSanpham.Rows(i).Cells("Masp").Value

                Dim sql As String = "DELETE FROM SANPHAM WHERE Masp='" & Masp & "'"

                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Xóa sản phẩm thành công")
                LoadDatagridview()
                txtMasp.Clear()
                txtTensanpham.Clear()
                txtSoluongton.Clear()
                txtDongiaban.Clear()
            Catch ex As Exception
                MsgBox("Đã tồn tại sản phẩm trong hóa đơn chi tiết nên không thể xóa")
            End Try
        Else
            MsgBox("Chọn sản phẩm cần xóa")
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If txtTensanpham.Text = "" Then
            MsgBox("Nhập tên sản phẩm")
        ElseIf txtDongiaban.Text = "" Then
            MsgBox("Nhập đơn giá bán")
        Else
            Try
                Dim sql As String = " UPDATE SANPHAM SET Tensanpham= N'" + txtTensanpham.Text + "',Maloaisanpham='" + cbMaloaisanpham.SelectedValue.ToString() + "',Madonvitinh='" + cbMadonvitinh.SelectedValue.ToString() + "',Dongiaban='" + txtDongiaban.Text + "'WHERE Masp='" + txtMasp.Text + "'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Sửa sản phẩm thành công")
                LoadDatagridview()
                txtMasp.Clear()
                txtTensanpham.Clear()
                txtSoluongton.Clear()
                txtDongiaban.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        If txtTensanpham.Text = "" Then
            MsgBox("Nhập tên sản phẩm")
        ElseIf txtDongiaban.Text = "" Then
            MsgBox("Nhập đơn giá bán")
        Else
            Try
                Dim sql As String = "INSERT INTO SANPHAM(Tensanpham,Maloaisanpham,Soluongton,Madonvitinh,Dongiaban) VALUES(N'" + txtTensanpham.Text + "','" + cbMaloaisanpham.SelectedValue.ToString() + "','0','" + cbMadonvitinh.SelectedValue.ToString() + "','" + txtDongiaban.Text + "')"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Thêm sản phẩm thành công")
                LoadDatagridview()
                txtMasp.Clear()
                txtTensanpham.Clear()
                txtSoluongton.Clear()
                txtDongiaban.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub SanPham_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()

            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM SANPHAM", connection)
            Dim dataset = New DataSet()
            adapter.Fill(dataset)
            PhieuNhap.cbMasp.DataSource = dataset.Tables(0)
            PhieuNhap.cbMasp.DisplayMember = "Tensanpham"
            PhieuNhap.cbMasp.ValueMember = "Masp"
            PhieuNhap.cbMasp.Refresh()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub btnThemloaisanpham_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemloaisanpham.Click
        LoaiSanPham.ShowDialog()
    End Sub

    Private Sub btnTaodonvitinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaodonvitinh.Click
        Donvitinh.ShowDialog()
    End Sub
End Class