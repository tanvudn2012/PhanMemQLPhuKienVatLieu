Imports System.Data.OleDb

Public Class Donvitinh
    Dim connetionString As String = "Provider=SQLOLEDB.1;Data Source=SGVULJMJH208ZX7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QLPKVL"

    Private Sub Donvitinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDatagridview()
    End Sub


    Private Sub LoadDatagridview()
        Try
            Dim sql As String = "SELECT * FROM DONVITINH"

            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()
            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
            Dim dataset = New DataSet()
            adapter.Fill(dataset)
            dgvDonvitinh.DataSource = dataset.Tables(0)
            connection.Close()

            dgvDonvitinh.Columns("Tendonvitinh").Width = 300
            dgvDonvitinh.Columns("Tendonvitinh").HeaderText = "Tên đơn vị tính"
            dgvDonvitinh.Columns("Madonvitinh").Width = 150
            dgvDonvitinh.Columns("Madonvitinh").HeaderText = "Mã đơn vị tính"
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        If txtTendonvitinh.Text = "" Then
            MsgBox("Nhập tên đơn vị tính")
        Else
            Try
                Dim sql As String = "INSERT INTO DONVITINH(Tendonvitinh) VALUES(N'" & txtTendonvitinh.Text & "')"

                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Thêm đơn vị tính thành công")
                LoadDatagridview()
                txtMadonvitinh.Clear()
                txtTendonvitinh.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub dgvDonvitinh_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDonvitinh.CellClick
        Dim i As Integer = dgvDonvitinh.CurrentRow.Index
        txtMadonvitinh.Text = dgvDonvitinh.Rows(i).Cells("Madonvitinh").Value.ToString()
        txtTendonvitinh.Text = dgvDonvitinh.Rows(i).Cells("Tendonvitinh").Value.ToString()
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If dgvDonvitinh.SelectedRows.Count > 0 Then
            Try
                Dim i As Integer = dgvDonvitinh.CurrentRow.Index
                Dim Madonvitinh As String = dgvDonvitinh.Rows(i).Cells("Madonvitinh").Value()

                Dim sql As String = "DELETE FROM DONVITINH WHERE Madonvitinh='" & Madonvitinh & "'"

                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Xóa đơn vị tính thành công")
                LoadDatagridview()
                txtMadonvitinh.Clear()
                txtTendonvitinh.Clear()
            Catch ex As Exception
                MsgBox("Đã tồn tại đơn vị tính trong sản phẩm này nên không thể xóa")
            End Try
        Else
            MsgBox("Chọn đơn vị tính cần xóa")
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If txtTendonvitinh.Text = "" Then
            MsgBox("Nhập tên đơn vị tính")
        Else
            Try
                Dim sql As String = " UPDATE DONVITINH SET Tendonvitinh= N'" + txtTendonvitinh.Text + "' WHERE Madonvitinh='" + txtMadonvitinh.Text + "'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Sửa đơn vị tính thành công")
                LoadDatagridview()
                txtMadonvitinh.Clear()
                txtTendonvitinh.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnTimkiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimkiem.Click
        If txtTimkiem.Text = "" Then
            MsgBox("Nhập tên đơn vị cần tìm")
        Else
            Try
                Dim sql As String = "SELECT * FROM DONVITINH WHERE Tendonvitinh LIKE '%" & txtTimkiem.Text & "%'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
                Dim dataset = New DataSet()
                adapter.Fill(dataset)
                dgvDonvitinh.DataSource = dataset.Tables(0)
                connection.Close()

                dgvDonvitinh.Columns("Madonvitinh").Width = 170
                dgvDonvitinh.Columns("Tendonvitinh").Width = 200
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Donvitinh_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        dgvDonvitinh.DataSource = Nothing
        dgvDonvitinh.Rows.Clear()
        dgvDonvitinh.Refresh()

        Dim connection As OleDbConnection = New OleDbConnection(connetionString)
        connection.Open()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM DONVITINH", connection)
        Dim dataset = New DataSet()
        adapter.Fill(dataset)
        SanPham.cbMadonvitinh.DataSource = dataset.Tables(0)
        SanPham.cbMadonvitinh.DisplayMember = "Tendonvitinh"
        SanPham.cbMadonvitinh.ValueMember = "Madonvitinh"
    End Sub
End Class