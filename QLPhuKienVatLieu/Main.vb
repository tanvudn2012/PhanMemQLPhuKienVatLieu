Public Class frmMain


    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PhieuNhap.Show()
        Me.Hide()
    End Sub

    Private Sub lblThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblThoat.Click
        If MsgBox(" Bạn có muốn thoát không !!!! ", vbQuestion + vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub lblDoiMatKhau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDoiMatKhau.Click
        frmDoiMatKhau.ShowDialog()
    End Sub

    Private Sub lblThongTinKhachHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblThongTinKhachHang.Click
        KhachHang.ShowDialog()
    End Sub

    Private Sub lblNhaCungCap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNhaCungCap.Click
        NhaCC.ShowDialog()
    End Sub

    Private Sub lblSanPham_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSanPham.Click
        SanPham.ShowDialog()
    End Sub

    Private Sub lblPhieuNhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPhieuNhap.Click
        PhieuNhap.ShowDialog()
    End Sub

    Private Sub lblHoaDon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHoaDon.Click
        HoaDon.ShowDialog()
    End Sub

    Private Sub lblLoaiSanPham_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLoaiSanPham.Click
        LoaiSanPham.ShowDialog()
    End Sub

    Private Sub lblThongkebaocao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblThongkebaocao.Click
        Baocaobanhangvb.ShowDialog()
    End Sub

    Private Sub lblDonvitinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDonvitinh.Click
        Donvitinh.ShowDialog()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Baocaonhaphang.ShowDialog()
    End Sub
End Class