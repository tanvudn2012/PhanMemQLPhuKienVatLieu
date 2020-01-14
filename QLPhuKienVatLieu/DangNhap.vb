Imports System.Data.OleDb

Public Class frmDangNhap
    Dim connetionString As String = "Provider=SQLOLEDB.1;Data Source=SGVULJMJH208ZX7\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=QLPKVL"
    Dim connection As OleDbConnection = New OleDbConnection(connetionString)

    Public Shared Manhanvien As String = ""

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDangNhap.Click
        If txtTendangnhap.Text = "" Then
            MsgBox("Nhập tên đăng nhập")
        ElseIf txtPass.Text = "" Then
            MsgBox("Nhập mật khẩu")
        Else
            Try
                Dim sql As String = "SELECT * FROM NHANVIEN WHERE Tendangnhap='" & txtTendangnhap.Text & "' AND Pass='" & txtPass.Text & "'"
                connection.Open()
                Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, connection)
                Dim dataset = New DataSet()
                adapter.Fill(dataset)

                If dataset.Tables(0).Rows.Count > 0 Then

                    Manhanvien = dataset.Tables(0).Rows(0)("Manhanvien")

                    frmMain.Show()
                    Me.Hide()

                    dataset.Clear()
                    connection.Close()
                Else
                    MsgBox("Đăng nhập thất bại")
                    dataset.Clear()
                    connection.Close()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try

            
        End If

    End Sub

End Class
