Imports System.Windows.Forms

Public Class Add

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Password_text.Text = "" Then
            MsgBox("Please enter the code given by the adminstrator below", MsgBoxStyle.Exclamation, "Incompleate data")
        Else
            
            Dim FINAL_CODE As String = Code.GetTransactionCode(transpin.Text)

            If Password_text.Text = FINAL_CODE Then

                'Read blance
                Dim current_blance As Int32 = Convert.ToInt32(File_Reader.GetLine(2))

                'Read amount to be added
                Dim addamount As Int32 = Convert.ToInt32(File_Reader.GetLine(4))
                
                'Write the blance with the added amount
                Dim lines() As String = System.IO.File.ReadAllLines(Form1.Usernametext.Text + ".bbt")
                Dim to_write_amount As String = current_blance + addamount
                lines(2) = to_write_amount
                System.IO.File.WriteAllLines(Form1.Usernametext.Text + ".bbt", lines)

                'Clear the pin line and the addamount line in the file
                Dim empety() As String = System.IO.File.ReadAllLines(Form1.Usernametext.Text + ".bbt")
                empety(4) = ""
                System.IO.File.WriteAllLines(Form1.Usernametext.Text + ".bbt", empety)

                Dim empety_pin() As String = System.IO.File.ReadAllLines(Form1.Usernametext.Text + ".bbt")
                empety_pin(3) = ""
                System.IO.File.WriteAllLines(Form1.Usernametext.Text + ".bbt", empety_pin)

                MsgBox("You have added Rs. " + addamount.ToString() + " successfully to your account.", MsgBoxStyle.Information, "Transaction successfull.")
                Main.Show()
                Me.Close()
            Else
                MsgBox("The code you have entered is incorrect", MsgBoxStyle.Exclamation, "Incorrect Code")
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"
        Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
        Dim Current_pin As String = Split(Tr.ReadToEnd(), vbCrLf)(3)
        If Current_pin = "" Then
            Step2.Enabled = False
        Else
            If Current_pin.First() = "8" Then
                Step1.Enabled = False
                Label6.Text = "Please enter the transaction Code to complete the last transaction."
            Else
                MsgBox("Please complete the last transaction. Cheach for any other transaction which are not compleated.", MsgBoxStyle.Exclamation, "Can not proossece this transaction")
                Me.Close()
            End If
        End If
        Tr.Close()

        amount_text.MaxLength = 3
        transpin.Text = Current_pin.ToString()
        '
        Password_text.Text = ""
        Password_text.MaxLength = 14
        amount_text.MaxLength = 3
    End Sub

    Private Sub step1_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles step1_button.Click
        'Cheak if amount_text is not empty
        If amount_text.Text <> "" Then
            'Create the address of the file as "add"
            Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
            Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"

            Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
            Dim s_blance As String = Split(Tr.ReadToEnd(), vbCrLf)(2)
            Dim current_Blance As Int32 = Convert.ToInt32(s_blance)
            Tr.Close()

            Dim Trl As IO.TextReader = System.IO.File.OpenText(Add)
            Dim current_pin As String = Split(Trl.ReadToEnd(), vbCrLf)(3)
            Trl.Close()

            If current_pin <> "" Then
                MsgBox("You already have a transaction. The pin number is " + current_pin.ToString + "Please complete the first transaction then try again.", MsgBoxStyle.Exclamation, "Last transaction incomplete")
            Else
                Dim number As String = Code.GetTransactionPin(8, amount_text.Text)

                Dim Trs As IO.TextReader = System.IO.File.OpenText(Add)
                Dim s_password As String = Split(Trs.ReadToEnd(), vbCrLf)(0)
                Trs.Close()

                Dim Trw As IO.TextReader = System.IO.File.OpenText(Add)
                Dim s_Lone As String = Split(Trw.ReadToEnd(), vbCrLf)(1)
                Trw.Close()

                Dim objWriter As New System.IO.StreamWriter(Add)
                objWriter.WriteLine(s_password)
                objWriter.WriteLine(s_Lone)
                objWriter.WriteLine(s_blance)
                objWriter.WriteLine(number.ToString())
                objWriter.WriteLine(amount_text.Text.ToString)
                objWriter.Flush()
                objWriter.Close()

                MsgBox("This is your transaction pin " + number.ToString() + vbCrLf + "Please don't forget to take the transaction pin given by the person.", MsgBoxStyle.Information, "Step 1 Sccsecfully completed")
                Me.Close()
            End If
        Else
            MsgBox("Please enter the amount you want to add to your account", MsgBoxStyle.Exclamation, "Incompleate data")
        End If
    End Sub
    Private Sub amount_text_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles amount_text.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(Code.GetTransactionCode(transpin.Text))
    End Sub
End Class
