Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As Integer

        row = DataGridView1.Rows.Add()

        DataGridView1.Item("SHC", row).Value = Shippingcost
        DataGridView1.Item("COE", row).Value = COX()
        DataGridView1.Item("DC", row).Value = Discount
        DataGridView1.Item("ST", row).Value = Subtotal
        DataGridView1.Item("STT", row).Value = salestx()
        DataGridView1.Item("TD", row).Value = Totalue()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub
End Class