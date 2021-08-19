Imports System.Windows.Forms
Imports System.IO

Public Class ChangePassword

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("You have not entered the old password or the new password.", MsgBoxStyle.Exclamation, "Incomplete data")
        Else
            Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
            Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"
            Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
            Dim current_Password As String = Split(Tr.ReadToEnd(), vbCrLf)(0)
            Tr.Close()

            If TextBox2.Text = TextBox3.Text Then
                If current_Password = TextBox1.Text Then
                    Dim lines() As String = System.IO.File.ReadAllLines(Add)
                    lines(0) = TextBox2.Text
                    System.IO.File.WriteAllLines(Add, lines)
                    MsgBox("You have successfully changed your password.", MsgBoxStyle.Information, "Password changed successfully.")
                    Me.Close()
                Else
                    MsgBox("You old password is not correct. Please enter you old password correcty", MsgBoxStyle.Exclamation, "Wrore Passwod")
                End If
            Else
                MsgBox("The new passwords does not mach.", MsgBoxStyle.Exclamation, "Error in password confirmation.")
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PasswordDl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.PasswordChar = "*"
        TextBox2.PasswordChar = "*"
        TextBox3.PasswordChar = "*"
    End Sub

End Class
