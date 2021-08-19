<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add))
        Me.amount_text = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.step1_button = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Password_text = New System.Windows.Forms.TextBox
        Me.Step1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.transpin = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Step2 = New System.Windows.Forms.Panel
        Me.Step1.SuspendLayout()
        Me.Step2.SuspendLayout()
        Me.SuspendLayout()
        '
        'amount_text
        '
        Me.amount_text.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount_text.Location = New System.Drawing.Point(259, 65)
        Me.amount_text.Name = "amount_text"
        Me.amount_text.Size = New System.Drawing.Size(100, 23)
        Me.amount_text.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.amount_text, "Amount you want to add to your acount")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(498, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Deposit your saving in our bank. Enter the amount of money you want to deposit it" & _
            ". You will need " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the password form the administrator." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Step 1 - Generate request"
        '
        'step1_button
        '
        Me.step1_button.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.step1_button.Location = New System.Drawing.Point(444, 65)
        Me.step1_button.Name = "step1_button"
        Me.step1_button.Size = New System.Drawing.Size(133, 23)
        Me.step1_button.TabIndex = 10
        Me.step1_button.Text = "Vinayak"
        Me.ToolTip.SetToolTip(Me.step1_button, "xvbxvbx")
        Me.step1_button.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 33)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Add Money"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(444, 74)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(133, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Bond"
        Me.ToolTip.SetToolTip(Me.OK_Button, "Click to compelete transaction")
        '
        'Password_text
        '
        Me.Password_text.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_text.Location = New System.Drawing.Point(259, 71)
        Me.Password_text.Name = "Password_text"
        Me.Password_text.Size = New System.Drawing.Size(100, 23)
        Me.Password_text.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.Password_text, "Enter T.C whis is given by the addminstraror")
        '
        'Step1
        '
        Me.Step1.BackColor = System.Drawing.Color.Transparent
        Me.Step1.Controls.Add(Me.Label5)
        Me.Step1.Controls.Add(Me.amount_text)
        Me.Step1.Controls.Add(Me.Label1)
        Me.Step1.Controls.Add(Me.Label3)
        Me.Step1.Controls.Add(Me.step1_button)
        Me.Step1.Location = New System.Drawing.Point(34, 45)
        Me.Step1.Name = "Step1"
        Me.Step1.Size = New System.Drawing.Size(589, 114)
        Me.Step1.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(386, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Please enter thecode given by the adminstartor to complete the transaction"
        '
        'transpin
        '
        Me.transpin.AutoSize = True
        Me.transpin.BackColor = System.Drawing.Color.Transparent
        Me.transpin.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transpin.Location = New System.Drawing.Point(259, 51)
        Me.transpin.Name = "transpin"
        Me.transpin.Size = New System.Drawing.Size(41, 15)
        Me.transpin.TabIndex = 12
        Me.transpin.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(89, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Your current transaction pin is"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Administrator Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Step 2 - Complete transaction"
        '
        'Step2
        '
        Me.Step2.BackColor = System.Drawing.Color.Transparent
        Me.Step2.Controls.Add(Me.Label4)
        Me.Step2.Controls.Add(Me.Password_text)
        Me.Step2.Controls.Add(Me.Label2)
        Me.Step2.Controls.Add(Me.Label7)
        Me.Step2.Controls.Add(Me.OK_Button)
        Me.Step2.Controls.Add(Me.transpin)
        Me.Step2.Controls.Add(Me.Label6)
        Me.Step2.Location = New System.Drawing.Point(34, 165)
        Me.Step2.Name = "Step2"
        Me.Step2.Size = New System.Drawing.Size(589, 120)
        Me.Step2.TabIndex = 16
        '
        'Add
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.B_Bank.My.Resources.Resources.Background_image
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(635, 297)
        Me.Controls.Add(Me.Step2)
        Me.Controls.Add(Me.Step1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bond Money"
        Me.Step1.ResumeLayout(False)
        Me.Step1.PerformLayout()
        Me.Step2.ResumeLayout(False)
        Me.Step2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents amount_text As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents step1_button As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Step1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents transpin As System.Windows.Forms.Label
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Password_text As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Step2 As System.Windows.Forms.Panel

End Class
