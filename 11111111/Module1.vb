Module Module1
    Public FedAIR As Double = 25
    Public FEDGROUND As Double = 2
    Public USportal As Double = 12
    Public wholesale As Single = 0.1
    Public PurchasePrice, CostoFExtras, QuantityPurchase, Shippingcost, Discount, Saletax, Subtotal, TotalDue As Single
    Public Ddiscount, qquantitypurchase As Single
    Public taxrate As Double
    Public Clubmembership As Integer = 150
    Public OneyearWarranty As Integer = 75
    Public Tiresale As Integer = 25


    Public Function COX() As Double
        CostoFExtras = OneyearWarranty + Clubmembership + Tiresale
        Return CostoFExtras
    End Function
    Public Function Subtots() As Single
        Subtotal = (PurchasePrice * QuantityPurchase) + Shippingcost + CostoFExtras - Discount
        Return Subtotal
    End Function
    Public Function salestx() As Single
        Saletax = Subtotal * taxrate
        Return Saletax
    End Function
    Public Function Totalue() As Single
        TotalDue = Subtots() + salestx()
        Return TotalDue
    End Function

End Module
