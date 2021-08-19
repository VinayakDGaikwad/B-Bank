<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class take_lone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(take_lone))
        Me.days = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.amount = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.step_1button = New System.Windows.Forms.Button
        Me.Step1_Panal = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Step2_Panel = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.transpin = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Password_Text = New System.Windows.Forms.TextBox
        Me.Step1_Panal.SuspendLayout()
        Me.Step2_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'days
        '
        Me.days.Location = New System.Drawing.Point(170, 62)
        Me.days.Name = "days"
        Me.days.Size = New System.Drawing.Size(118, 20)
        Me.days.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(58, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Lone Amount (in Rs):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(33, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Time for the lone (in days):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(448, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mention the lone amount and the time for the lone.  Please confirm before proceed" & _
            "ing. "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(131, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Rate:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(459, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Take Lone"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(170, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Rs.6"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(644, 391)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 3
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(170, 36)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(118, 20)
        Me.amount.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total lone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(170, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Please enter to number of days and lone Amount."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(84, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Final Interest:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(170, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "TOTAL_LONE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Step 2 - Complete transaction"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Step 1 - Generate request"
        '
        'step_1button
        '
        Me.step_1button.Location = New System.Drawing.Point(459, 151)
        Me.step_1button.Name = "step_1button"
        Me.step_1button.Size = New System.Drawing.Size(140, 23)
        Me.step_1button.TabIndex = 21
        Me.step_1button.Text = "Gerate requsets"
        Me.step_1button.UseVisualStyleBackColor = True
        '
        'Step1_Panal
        '
        Me.Step1_Panal.BackColor = System.Drawing.Color.Transparent
        Me.Step1_Panal.Controls.Add(Me.Label2)
        Me.Step1_Panal.Controls.Add(Me.Label4)
        Me.Step1_Panal.Controls.Add(Me.Label5)
        Me.Step1_Panal.Controls.Add(Me.step_1button)
        Me.Step1_Panal.Controls.Add(Me.Label6)
        Me.Step1_Panal.Controls.Add(Me.Label7)
        Me.Step1_Panal.Controls.Add(Me.Label3)
        Me.Step1_Panal.Controls.Add(Me.Label8)
        Me.Step1_Panal.Controls.Add(Me.Label1)
        Me.Step1_Panal.Controls.Add(Me.Label9)
        Me.Step1_Panal.Controls.Add(Me.days)
        Me.Step1_Panal.Controls.Add(Me.amount)
        Me.Step1_Panal.Location = New System.Drawing.Point(44, 28)
        Me.Step1_Panal.Name = "Step1_Panal"
        Me.Step1_Panal.Size = New System.Drawing.Size(662, 190)
        Me.Step1_Panal.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(-3, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Please compleate Step 1 to contiune."
        '
        'Step2_Panel
        '
        Me.Step2_Panel.BackColor = System.Drawing.Color.Transparent
        Me.Step2_Panel.Controls.Add(Me.Label15)
        Me.Step2_Panel.Controls.Add(Me.Label12)
        Me.Step2_Panel.Controls.Add(Me.transpin)
        Me.Step2_Panel.Controls.Add(Me.Label13)
        Me.Step2_Panel.Controls.Add(Me.Password_Text)
        Me.Step2_Panel.Controls.Add(Me.Button1)
        Me.Step2_Panel.Location = New System.Drawing.Point(44, 272)
        Me.Step2_Panel.Name = "Step2_Panel"
        Me.Step2_Panel.Size = New System.Drawing.Size(662, 107)
        Me.Step2_Panel.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(59, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Your transaction pin:"
        '
        'transpin
        '
        Me.transpin.AutoSize = True
        Me.transpin.Location = New System.Drawing.Point(169, 45)
        Me.transpin.Name = "transpin"
        Me.transpin.Size = New System.Drawing.Size(44, 13)
        Me.transpin.TabIndex = 5
        Me.transpin.Text = "transpin"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(70, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Transaction code:"
        '
        'Password_Text
        '
        Me.Password_Text.Location = New System.Drawing.Point(172, 75)
        Me.Password_Text.Name = "Password_Text"
        Me.Password_Text.Size = New System.Drawing.Size(100, 20)
        Me.Password_Text.TabIndex = 3
        '
        'take_lone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B_Bank.My.Resources.Resources.Background_image
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(729, 426)
        Me.Controls.Add(Me.Step2_Panel)
        Me.Controls.Add(Me.Step1_Panal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Cancel_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "take_lone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lone"
        Me.Step1_Panal.ResumeLayout(False)
        Me.Step1_Panal.PerformLayout()
        Me.Step2_Panel.ResumeLayout(False)
        Me.Step2_Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents days As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents amount As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents step_1button As System.Windows.Forms.Button
    Friend WithEvents Step1_Panal As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Step2_Panel As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Password_Text As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents transpin As System.Windows.Forms.Label

End Class
