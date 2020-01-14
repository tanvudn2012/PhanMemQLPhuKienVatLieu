Public Class Baocaonhaphang

    Private Sub Baocaonhaphang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Dim batdau As DateTime = Convert.ToDateTime(dtpBatdau.Text)
        Dim ketthuc As DateTime = Convert.ToDateTime(dtpKetthuc.Text)

        'TODO: This line of code loads data into the 'DataSet1.BaoCaoNhapKho' table. You can move, or remove it, as needed.
        Me.BaoCaoNhapKhoTableAdapter.Fill(Me.DataSet1.BaoCaoNhapKho, batdau, ketthuc)

        Me.ReportViewer2.RefreshReport()
    End Sub
End Class