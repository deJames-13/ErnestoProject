Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim row As Integer

        row = DataGridView2.Rows.Add()

        DataGridView2.Item("SHC2", row).Value = Shippingcost
        DataGridView2.Item("COE2", row).Value = COX()
        DataGridView2.Item("DC2", row).Value = Discount
        DataGridView2.Item("ST2", row).Value = Subtotal
        DataGridView2.Item("STT2", row).Value = salestx()
        DataGridView2.Item("TD2", row).Value = Totalue()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class