Imports System.Data.OleDb

Public Class LoaiSanPham
    Dim connetionString As String = "Provider=SQLOLEDB.1;Data Source=SGVULJMJH208ZX7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QLPKVL"

    Private Sub LoaiSanPham_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDatagridview()
    End Sub

    Private Sub LoadDatagridview()
        Try
            Dim sql As String = "SELECT * FROM LOAISANPHAM"

            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()
            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
            Dim dataset = New DataSet()
            adapter.Fill(dataset)
            dgvLoaiSanPham.DataSource = dataset.Tables(0)
            connection.Close()
            dgvLoaiSanPham.Columns("Maloaisanpham").HeaderText = "Mã loại sản phẩm"
            dgvLoaiSanPham.Columns("Tenloaisanpham").HeaderText = "Tên loại sản phẩm"
            dgvLoaiSanPham.Columns("Maloaisanpham").Width = 170
            dgvLoaiSanPham.Columns("Tenloaisanpham").Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub dgvLoaiSanPham_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLoaiSanPham.CellClick
        Dim i As Integer = dgvLoaiSanPham.CurrentRow.Index
        txtMaloaisanpham.Text = dgvLoaiSanPham.Rows(i).Cells(0).Value.ToString()
        txtTenloaisanpham.Text = dgvLoaiSanPham.Rows(i).Cells(1).Value.ToString()
    End Sub

    Private Sub btnTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimKiem.Click
        If txtTimKiem.Text = "" Then
            MsgBox("Nhập tên loại sản phẩm cần tìm")
        Else
            Try
                Dim sql As String = "SELECT * FROM LOAISANPHAM WHERE Tenloaisanpham LIKE  '%" & txtTimKiem.Text & "%'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
                Dim dataset = New DataSet()
                adapter.Fill(dataset)
                dgvLoaiSanPham.DataSource = dataset.Tables(0)
                connection.Close()

                dgvLoaiSanPham.Columns("Maloaisanpham").Width = 170
                dgvLoaiSanPham.Columns("Tenloaisanpham").Width = 200
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If dgvLoaiSanPham.SelectedRows.Count > 0 Then
            Try
                Dim i As Integer = dgvLoaiSanPham.CurrentRow.Index
                Dim Maloaisanpham As String = dgvLoaiSanPham.Rows(i).Cells("Maloaisanpham").Value()

                Dim sql As String = "DELETE FROM LOAISANPHAM WHERE Maloaisanpham='" & Maloaisanpham & "'"

                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Xóa loại sản phẩm thành công")
                LoadDatagridview()
                txtMaloaisanpham.Clear()
                txtTenloaisanpham.Clear()
            Catch ex As Exception
                MsgBox("Đã tồn tại sản phẩm trong loại sản phẩm này nên không thể xóa")
            End Try
        Else
            MsgBox("Chọn loại sản phẩm cần xóa")
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If txtTenloaisanpham.Text = "" Then
            MsgBox("Nhập tên loại sản phẩm")
        Else
            Try
                Dim sql As String = " UPDATE LOAISANPHAM SET Tenloaisanpham= N'" + txtTenloaisanpham.Text + "' WHERE Maloaisanpham='" + txtMaloaisanpham.Text + "'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Sửa loại sản phẩm thành công")
                LoadDatagridview()
                txtMaloaisanpham.Clear()
                txtTenloaisanpham.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        If txtTenloaisanpham.Text = "" Then
            MsgBox("Nhập tên loại sản phẩm")
        Else
            Try
                Dim sql As String = "INSERT INTO LOAISANPHAM(Tenloaisanpham) VALUES(N'" & txtTenloaisanpham.Text & "')"

                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Thêm loại sản phẩm thành công")
                LoadDatagridview()
                txtMaloaisanpham.Clear()
                txtTenloaisanpham.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub LoaiSanPham_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()

        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM LOAISANPHAM", connection)
        Dim dataset = New DataSet()
        adapter.Fill(dataset)
        SanPham.cbMaloaisanpham.DataSource = dataset.Tables(0)
        SanPham.cbMaloaisanpham.DisplayMember = "Tenloaisanpham"
        SanPham.cbMaloaisanpham.ValueMember = "Maloaisanpham"
    End Sub
End Class