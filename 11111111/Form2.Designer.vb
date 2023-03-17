<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CHB_Tire = New System.Windows.Forms.CheckBox()
        Me.CHB_Club = New System.Windows.Forms.CheckBox()
        Me.CHB_ONEyear = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBT_USpostal = New System.Windows.Forms.RadioButton()
        Me.RBT_fed_ExGround = New System.Windows.Forms.RadioButton()
        Me.RBT_fedEXAIR = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBT_Retail = New System.Windows.Forms.RadioButton()
        Me.RBT_wholesale = New System.Windows.Forms.RadioButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(531, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CHB_Tire)
        Me.GroupBox3.Controls.Add(Me.CHB_Club)
        Me.GroupBox3.Controls.Add(Me.CHB_ONEyear)
        Me.GroupBox3.Location = New System.Drawing.Point(738, 114)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 111)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'CHB_Tire
        '
        Me.CHB_Tire.AutoSize = True
        Me.CHB_Tire.Location = New System.Drawing.Point(51, 81)
        Me.CHB_Tire.Name = "CHB_Tire"
        Me.CHB_Tire.Size = New System.Drawing.Size(69, 19)
        Me.CHB_Tire.TabIndex = 2
        Me.CHB_Tire.Text = "Tire Sale"
        Me.CHB_Tire.UseVisualStyleBackColor = True
        '
        'CHB_Club
        '
        Me.CHB_Club.AutoSize = True
        Me.CHB_Club.Location = New System.Drawing.Point(51, 56)
        Me.CHB_Club.Name = "CHB_Club"
        Me.CHB_Club.Size = New System.Drawing.Size(124, 19)
        Me.CHB_Club.TabIndex = 1
        Me.CHB_Club.Text = "Club MemberSHip"
        Me.CHB_Club.UseVisualStyleBackColor = True
        '
        'CHB_ONEyear
        '
        Me.CHB_ONEyear.AutoSize = True
        Me.CHB_ONEyear.Location = New System.Drawing.Point(51, 26)
        Me.CHB_ONEyear.Name = "CHB_ONEyear"
        Me.CHB_ONEyear.Size = New System.Drawing.Size(124, 19)
        Me.CHB_ONEyear.TabIndex = 0
        Me.CHB_ONEyear.Text = "One Year Warranty"
        Me.CHB_ONEyear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBT_USpostal)
        Me.GroupBox2.Controls.Add(Me.RBT_fed_ExGround)
        Me.GroupBox2.Controls.Add(Me.RBT_fedEXAIR)
        Me.GroupBox2.Location = New System.Drawing.Point(432, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 111)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RBT_USpostal
        '
        Me.RBT_USpostal.AutoSize = True
        Me.RBT_USpostal.Location = New System.Drawing.Point(34, 86)
        Me.RBT_USpostal.Name = "RBT_USpostal"
        Me.RBT_USpostal.Size = New System.Drawing.Size(77, 19)
        Me.RBT_USpostal.TabIndex = 2
        Me.RBT_USpostal.TabStop = True
        Me.RBT_USpostal.Text = "U.S Postal"
        Me.RBT_USpostal.UseVisualStyleBackColor = True
        '
        'RBT_fed_ExGround
        '
        Me.RBT_fed_ExGround.AutoSize = True
        Me.RBT_fed_ExGround.Location = New System.Drawing.Point(34, 55)
        Me.RBT_fed_ExGround.Name = "RBT_fed_ExGround"
        Me.RBT_fed_ExGround.Size = New System.Drawing.Size(102, 19)
        Me.RBT_fed_ExGround.TabIndex = 1
        Me.RBT_fed_ExGround.TabStop = True
        Me.RBT_fed_ExGround.Text = "Fed Ex Ground"
        Me.RBT_fed_ExGround.UseVisualStyleBackColor = True
        '
        'RBT_fedEXAIR
        '
        Me.RBT_fedEXAIR.AutoSize = True
        Me.RBT_fedEXAIR.Location = New System.Drawing.Point(34, 30)
        Me.RBT_fedEXAIR.Name = "RBT_fedEXAIR"
        Me.RBT_fedEXAIR.Size = New System.Drawing.Size(77, 19)
        Me.RBT_fedEXAIR.TabIndex = 0
        Me.RBT_fedEXAIR.TabStop = True
        Me.RBT_fedEXAIR.Text = "Fed Ex AIr"
        Me.RBT_fedEXAIR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBT_Retail)
        Me.GroupBox1.Controls.Add(Me.RBT_wholesale)
        Me.GroupBox1.Location = New System.Drawing.Point(186, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RBT_Retail
        '
        Me.RBT_Retail.AutoSize = True
        Me.RBT_Retail.Location = New System.Drawing.Point(34, 65)
        Me.RBT_Retail.Name = "RBT_Retail"
        Me.RBT_Retail.Size = New System.Drawing.Size(54, 19)
        Me.RBT_Retail.TabIndex = 1
        Me.RBT_Retail.TabStop = True
        Me.RBT_Retail.Text = "Retail"
        Me.RBT_Retail.UseVisualStyleBackColor = True
        '
        'RBT_wholesale
        '
        Me.RBT_wholesale.AutoSize = True
        Me.RBT_wholesale.Location = New System.Drawing.Point(34, 30)
        Me.RBT_wholesale.Name = "RBT_wholesale"
        Me.RBT_wholesale.Size = New System.Drawing.Size(83, 19)
        Me.RBT_wholesale.TabIndex = 0
        Me.RBT_wholesale.TabStop = True
        Me.RBT_wholesale.Text = "Whole Sale"
        Me.RBT_wholesale.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 659)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CHB_Tire As CheckBox
    Friend WithEvents CHB_Club As CheckBox
    Friend WithEvents CHB_ONEyear As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBT_USpostal As RadioButton
    Friend WithEvents RBT_fed_ExGround As RadioButton
    Friend WithEvents RBT_fedEXAIR As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBT_Retail As RadioButton
    Friend WithEvents RBT_wholesale As RadioButton
End Class
