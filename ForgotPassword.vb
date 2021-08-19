Public Class ForgotPassword
    
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
            Dim Add As String = scrdirctory + UserName.Text + ".bbt"

            Dim Trl As IO.TextReader = System.IO.File.OpenText(Add)
            Dim current_answer As String = Split(Trl.ReadToEnd(), vbCrLf)(6)
            Trl.Close()

            Dim Trw As IO.TextReader = System.IO.File.OpenText(Add)
            Dim current_password As String = Split(Trw.ReadToEnd(), vbCrLf)(0)
            Trw.Close()

            
            If Answer.Text = current_answer Then
                If MessageBox.Show("Please confirm no one is around. Are you ready?", "Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    Password.SetPassword(current_password)
                    'MessageBox.Show("Your password is " + current_password + ". Please change your password as soon as you login.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                Else
                End If
            End If
        Catch Ex As Exception
            MsgBox("Error:" + Ex.ToString)
        End Try
    End Sub

    Private Sub UserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserName.TextChanged
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim Add As String = scrdirctory + UserName.Text + ".bbt"

        If System.IO.File.Exists(Add) = False Then
            PictureBox.Load(scrdirctory + "wrong.jpeg")
        ElseIf System.IO.File.Exists(Add) = True Then
            GroupBox1.Enabled = True
            succes()
            PictureBox.Load(scrdirctory + "tick.jpeg")
            UserName.Enabled = False
            Answer.Focus()
        End If
    End Sub

    Private Sub succes()
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim Add As String = scrdirctory + UserName.Text + ".bbt"

        Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
        Dim current_Question As String = Split(Tr.ReadToEnd(), vbCrLf)(5)
        Tr.Close()

        Security_Question.Text = current_Question.ToString()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub ForgotPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
    End Sub

    Private Sub Cancel_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
End Class