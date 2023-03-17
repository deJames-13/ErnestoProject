Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_COX.Text = Module1.COX().ToString
        txt_discount.Text = Discount.ToString
        txt_shippingcost.Text = Shippingcost.ToString
        txt_saletax.Text = Module1.salestx().ToString
        txt_totaldue.Text = Module1.Totalue().ToString
        txt_subtotal.Text = Module1.Subtots().ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub
End Class