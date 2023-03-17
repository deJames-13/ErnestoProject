<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Namee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telephonee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Shippingg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantityy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHC2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COE2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DC2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Namee, Me.Telephonee, Me.Shippingg, Me.Product, Me.Quantityy, Me.SHC, Me.COE, Me.DC, Me.ST, Me.STT, Me.TD, Me.SHC2, Me.COE2, Me.DC2, Me.ST2, Me.STT2, Me.TD2})
        Me.DataGridView3.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 25
        Me.DataGridView3.Size = New System.Drawing.Size(1237, 508)
        Me.DataGridView3.TabIndex = 0
        '
        'Namee
        '
        Me.Namee.HeaderText = "Customer Name"
        Me.Namee.Name = "Namee"
        '
        'Telephonee
        '
        Me.Telephonee.HeaderText = "Telephone"
        Me.Telephonee.Name = "Telephonee"
        '
        'Shippingg
        '
        Me.Shippingg.HeaderText = "Shipping addressed"
        Me.Shippingg.Name = "Shippingg"
        '
        'Product
        '
        Me.Product.HeaderText = "Product Identifier"
        Me.Product.Name = "Product"
        '
        'Quantityy
        '
        Me.Quantityy.HeaderText = "Quantity "
        Me.Quantityy.Name = "Quantityy"
        '
        'SHC
        '
        Me.SHC.HeaderText = "(Whole Sale) Shipping Cost"
        Me.SHC.Name = "SHC"
        '
        'COE
        '
        Me.COE.HeaderText = "(Whole Sale) Cost of Extras"
        Me.COE.Name = "COE"
        '
        'DC
        '
        Me.DC.HeaderText = "(Whole Sale) Discount"
        Me.DC.Name = "DC"
        '
        'ST
        '
        Me.ST.HeaderText = "(Whole Sale) Sub Total"
        Me.ST.Name = "ST"
        '
        'STT
        '
        Me.STT.HeaderText = "(Whole Sale) Sales Tax"
        Me.STT.Name = "STT"
        '
        'TD
        '
        Me.TD.HeaderText = "(Whole Sale) Total Due"
        Me.TD.Name = "TD"
        '
        'SHC2
        '
        Me.SHC2.HeaderText = "(Retail) Shipping Cost"
        Me.SHC2.Name = "SHC2"
        '
        'COE2
        '
        Me.COE2.HeaderText = "(Retail) Cost of Extras"
        Me.COE2.Name = "COE2"
        '
        'DC2
        '
        Me.DC2.HeaderText = "(Retail) Discount"
        Me.DC2.Name = "DC2"
        '
        'ST2
        '
        Me.ST2.HeaderText = "(Retail) Sub Total"
        Me.ST2.Name = "ST2"
        '
        'STT2
        '
        Me.STT2.HeaderText = "(Retail) Sale Tax"
        Me.STT2.Name = "STT2"
        '
        'TD2
        '
        Me.TD2.HeaderText = "(Retail) Total Due"
        Me.TD2.Name = "TD2"
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(272, 585)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 1
        Me.Save.Text = "save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(594, 585)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 661)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.DataGridView3)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Namee As DataGridViewTextBoxColumn
    Friend WithEvents Telephonee As DataGridViewTextBoxColumn
    Friend WithEvents Shippingg As DataGridViewTextBoxColumn
    Friend WithEvents Product As DataGridViewTextBoxColumn
    Friend WithEvents Quantityy As DataGridViewTextBoxColumn
    Friend WithEvents SHC As DataGridViewTextBoxColumn
    Friend WithEvents COE As DataGridViewTextBoxColumn
    Friend WithEvents DC As DataGridViewTextBoxColumn
    Friend WithEvents ST As DataGridViewTextBoxColumn
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents TD As DataGridViewTextBoxColumn
    Friend WithEvents SHC2 As DataGridViewTextBoxColumn
    Friend WithEvents COE2 As DataGridViewTextBoxColumn
    Friend WithEvents DC2 As DataGridViewTextBoxColumn
    Friend WithEvents ST2 As DataGridViewTextBoxColumn
    Friend WithEvents STT2 As DataGridViewTextBoxColumn
    Friend WithEvents TD2 As DataGridViewTextBoxColumn
    Friend WithEvents Save As Button
    Friend WithEvents Button1 As Button
End Class
