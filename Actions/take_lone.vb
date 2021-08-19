Imports System.IO
Imports System.Windows.Forms

Public Class take_lone
    Dim rate As Int32 = 6

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Password_text.Text = "" Then
            MsgBox("Please enter the code given by the adminstrator below", MsgBoxStyle.Exclamation, "Incompleate data")
        Else
            
            Dim FINAL_CODE As String = Code.GetTransactionCode(transpin.Text)

            If Password_text.Text = FINAL_CODE Then
                Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
                Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"

                Dim Trl As IO.TextReader = System.IO.File.OpenText(Add)
                Dim Current_lone As String = Split(Trl.ReadToEnd(), vbCrLf)(1)
                Trl.Close()

                'Read pin
                Dim Trq As IO.TextReader = System.IO.File.OpenText(Add)
                Dim to_add_lone As String = Split(Trq.ReadToEnd(), vbCrLf)(4)
                Trq.Close()

                Dim new_lone As Int32 = Current_lone + CInt(to_add_lone)

                Dim lines_write() As String = System.IO.File.ReadAllLines(Add)
                lines_write(1) = new_lone.ToString()
                lines_write(3) = ""
                lines_write(4) = ""
                System.IO.File.WriteAllLines(Add, lines_write)

                MsgBox("You have TOOK A LONE OF Rs. " + to_add_lone.ToString() + " successfully to your account.", MsgBoxStyle.Information, "Transaction successfull.")
                Main.Show()
                Me.Close()
            Else
                MsgBox("The code you have entered is incorrect", MsgBoxStyle.Exclamation, "Incorrect Code")
            End If
        End If
    End Sub

    Private Sub take_lone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        step_1button.Enabled = False
        days.MaxLength = 3
        amount.MaxLength = 3
        Label9.Text = ""

        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"
        Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
        Dim current_lone As String = Split(Tr.ReadToEnd(), vbCrLf)(1)
        Tr.Close()

        Dim current_lone_int As Decimal = Convert.ToDecimal(current_lone)

        If current_lone_int >= 100.0 Then
            MsgBox("We can cannot claim your lone because you already have alone of Rs. " + current_lone.ToString + ". Please clear you last lone. For info click help on the logon page.", MsgBoxStyle.Information, "Your lone cannot be clamed.")
            Me.Close()
        End If

        Dim TrL As IO.TextReader = System.IO.File.OpenText(Add)
        Dim Current_pin As String = Split(TrL.ReadToEnd(), vbCrLf)(3)
        If Current_pin = "" Then
            Step1_Panal.Enabled = True
            Step2_Panel.Enabled = False
        Else
            If Current_pin.First() = "2" Then
                Step1_Panal.Enabled = False
                Step2_Panel.Enabled = True
                Label12.Text = "Please enter the transaction Code to complete the last transaction."
            Else
                MsgBox("Please complete the last transaction. Cheach for any other transaction which are not compleated.", MsgBoxStyle.Exclamation, "Can not proossece this transaction")
                Me.Close()
            End If
        End If
        transpin.Text = Current_pin.ToString()
        TrL.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If days.Text = "" Or amount.Text = "" Then
            step_1button.Enabled = False
            Label6.Text = "Please enter to number of days and lone Amount."
            Label9.Text = ""
        Else
            Dim prinpal As Int32 = CInt(amount.Text)
            Dim time As Int32 = Convert.ToInt32(days.Text)
            Dim un_amount As Integer = CInt(prinpal * time * 6)
            Dim final As String = un_amount / 100
            Dim final_amount As String = CInt(final)

            Dim total_amount As Int32 = final_amount + prinpal
            Label9.Text = final_amount + prinpal
            Label6.Text = final_amount.ToString()

            If Label9.Text = "" Then
                step_1button.Enabled = False
            Else
                step_1button.Enabled = True
            End If
        End If
    End Sub

    Private Sub amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amount.TextChanged
        If days.Text = "" Or amount.Text = "" Then
            step_1button.Enabled = False
            Label6.Text = "Please enter to number of days and lone Amount."
            Label9.Text = ""
        Else
            Dim prinpal As Int32 = CInt(amount.Text)
            Dim time As Int32 = Convert.ToInt32(days.Text)
            Dim un_amount As Integer = CInt(prinpal * time * 6)
            Dim final As String = un_amount / 100
            Dim final_amount As String = CInt(final)

            Dim total_amount As Int32 = final_amount + prinpal
            Label9.Text = final_amount + prinpal
            Label6.Text = final_amount.ToString()

            If Label9.Text = "" Then
                step_1button.Enabled = False
            Else
                step_1button.Enabled = True
            End If
        End If
    End Sub

    Private Sub days_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles days.TextChanged
        If days.Text = "" Or amount.Text = "" Then
        Else
            Dim prinpal As Int32 = Convert.ToInt32(amount.Text)
            Dim time As Int32 = Convert.ToInt32(days.Text)
            Dim un_amount As Int32 = prinpal * time * 6
            Dim final_amount As String = un_amount / 100

            Dim total_amount As Int32 = final_amount + prinpal
            Label9.Text = final_amount + prinpal
            Label6.Text = final_amount.ToString()
        End If

        If Label9.Text = "" Then
            step_1button.Enabled = False
        Else
            step_1button.Enabled = True
        End If
    End Sub

    Private Sub step_1button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles step_1button.Click
        If amount.Text <> "" Then
            Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
            Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"

            Dim lines() As String = System.IO.File.ReadAllLines(Add)
            Dim current_lone As Int32 = Convert.ToInt32(lines(1))

            Dim number As String = Code.GetTransactionPin(2, Label9.Text)

            Try
                Dim lines_write() As String = System.IO.File.ReadAllLines(Add)
                lines_write(3) = number
                System.IO.File.WriteAllLines(Add, lines_write)
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            End Try

            Dim lines_writelone() As String = System.IO.File.ReadAllLines(Add)
            lines_writelone(4) = CInt(Label9.Text).ToString
            System.IO.File.WriteAllLines(Add, lines_writelone)

            MsgBox("This is your transaction pin " + number.ToString() + vbCrLf + "Please don't forget to take the transaction pin given by the person.", MsgBoxStyle.Information, "Step 1 Sccsecfully completed")
            Me.Close()
        Else
            MsgBox("Please enter the amount you want to add to your account", MsgBoxStyle.Exclamation, "Incompleate data")
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

    Private Sub days_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles days.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub
End Class