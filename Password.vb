Imports System.Windows.Forms

Public Class Password

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ForgotPassword.Close()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Password_to_show_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password_to_show.MouseHover
        Password_to_show.BackColor = Color.Transparent
    End Sub

    Private Sub Password_to_show_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password_to_show.MouseLeave
        Password_to_show.BackColor = Color.Black
    End Sub

    Public Sub SetPassword(ByVal password As String)
        Me.Show()
        Password_to_show.Text = password
    End Sub
End Class
