<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Givelone
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Givelone))
        Me.OK_Button = New System.Windows.Forms.Button
        Me.amount = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Password_text = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Step2_Panel = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.transpin = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Step1_Panal = New System.Windows.Forms.Panel
        Me.step_1button = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Step2_Panel.SuspendLayout()
        Me.Step1_Panal.SuspendLayout()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(373, 63)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(133, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'amount
        '
        Me.amount.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.Location = New System.Drawing.Point(167, 59)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(29, 23)
        Me.amount.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dough to return:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Deposit the money you have taken. Enter the amount that you wish to return. "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Administrator Password:"
        '
        'Password_text
        '
        Me.Password_text.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_text.Location = New System.Drawing.Point(173, 65)
        Me.Password_text.Name = "Password_text"
        Me.Password_text.Size = New System.Drawing.Size(100, 23)
        Me.Password_text.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Step 2 - Complete transaction"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-3, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Step 1 - Generate request"
        '
        'Step2_Panel
        '
        Me.Step2_Panel.BackColor = System.Drawing.Color.Transparent
        Me.Step2_Panel.Controls.Add(Me.Label15)
        Me.Step2_Panel.Controls.Add(Me.transpin)
        Me.Step2_Panel.Controls.Add(Me.Label10)
        Me.Step2_Panel.Controls.Add(Me.Password_text)
        Me.Step2_Panel.Controls.Add(Me.Label12)
        Me.Step2_Panel.Controls.Add(Me.Label3)
        Me.Step2_Panel.Controls.Add(Me.OK_Button)
        Me.Step2_Panel.Location = New System.Drawing.Point(35, 157)
        Me.Step2_Panel.Name = "Step2_Panel"
        Me.Step2_Panel.Size = New System.Drawing.Size(549, 99)
        Me.Step2_Panel.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(63, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Your transaction pin:"
        '
        'transpin
        '
        Me.transpin.AutoSize = True
        Me.transpin.Location = New System.Drawing.Point(173, 49)
        Me.transpin.Name = "transpin"
        Me.transpin.Size = New System.Drawing.Size(44, 13)
        Me.transpin.TabIndex = 27
        Me.transpin.Text = "transpin"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(12, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Please compleate Step 1 to contiune."
        '
        'Step1_Panal
        '
        Me.Step1_Panal.BackColor = System.Drawing.Color.Transparent
        Me.Step1_Panal.Controls.Add(Me.step_1button)
        Me.Step1_Panal.Controls.Add(Me.Label4)
        Me.Step1_Panal.Controls.Add(Me.amount)
        Me.Step1_Panal.Controls.Add(Me.Label11)
        Me.Step1_Panal.Controls.Add(Me.Label1)
        Me.Step1_Panal.Location = New System.Drawing.Point(35, 27)
        Me.Step1_Panal.Name = "Step1_Panal"
        Me.Step1_Panal.Size = New System.Drawing.Size(549, 109)
        Me.Step1_Panal.TabIndex = 25
        '
        'step_1button
        '
        Me.step_1button.Location = New System.Drawing.Point(373, 54)
        Me.step_1button.Name = "step_1button"
        Me.step_1button.Size = New System.Drawing.Size(133, 23)
        Me.step_1button.TabIndex = 28
        Me.step_1button.Text = "Button1"
        Me.step_1button.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Mention the lone amount you want to returen."
        '
        'Givelone
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B_Bank.My.Resources.Resources.Background_image
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(608, 282)
        Me.Controls.Add(Me.Step2_Panel)
        Me.Controls.Add(Me.Step1_Panal)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Givelone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Give lone"
        Me.Step2_Panel.ResumeLayout(False)
        Me.Step2_Panel.PerformLayout()
        Me.Step1_Panal.ResumeLayout(False)
        Me.Step1_Panal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents amount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Password_text As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Step2_Panel As System.Windows.Forms.Panel
    Friend WithEvents Step1_Panal As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents transpin As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents step_1button As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
