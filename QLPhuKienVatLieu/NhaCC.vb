Imports System.Data.OleDb

Public Class NhaCC
    Dim connetionString As String = "Provider=SQLOLEDB.1;Data Source=SGVULJMJH208ZX7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QLPKVL"

    Private Sub NhaCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDatagridview()
    End Sub

    Private Sub LoadDatagridview()
        Try
            Dim sql As String = "SELECT * FROM NHACC"

            Dim connection As OleDbConnection = New OleDbConnection(connetionString)
            connection.Open()
            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
            Dim dataset = New DataSet()
            adapter.Fill(dataset)
            dgvNhacungcap.DataSource = dataset.Tables(0)
            connection.Close()
            dgvNhacungcap.Columns("Mancc").HeaderText = "Mã nhà cung cấp"
            dgvNhacungcap.Columns("Tenncc").HeaderText = "Tên nhà cung cấp"
            dgvNhacungcap.Columns("Diachi").HeaderText = "Địa chỉ"
            dgvNhacungcap.Columns("Sdt").HeaderText = "Số điện thoại"
            dgvNhacungcap.Columns("Tenncc").Width = 200
            dgvNhacungcap.Columns("Diachi").Width = 240
            dgvNhacungcap.Columns("Mancc").Width = 120
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub dgvNhacungcap_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNhacungcap.CellClick
        Dim i As Integer = dgvNhacungcap.CurrentRow.Index
        txtMancc.Text = dgvNhacungcap.Rows(i).Cells(0).Value.ToString()
        txtTenncc.Text = dgvNhacungcap.Rows(i).Cells(1).Value.ToString()
        txtDiachi.Text = dgvNhacungcap.Rows(i).Cells(2).Value.ToString()
        txtSdt.Text = dgvNhacungcap.Rows(i).Cells(3).Value.ToString()
    End Sub


    Private Sub btnTimkiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimkiem.Click
        If txtTimkiem.Text = "" Then
            MsgBox("Nhập tên nhà cung cấp cần tìm")
        Else
            Try
                Dim sql As String = "SELECT * FROM NHACC WHERE Tenncc LIKE  '%" & txtTimkiem.Text & "%'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
                Dim dataset = New DataSet()
                adapter.Fill(dataset)
                dgvNhacungcap.DataSource = dataset.Tables(0)
                connection.Close()

                dgvNhacungcap.Columns("Tenncc").Width = 200
                dgvNhacungcap.Columns("Diachi").Width = 240
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        If dgvNhacungcap.SelectedRows.Count > 0 Then
            Try
                Dim i As Integer = dgvNhacungcap.CurrentRow.Index
                Dim Mancc As String = dgvNhacungcap.Rows(i).Cells("Mancc").Value

                Dim sql As String = "DELETE FROM NHACC WHERE Mancc='" & Mancc & "'"

                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Xóa nhà cung cấp thành công")
                LoadDatagridview()
                txtMancc.Clear()
                txtTenncc.Clear()
                txtDiachi.Clear()
                txtSdt.Clear()
            Catch ex As Exception
                MsgBox("Đã tồn tại nhà cung cấp trong các phiếu nhập nên không thể xóa")
            End Try
        Else
            MsgBox("Chọn nhà cung cấp cần xóa")
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        If txtTenncc.Text = "" Then
            MsgBox("Nhập tên nhà cung cấp")
        ElseIf txtDiachi.Text = "" Then
            MsgBox("Nhập địa chỉ nhà cung cấp")
        ElseIf txtSdt.Text = "" Then
            MsgBox("Nhập sđt nhà cung cấp")
        Else
            Try
                Dim sql As String = " UPDATE NHACC SET Tenncc= N'" + txtTenncc.Text + "',Diachi= N'" + txtDiachi.Text + "',Sdt= '" + txtSdt.Text + "'WHERE Mancc='" + txtMancc.Text + "'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Sửa nhà cung cấp thành công")
                LoadDatagridview()
                txtMancc.Clear()
                txtTenncc.Clear()
                txtDiachi.Clear()
                txtSdt.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        If txtTenncc.Text = "" Then
            MsgBox("Nhập tên nhà cung cấp")
        ElseIf txtDiachi.Text = "" Then
            MsgBox("Nhập địa chỉ nhà cung cấp")
        ElseIf txtSdt.Text = "" Then
            MsgBox("Nhập sđt nhà cung cấp")
        Else
            Try
                Dim sql As String = "INSERT INTO NHACC(Tenncc,Diachi,Sdt) VALUES(N'" & txtTenncc.Text & "',N'" & txtDiachi.Text & "',N'" & txtSdt.Text & "')"
                
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                command.ExecuteNonQuery()
                connection.Close()

                MsgBox("Thêm nhà cung cấp thành công")
                LoadDatagridview()
                txtMancc.Clear()
                txtTenncc.Clear()
                txtDiachi.Clear()
                txtSdt.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub NhaCC_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Dim connection1 As OleDbConnection = New OleDbConnection(connetionString)
            connection1.Open()
            Dim adapter1 As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM NHACC", connection1)
            Dim dataset1 = New DataSet()
            adapter1.Fill(dataset1)
            PhieuNhap.cbMancc.DataSource = dataset1.Tables(0)
            PhieuNhap.cbMancc.DisplayMember = "Tenncc"
            PhieuNhap.cbMancc.ValueMember = "Mancc"
            PhieuNhap.cbMancc.Refresh()
            connection1.Close()
           
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Sub
End Class