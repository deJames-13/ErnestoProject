Public Class Form2

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If (RBT_fedEXAIR.Checked = True) Then
            Shippingcost = FedAIR * QuantityPurchase
        ElseIf (RBT_fed_ExGround.Checked = True) Then
            Shippingcost = FEDGROUND * QuantityPurchase
        ElseIf (RBT_USpostal.Checked = True) Then
            Shippingcost = USportal * QuantityPurchase
        End If
        If (CHB_Club.Checked = True) Then
            CostoFExtras = CostoFExtras + OneyearWarranty
        End If
        If (CHB_ONEyear.Checked = True) Then
            CostoFExtras = CostoFExtras + Clubmembership
        End If
        If (CHB_Tire.Checked = True) Then
            CostoFExtras = CostoFExtras + Tiresale
        End If

        CostoFExtras = OneyearWarranty + Clubmembership + Tiresale

        If (RBT_wholesale.Checked = True) Then
            Discount = ((purchasePrice * QuantityPurchase) * wholesale)
        End If

        If (RBT_Retail.Checked = True) Then
            Discount = 0
        End If

        Form3.Show()

    End Sub


End Class