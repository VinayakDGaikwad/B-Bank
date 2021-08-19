Public Class Main

    Private Sub AllBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"
        Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
        Dim blance As String = Split(Tr.ReadToEnd(), vbCrLf)(2)
        Tr.Close()
    End Sub

    Private Sub Diolog_Close(ByVal sender As String)
        If sender = "Closethis" Then
            Form1.Show()
            Form1.Usernametext.Text = ""
            Form1.PasswordText.Text = ""
            Form1.Usernametext.Focus()
            Me.Close()
        End If
        If sender = "closeall" Then
            If MessageBox.Show("Are you sure you want to exit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
                Form1.Close()
            End If
        End If
    End Sub

    Private Sub Addmoney_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addmoney.Click
        Add.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        take_lone.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Givelone.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout.Click
        Diolog_Close("Closethis")
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refresh()

        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
        Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"
        Dim Tr As IO.TextReader = System.IO.File.OpenText(Add)
        Dim current_pin As String = Split(Tr.ReadToEnd(), vbCrLf)(3)
        Tr.Close()
        If current_pin = "" Then
        Else
            Dim transaction_type As String = current_pin.First()
            Select Case transaction_type
                Case "8"
                    status.Text = "The transaction of depositing money is incomplete. Your transaction pin is " + current_pin.ToUpper
                Case "5"
                    status.Text = "The transaction of withdrawing money is incomplete. Your transaction pin is " + current_pin.ToUpper
                Case "2"
                    status.Text = "The action of calaming lone is incomplete. Your transaction pin is " + current_pin.ToUpper
                Case "6"
                    status.Text = "The action of retureing lone is incomplete. Your transaction pin is " + current_pin.ToUpper
            End Select
        End If

        Dim TL As IO.TextReader = System.IO.File.OpenText(Add)
        Dim blance As String = Split(TL.ReadToEnd(), vbCrLf)(2)
        TL.Close()
        Label6.Text = "Rs. " + blance

        Dim Trl As IO.TextReader = System.IO.File.OpenText(Add)
        Dim lone As String = Split(Trl.ReadToEnd(), vbCrLf)(1)
        Trl.Close()
        Label7.Text = "Rs. " + lone

        whologin.Text = ("Hello! " + Form1.Usernametext.Text)
    End Sub

    Private Sub Main_Colse(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Dim i As Integer = 1
        i = 2
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        withdrawmoney.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Diolog_Close("closeall")
        Form1.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TOS_Dialog.ShowDialog()
    End Sub
End Class