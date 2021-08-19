Imports System.Windows.Forms
Imports System.IO

Public Class withdrawmoney

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If amount.Text <> "" Then
            Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
            Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"
            Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
            Dim s_blance As String = Split(Tr.ReadToEnd(), vbCrLf)(2)
            Dim current_Blance As Int32 = Convert.ToInt32(s_blance)
            Tr.Close()

            Dim Trl As IO.TextReader = System.IO.File.OpenText(Add)
            Dim current_pin As String = Split(Trl.ReadToEnd(), vbCrLf)(3)
            Trl.Close()

            If current_Blance > Convert.ToInt32(amount.Text) Then
                '
                If current_pin <> "" Then
                    MsgBox("You already have a transaction. The pin number is " + current_pin.ToString + "Please complete the first transaction then try again.", MsgBoxStyle.Exclamation, "Last transaction incomplete")
                Else
                    Dim number As String = Code.GetTransactionPin(5, amount.Text)

                    'Dim lines() As String = System.IO.File.ReadAllLines(Add)
                    'lines(3) = number.ToString()
                    'System.IO.File.WriteAllLines(Add, lines)

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
                    objWriter.Close()

                    Dim pinWriter As New System.IO.StreamWriter(Add)
                    pinWriter.WriteLine(s_password)
                    pinWriter.WriteLine(s_Lone)
                    pinWriter.WriteLine(s_blance)
                    pinWriter.WriteLine(number.ToString())
                    pinWriter.WriteLine(amount.Text.ToString())
                    pinWriter.Close()


                    MsgBox("This is your transaction pin " + number.ToString() + vbCrLf + "Please don't forget to take the transaction pin given by the person.", MsgBoxStyle.Information, "Step 1 Sccsecfully completed")
                    Me.Hide()
                    Me.Close()
                End If
                '
            Else
                MsgBox("You cannot enter amount more than you have.", MsgBoxStyle.Critical, "Amount Greater than exprcted")
            End If
        Else
            MsgBox("Please enter the amount you want to Withdraw", MsgBoxStyle.Exclamation, "Incompleate data")
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub withdrawmoney_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"
        Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
        Dim Current_pin As String = Split(Tr.ReadToEnd(), vbCrLf)(3)
        If Current_pin = "" Then
            Label5.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
            Button1.Enabled = False
        Else
            If Current_pin.First() = "5" Then
                Label1.Enabled = False
                Label2.Enabled = False
                OK_Button.Enabled = False
                Label5.Text = "Please enter the transaction Code to complete the last transaction."
            Else
                MsgBox("Please complete the last transaction. Cheach for any other transaction which are not compleated.", MsgBoxStyle.Exclamation, "Can not proossece this transaction")
                Main.Show()
                Me.Close()
            End If
        End If
        Tr.Close()
        relode()
    End Sub
    Private Sub relode()
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"
        Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
        Dim Current_pin As String = Split(Tr.ReadToEnd(), vbCrLf)(3)
        If Current_pin = "" Then
            TextBox1.Enabled = False
            Button1.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
            Label5.Text = "Please Generate the pin by entering the details in Step-1."
        Else
            Label4.Text = "Step 1 - Generate request - Completed"
            Label2.Text = "Please complete the last transaction."
            Label1.Enabled = False
            amount.Enabled = False
            OK_Button.Enabled = False
        End If
        Tr.Close()

        transpin.Text = Current_pin

        amount.MaxLength = 3
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter the code given by the adminstrator below", MsgBoxStyle.Exclamation, "Incompleate data")
        Else
           
            Dim FINAL_CODE As String = Code.GetTransactionCode(transpin.Text)

            If TextBox1.Text = FINAL_CODE Then
                Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
                Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"
                '
                Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
                Dim current_blance As Int32 = Convert.ToInt32(Split(Tr.ReadToEnd(), vbCrLf)(2))
                Tr.Close()

                Dim Tl As IO.TextReader = System.IO.File.OpenText(Add)
                Dim withdrawamount As Int32 = Convert.ToInt32(Split(Tl.ReadToEnd(), vbCrLf)(4))
                Tl.Close()

                Dim lines() As String = System.IO.File.ReadAllLines(Add)
                Dim to_write_amount As String = current_blance - withdrawamount
                lines(2) = to_write_amount
                System.IO.File.WriteAllLines(Add, lines)

                Dim empety() As String = System.IO.File.ReadAllLines(Add)
                empety(4) = ""
                System.IO.File.WriteAllLines(Add, empety)

                Dim empety_pin() As String = System.IO.File.ReadAllLines(Add)
                empety_pin(3) = ""
                System.IO.File.WriteAllLines(Add, empety_pin)

                MsgBox("You have completed the withdraw transaction of amount Rs. " + withdrawamount.ToString() + " successfully form your account.", MsgBoxStyle.Information, "Transaction successfull.")
                Main.Show()
                Me.Close()
            Else
                MsgBox("The code you have entered is incorrect", MsgBoxStyle.Exclamation, "Incorrect Code")
            End If
        End If
    End Sub
    Private Sub amount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles amount.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
          Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class