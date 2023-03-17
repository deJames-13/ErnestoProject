Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim row As Integer

        row = DataGridView3.Rows.Add()


        DataGridView3.Item("Namee", row).Value = Form1.nameee
        DataGridView3.Item("Telephonee", row).Value = Form1.Telephone
        DataGridView3.Item("Shippingg", row).Value = Form1.Shipping
        DataGridView3.Item("Product", row).Value = Form1.product
        DataGridView3.Item("Quantityy", row).Value = Form1.txt_QualityPurchased


        DataGridView3.Item("SHC", row).Value = Shippingcost
        DataGridView3.Item("COE", row).Value = COX()
        DataGridView3.Item("DC", row).Value = Discount
        DataGridView3.Item("ST", row).Value = Subtotal
        DataGridView3.Item("STT", row).Value = salestx()
        DataGridView3.Item("TD", row).Value = Totalue()

        DataGridView3.Item("SHC2", row).Value = Shippingcost
        DataGridView3.Item("COE2", row).Value = COX()
        DataGridView3.Item("DC2", row).Value = Discount
        DataGridView3.Item("ST2", row).Value = Subtotal
        DataGridView3.Item("STT2", row).Value = salestx()
        DataGridView3.Item("TD2", row).Value = Totalue()


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class