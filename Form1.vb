Imports System
Imports System.IO

Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        '
        Dim Username As String = Usernametext.Text.ToString
        Dim Password As String = PasswordText.Text.ToString
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()

        'Set the address for the file which has the password and username
        Dim Add As String = scrdirctory + Username + ".bbt"


        If File.Exists(Add) Then
            ' If the User Exist then Check Password

            'Reading Password
            Dim MyFileLine As String = File_Reader.GetLine(0)

            If String.Compare(Password, MyFileLine, False) = 0 Then
                'Password match then Continune
                Main.Show()
                Me.Hide()
                TextBox3.Text = (Username)
                Usernametext.ReadOnly = False
            Else
                'Password dosn't match
                MsgBox("The password you have enter is not correct for your UserName", MsgBoxStyle.Exclamation, "Incorrect Password")
                PasswordText.Text = ""
                Usernametext.ReadOnly = True
            End If
        Else
            'If the User is not found
            MsgBox("Please enter a vaild Username or Password.", MsgBoxStyle.Exclamation, "User not found")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Usernametext.Text = "UserName"
        PasswordText.Text = "Password"
        Label5.Text = "Date: " + Date.Now.Day.ToString + "/" + Date.Now.Month.ToString + "/" + Date.Now.Year.ToString
        'PasswordText.PasswordChar = "*"
        PasswordText.MaxLength = 14
        TextBox3.Hide()
        Me.Focus()
        Usernametext.Focus()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AboutBox1.Show()
    End Sub

    Private Sub Usernametext_Gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Usernametext.GotFocus
        Usernametext.Text = ""
    End Sub

    Private Sub Usernametext_Lostfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Usernametext.LostFocus
        If Usernametext.Text = "" Then
            Usernametext.Text = "UserName"
        End If
    End Sub

    Private Sub PasswordText_Gotfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordText.GotFocus
        PasswordText.Text = ""
        PasswordText.PasswordChar = "*"
    End Sub
    Private Sub Passwordtext_Lostfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordText.LostFocus
        If PasswordText.Text = "" Then
            PasswordText.PasswordChar = ""
            PasswordText.Text = "Password"
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Dialog3.ShowDialog()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        ForgotPassword.Show()
    End Sub

    Private Sub update_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_button.Click
        Try
            Process.Start(System.AppDomain.CurrentDomain.BaseDirectory() + "B_Bank_Updater.exe")
        Catch ex As Exception
            DialogDisplayer.DisplayError("Cannnot Start Updater", ex.ToString, "Check if the Updater.exe exits in the B-Bank Directory.")
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        File_Reader.WriteLine(2, "33")
    End Sub

End Class