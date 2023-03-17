Public Class Form1
    Public nameee, Shipping, Telephone As String
    Public product As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nameee = txt_CustomName.Text
        Shipping = txt_shipping.Text
        Telephone = txt_telephone.Text
        product = txt_ProductIdentifier.Text
        PurchasePrice = txt_PurchasePrice.Text
        QuantityPurchase = txt_QualityPurchased.Text

        Form2.Show()
    End Sub
End Class
