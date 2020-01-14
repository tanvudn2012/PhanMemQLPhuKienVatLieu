Imports System.Data.OleDb

Public Class KhachHang

    Dim connetionString As String = "Provider=SQLOLEDB.1;Data Source=SGVULJMJH208ZX7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QLPKVL"

    Private Sub KhachHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDatagridview()
    End Sub

    Private Sub LoadDatagridview()
        Try
            Dim sql As String = "SELECT * FROM KHACHHANG"

            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()
            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
            Dim dataset = New DataSet()
            adapter.Fill(dataset)
            dgvKhachhang.DataSource = dataset.Tables(0)
            connection.Close()
            dgvKhachhang.Columns("Makh").HeaderText = "Mã khách hàng"
            dgvKhachhang.Columns("Hoten").HeaderText = "Tên khách hàng"
            dgvKhachhang.Columns("Diachi").HeaderText = "Địa chỉ"
            dgvKhachhang.Columns("Sdt").HeaderText = "Số điện thoại"
            dgvKhachhang.Columns("Diachi").Width = 280 'Chỉnh rộng cột địa chi
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        If txtHoten.Text = "" Then
            MsgBox("Nhập họ tên")
        ElseIf txtDiachi.Text = "" Then
            MsgBox("Nhập địa chỉ")
        ElseIf txtSdt.Text = "" Then
            MsgBox("Nhập sđt")
        Else
            Try

                Dim sql As String = "INSERT INTO KHACHHANG (Hoten,Diachi,Sdt) VALUES(N'" & txtHoten.Text & "',N'" & txtDiachi.Text & "',N'" & txtSdt.Text & "')"

                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Thêm khách hàng thành công")
                LoadDatagridview()
                txtMakh.Clear()
                txtHoten.Clear()
                txtDiachi.Clear()
                txtSdt.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub


    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If dgvKhachhang.SelectedRows.Count > 0 Then
            Try
                Dim i As Integer = dgvKhachhang.CurrentRow.Index
                Dim Makh As String = dgvKhachhang.Rows(i).Cells("Makh").Value

                Dim sql As String = "DELETE FROM KHACHHANG WHERE MaKh='" & Makh & "'"

                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Xóa khách hàng thành công")
                LoadDatagridview()
                txtMakh.Clear()
                txtHoten.Clear()
                txtDiachi.Clear()
                txtSdt.Clear()
            Catch ex As Exception
                MsgBox("Đã tồn tại khách hàng trong hóa đơn nên không thể xóa")
            End Try
        Else
            MsgBox("Chọn khách cần xóa")
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If txtHoten.Text = "" Then
            MsgBox("Nhập họ tên")
        ElseIf txtDiachi.Text = "" Then
            MsgBox("Nhập địa chỉ")
        ElseIf txtSdt.Text = "" Then
            MsgBox("Nhập sđt")
        Else
            Try
                Dim sql As String = " UPDATE KHACHHANG SET Hoten= N'" + txtHoten.Text + "',Diachi= N'" + txtDiachi.Text + "',Sdt= '" + txtSdt.Text + "'WHERE MaKh='" + txtMakh.Text + "'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Sửa khách hàng thành công")
                LoadDatagridview()
                txtMakh.Clear()
                txtHoten.Clear()
                txtDiachi.Clear()
                txtSdt.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnTimkiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimkiem.Click
        If txtTimkiem.Text = "" Then
            MsgBox("Nhập tên khách hàng cần tìm")
        Else
            Try
                Dim sql As String = "SELECT * FROM KHACHHANG WHERE Hoten LIKE  '%" & txtTimkiem.Text & "%'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
                Dim dataset = New DataSet()
                adapter.Fill(dataset)
                dgvKhachhang.DataSource = dataset.Tables(0)
                connection.Close()

                dgvKhachhang.Columns("Diachi").Width = 280
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub dgvKhachhang_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvKhachhang.CellClick
        Dim i As Integer = dgvKhachhang.CurrentRow.Index
        txtMakh.Text = dgvKhachhang.Rows(i).Cells(0).Value.ToString()
        txtHoten.Text = dgvKhachhang.Rows(i).Cells(1).Value.ToString()
        txtDiachi.Text = dgvKhachhang.Rows(i).Cells(2).Value.ToString()
        txtSdt.Text = dgvKhachhang.Rows(i).Cells(3).Value.ToString()
    End Sub

    Private Sub KhachHang_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()

            Dim adapter1 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM KHACHHANG", connection)
            Dim dataset1 = New DataSet()
            adapter1.Fill(dataset1)
            HoaDon.cbMakh.DataSource = dataset1.Tables(0)
            HoaDon.cbMakh.DisplayMember = "Hoten"
            HoaDon.cbMakh.ValueMember = "Makh"
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Sub
End Class
