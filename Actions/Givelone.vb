Imports System.Windows.Forms
Imports System.IO

Public Class Givelone
    Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
    Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Password_text.Text = "" Then
            MsgBox("Please enter the code given by the adminstrator below", MsgBoxStyle.Exclamation, "Incompleate data")
        Else
           
            Dim FINAL_CODE As String = Code.GetTransactionCode(transpin.Text)

            If Password_text.Text = FINAL_CODE Then

                Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
                Dim S_lone As String = Split(Tr.ReadToEnd(), vbCrLf)(1)
                Dim Trl As IO.TextReader = System.IO.File.OpenText(Add)
                Dim S_blance As String = Split(Trl.ReadToEnd(), vbCrLf)(2)
                Dim Trw As IO.TextReader = System.IO.File.OpenText(Add)
                Dim returen As String = Split(Trw.ReadToEnd(), vbCrLf)(2)
                Tr.Close()
                Trl.Close()
                Trw.Close()

                Dim current_Blance As Int32 = Convert.ToInt32(S_blance)
                Dim current_lone As Int32 = Convert.ToInt32(S_lone)
                Dim returen_lone As Int32 = Convert.ToInt32(returen)

                If current_Blance > current_lone Then
                    'Lone
                    Dim final_lone As Int32 = current_lone - returen_lone

                    If final_lone < 0 Then
                        final_lone = 0
                    End If

                    Dim lone_lines() As String = System.IO.File.ReadAllLines(Add)
                    lone_lines(1) = final_lone
                    System.IO.File.WriteAllLines(Add, lone_lines)


                    'Blance
                    Dim final_blance As Int32 = current_Blance - returen_lone

                    If final_blance < 0 Then
                        final_blance = 0
                    End If

                    Dim blance_lines() As String = System.IO.File.ReadAllLines(Add)
                    blance_lines(2) = final_blance
                    System.IO.File.WriteAllLines(Add, blance_lines)

                    Dim lines_write() As String = System.IO.File.ReadAllLines(Add)
                    lines_write(3) = ""
                    lines_write(4) = ""
                    System.IO.File.WriteAllLines(Add, lines_write)


                    MessageBox.Show("You have successfully returned your lone amount of Rs." + returen_lone.ToString(), "Lone returned successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                    Me.Close()
                Else
                    MsgBox("You don't have enough money to return any lone. Please add some money and then try again.", MsgBoxStyle.Critical, "No enough money")
                End If
            End If

        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Givelone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OK_Button.Enabled = False
        step_1button.Enabled = False
        amount.MaxLength = 3

        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"

        Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
        Dim current_lone As String = Split(Tr.ReadToEnd(), vbCrLf)(1)
        Tr.Close()

        If current_lone = "0" Then
            MsgBox("You have no lone to returen.", MsgBoxStyle.Information, "No Lone")
            Me.Close()
        End If

        Dim TrL As IO.TextReader = System.IO.File.OpenText(Add)
        '''''''''''''it can show '
        Dim Current_pin As String = Split(TrL.ReadToEnd(), vbCrLf)(3)
        ''''''''''''''''
        If Current_pin = "" Then
            Step1_Panal.Enabled = True
            Step2_Panel.Enabled = False
        Else
            If Current_pin.First() = "6" Then
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

    Private Sub amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amount.TextChanged
        If amount.Text = "" Then
            step_1button.Enabled = False
        Else
            step_1button.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password_text.TextChanged
        If Password_text.Text = "" Then
            OK_Button.Enabled = False
        Else
            OK_Button.Enabled = True
        End If
    End Sub
    Private Sub step_1button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles step_1button.Click
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"

        Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
        Dim S_lone As String = Split(Tr.ReadToEnd(), vbCrLf)(1)
        Dim Trl As IO.TextReader = System.IO.File.OpenText(Add)
        Dim S_blance As String = Split(Trl.ReadToEnd(), vbCrLf)(2)
        Tr.Close()
        Trl.Close()

        Dim current_Blance As Int32 = Convert.ToInt32(S_blance)
        Dim current_lone As Int32 = Convert.ToInt32(S_lone)

        If current_Blance > current_lone Then
            If CInt(current_lone) >= CInt(amount.Text) Then

            End If
            Dim number As String = Code.GetTransactionPin(6, amount.Text)

            Dim lines_write() As String = System.IO.File.ReadAllLines(Add)
            Try
                lines_write(3) = number
                System.IO.File.WriteAllLines(Add, lines_write)
            Catch ex As Exception
                DialogDisplayer.DisplayError("While writing TP in the user file.", e.ToString(), "Cheack vlue order in the file.(only for administrator)")
            End Try



            Dim lines_writelone() As String = System.IO.File.ReadAllLines(Add)
            lines_writelone(4) = CInt(amount.Text).ToString
            System.IO.File.WriteAllLines(Add, lines_writelone)

            MsgBox("This is your transaction pin " + number.ToString() + vbCrLf + "Please don't forget to take the transaction pin given by the person.", MsgBoxStyle.Information, "Step 1 Sccsecfully completed")
            Me.Close()
        Else
            MsgBox("You don't have enough money to return any lone. Please add some money and then try again.", MsgBoxStyle.Critical, "No enough money")
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
End Class
