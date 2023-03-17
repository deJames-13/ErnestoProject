<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SHC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SHC, Me.COE, Me.DC, Me.ST, Me.STT, Me.TD})
        Me.DataGridView1.Location = New System.Drawing.Point(77, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(644, 516)
        Me.DataGridView1.TabIndex = 0
        '
        'SHC
        '
        Me.SHC.HeaderText = "Shipping Cost"
        Me.SHC.Name = "SHC"
        '
        'COE
        '
        Me.COE.HeaderText = "Cost of Extras"
        Me.COE.Name = "COE"
        '
        'DC
        '
        Me.DC.HeaderText = "Discount"
        Me.DC.Name = "DC"
        '
        'ST
        '
        Me.ST.HeaderText = "Subtotal"
        Me.ST.Name = "ST"
        '
        'STT
        '
        Me.STT.HeaderText = "Sale Tax"
        Me.STT.Name = "STT"
        '
        'TD
        '
        Me.TD.HeaderText = "Total Due"
        Me.TD.Name = "TD"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(834, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(985, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 672)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.Text = "Whole Sale"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SHC As DataGridViewTextBoxColumn
    Friend WithEvents COE As DataGridViewTextBoxColumn
    Friend WithEvents DC As DataGridViewTextBoxColumn
    Friend WithEvents ST As DataGridViewTextBoxColumn
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents TD As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
