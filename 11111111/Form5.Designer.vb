<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SHC2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COE2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DC2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ST2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SHC2, Me.COE2, Me.DC2, Me.ST2, Me.STT2, Me.TD2})
        Me.DataGridView2.Location = New System.Drawing.Point(79, 42)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(644, 516)
        Me.DataGridView2.TabIndex = 1
        '
        'SHC2
        '
        Me.SHC2.HeaderText = "Shipping Cost"
        Me.SHC2.Name = "SHC2"
        '
        'COE2
        '
        Me.COE2.HeaderText = "Cost of Extras"
        Me.COE2.Name = "COE2"
        '
        'DC2
        '
        Me.DC2.HeaderText = "Discount"
        Me.DC2.Name = "DC2"
        '
        'ST2
        '
        Me.ST2.HeaderText = "Subtotal"
        Me.ST2.Name = "ST2"
        '
        'STT2
        '
        Me.STT2.HeaderText = "Sale Tax"
        Me.STT2.Name = "STT2"
        '
        'TD2
        '
        Me.TD2.HeaderText = "Total Due"
        Me.TD2.Name = "TD2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(873, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(882, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(873, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 634)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "Form5"
        Me.Text = "Retail"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents SHC2 As DataGridViewTextBoxColumn
    Friend WithEvents COE2 As DataGridViewTextBoxColumn
    Friend WithEvents DC2 As DataGridViewTextBoxColumn
    Friend WithEvents ST2 As DataGridViewTextBoxColumn
    Friend WithEvents STT2 As DataGridViewTextBoxColumn
    Friend WithEvents TD2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
