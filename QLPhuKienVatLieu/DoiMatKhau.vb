Imports System.Data.OleDb

Public Class frmDoiMatKhau
    Dim connetionString As String = "Provider=SQLOLEDB.1;Data Source=SGVULJMJH208ZX7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QLPKVL"

    Private Sub btnXacnhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXacnhan.Click
        If txtTendangnhap.Text = "" Then
            MsgBox("Nhập tên đăng nhập")
        ElseIf txtPasscu.Text = "" Then
            MsgBox("Nhập mật khẩu cũ")
        ElseIf txtPassmoi.Text = "" Then
            MsgBox("Nhập mật khẩu mới")
        ElseIf txtNhaplaipassmoi.Text = "" Then
            MsgBox("Nhập lại mật khẩu mới")
        ElseIf txtPassmoi.Text <> txtNhaplaipassmoi.Text Then
            MsgBox("Mật khẩu nhập lại không trùng khớp")
        Else
            Try
                Dim sql As String = "UPDATE NHANVIEN SET Pass='" + txtPassmoi.Text + "' WHERE Tendangnhap='" + txtTendangnhap.Text + "' AND Pass='" + txtPasscu.Text + "'"
                Dim connection As OleDbConnection = New OleDbConnection(connetionString)
                connection.Open()
                Dim command As OleDbCommand = New OleDbCommand(sql, connection)
                If command.ExecuteNonQuery() <> 0 Then
                    connection.Close()
                    MsgBox("Thay đổi mật khẩu thành công")
                    Me.Close()
                Else
                    MsgBox("Thay đổi mật khẩu thất bại. Kiểm tra lại các thông tin")
                End If


            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If

    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub
End Class