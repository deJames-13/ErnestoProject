<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_QualityPurchased = New System.Windows.Forms.TextBox()
        Me.txt_PurchasePrice = New System.Windows.Forms.TextBox()
        Me.txt_ProductIdentifier = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_telephone = New System.Windows.Forms.TextBox()
        Me.txt_shipping = New System.Windows.Forms.TextBox()
        Me.txt_CustomName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_QualityPurchased)
        Me.GroupBox1.Controls.Add(Me.txt_PurchasePrice)
        Me.GroupBox1.Controls.Add(Me.txt_ProductIdentifier)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_telephone)
        Me.GroupBox1.Controls.Add(Me.txt_shipping)
        Me.GroupBox1.Controls.Add(Me.txt_CustomName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(631, 472)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txt_QualityPurchased
        '
        Me.txt_QualityPurchased.Location = New System.Drawing.Point(300, 270)
        Me.txt_QualityPurchased.Name = "txt_QualityPurchased"
        Me.txt_QualityPurchased.Size = New System.Drawing.Size(100, 23)
        Me.txt_QualityPurchased.TabIndex = 17
        '
        'txt_PurchasePrice
        '
        Me.txt_PurchasePrice.Location = New System.Drawing.Point(300, 219)
        Me.txt_PurchasePrice.Name = "txt_PurchasePrice"
        Me.txt_PurchasePrice.Size = New System.Drawing.Size(100, 23)
        Me.txt_PurchasePrice.TabIndex = 16
        '
        'txt_ProductIdentifier
        '
        Me.txt_ProductIdentifier.Location = New System.Drawing.Point(300, 170)
        Me.txt_ProductIdentifier.Name = "txt_ProductIdentifier"
        Me.txt_ProductIdentifier.Size = New System.Drawing.Size(100, 23)
        Me.txt_ProductIdentifier.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = " Quantity Purchased"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Purchase Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Product Identifier"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(305, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_telephone
        '
        Me.txt_telephone.Location = New System.Drawing.Point(128, 120)
        Me.txt_telephone.Name = "txt_telephone"
        Me.txt_telephone.Size = New System.Drawing.Size(382, 23)
        Me.txt_telephone.TabIndex = 5
        '
        'txt_shipping
        '
        Me.txt_shipping.Location = New System.Drawing.Point(128, 74)
        Me.txt_shipping.Name = "txt_shipping"
        Me.txt_shipping.Size = New System.Drawing.Size(382, 23)
        Me.txt_shipping.TabIndex = 4
        '
        'txt_CustomName
        '
        Me.txt_CustomName.Location = New System.Drawing.Point(128, 30)
        Me.txt_CustomName.Name = "txt_CustomName"
        Me.txt_CustomName.Size = New System.Drawing.Size(382, 23)
        Me.txt_CustomName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telephone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shipping Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 647)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_telephone As TextBox
    Friend WithEvents txt_shipping As TextBox
    Friend WithEvents txt_CustomName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_QualityPurchased As TextBox
    Friend WithEvents txt_PurchasePrice As TextBox
    Friend WithEvents txt_ProductIdentifier As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
