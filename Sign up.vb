Imports System.Windows.Forms
Imports System.Text.RegularExpressions

Public Class Dialog3
    Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
    Dim Add As String = scrdirctory + Form1.Usernametext.Text + ".bbt"

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.MouseDown
        '
        Select Case page_number.Text
            Case "1"
                Dim vTextBox1 As String = TextBox1.Text.ToString
                Dim vTextBox2 As String = TextBox2.Text.ToString
                Dim vTextBox3 As String = TextBox1.Text.ToString
                Dim vage As String = AgeText.Text.ToString
                Dim vPhone As String = Phonenumbertext.Text.ToString
                Dim vTxetbox5 As String = TextBox5.Text.ToString
                Dim vPasswordtext As String = passwordtext.Text.ToString
                Dim vConformPass As String = conferpasswordtext.Text.ToString
                Dim vSecurityQuestion As String = security_question.Text.ToString
                Dim vAnswer As String = answer.Text.ToString()
                '
                If ComboBox1.SelectedItem = "Select any" Or vTextBox1.Equals("") Or vTextBox2.Equals("") Or vTextBox3.Equals("") Or vTxetbox5.Equals("") Or vage.Equals("") Or vPhone.Equals("") Or vPasswordtext.Equals("") Or vConformPass.Equals("") Or vAnswer.Equals("") Or vSecurityQuestion.Equals("") Or Address.Text.Equals("") Then
                    MsgBox("Some mandatory felids are empty. They should not be left blank.", MsgBoxStyle.Critical, "Felids are empty")
                Else
                    If IsValidEmailFormat(E_mail.Text) = False Then
                        MsgBox("The E-Mail address you have entred is incorrect. Please try again.", MsgBoxStyle.Critical, "Invaild E-Mail Address")
                    Else
                        If passwordtext.Text = conferpasswordtext.Text Then
                            'Everthing is OK So Next Page
                            If System.IO.File.Exists(TextBox5.Text + ".txt") = False Then
                                page_number.Text = "2"
                            Else
                                MsgBox("The Username you selected already exists. Please try anthor UserName.", MsgBoxStyle.Critical, "User already exsits")
                            End If

                        Else
                            MsgBox("The password dose not match.", MsgBoxStyle.Critical, "Passwords do not match.")
                        End If
                    End If
                End If
            Case "2"
                If create_user() = "" Then
                    final_username.Text = TextBox5.Text
                    Label28.Text = faceimage_filename.Text
                    page_number.Text = "3"
                Else
                    MsgBox("Error: " + create_user())
                End If
            Case "3"
                Me.Close()
        End Select
        
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function create_user()
        'Prsonal information
        Try
            Dim bDate = DateTimePicker1.Value.Date.ToString("dd/mm/yyyy")
            Dim fullname As String = TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text
            Dim age = AgeText.Text

            Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()
            Dim logoaddress As String = scrdirctory + "\B-Logo.bbt"
            Dim vSecurityQuestion As String = security_question.Text.ToString
            Dim vAnswer As String = answer.Text.ToString()

            Dim SW As IO.TextWriter
            SW = IO.File.AppendText(logoaddress)
            SW.WriteLine("----------------------------------------------------------------------------------------------------")
            SW.WriteLine("Full_Name:      " + fullname)
            SW.WriteLine("Brith_Date:     " + bDate)
            SW.WriteLine("Age:            " + age)
            SW.WriteLine("Contact_Number: " + Phonenumbertext.Text)
            SW.WriteLine("Sing_up_Date:   " + Date.Now.ToString("dd/mm/yyyy"))
            If ComboBox1.SelectedItem.ToString = "Male" Then
                SW.WriteLine("Gender:         Male")
            End If
            If ComboBox1.SelectedItem.ToString = "Female" Then
                SW.WriteLine("Gender:         Female")
            End If
            SW.WriteLine("Residential Address: " + Address.Text)
            SW.Flush()
            SW.Close()


            'Security
            Dim TW As System.IO.TextWriter
            Dim newfileaddress As String = scrdirctory + "\" + TextBox5.Text + ".bbt"
            TW = System.IO.File.CreateText(newfileaddress) '0
            TW.WriteLine(passwordtext.Text) '1
            TW.WriteLine("00") '2
            TW.WriteLine("00") '3
            TW.WriteLine("") '4
            TW.WriteLine("") '5
            TW.WriteLine(vSecurityQuestion.ToString()) '6
            TW.WriteLine(vAnswer.ToString()) '7
            TW.WriteLine("") '8
            TW.WriteLine("") '9
            TW.WriteLine("") '10
            TW.WriteLine("") '11
            TW.WriteLine("") '12
            TW.WriteLine("") '13
            TW.WriteLine("") '14
            TW.WriteLine("----------------------------------------------------------------------------------------------------") '15
            TW.WriteLine(fullname) '16
            TW.WriteLine(bDate) '17
            TW.WriteLine(age) '18
            TW.WriteLine(Phonenumbertext.Text) '19
            TW.WriteLine(Date.Now.ToString("dd/mm/yyyy")) '20
            If ComboBox1.SelectedItem.ToString = "Male" Then
                TW.WriteLine("Male")
            End If
            If ComboBox1.SelectedItem.ToString = "Female" Then
                TW.WriteLine("Female")
            End If
            TW.WriteLine(Address.Text)
            TW.Flush()
            TW.Close()

            'FaceImage
            'Label28.Text = "Invaid Image or No Image Selected"
            If System.IO.File.Exists(faceimage_filename.Text) = True Then '
                System.IO.File.Copy(faceimage_filename.Text, scrdirctory + "data\" + TextBox5.Text.ToLower + "Image.jpg")
                Label28.Text = faceimage_filename.Text
            End If

            Return ""
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Private Sub Dialog3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''RichTextBox.Text = System.IO.File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory() + "B-Bank Terms of Service.bbt")
        RichTextBox.ReadOnly = True
        RichTextBox.BackColor = System.Drawing.Color.White()
        Me.AutoScroll = True
        conferpasswordtext.Enabled = False
        ComboBox1.SelectedItem = "Select any"
        passwordtext.PasswordChar = ("*")
        conferpasswordtext.PasswordChar = ("*")
        Phonenumbertext.MaxLength = 10
        AgeText.MaxLength = 2
    End Sub

    Private Sub AgeText_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AgeText.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Private Sub Phonenumbertext_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Phonenumbertext.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If
    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Return Regex.IsMatch(s, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function

    Function ValidatePassword(ByVal pwd As String, Optional ByVal minLength As Integer = 8, Optional ByVal numUpper As Integer = 1, Optional ByVal numNumbers As Integer = 1, Optional ByVal numSpecial As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters. 
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above". 
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length. 
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences. 
        If upper.Matches(pwd).Count < numUpper Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks. 
        Return True
    End Function

    Private Sub passwordtext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passwordtext.TextChanged
        If ValidatePassword(passwordtext.Text) = True Then
            ''  Pass_PictureBox.Load(scrdirctory + "tick.jpeg")
            conferpasswordtext.Enabled = True
        ElseIf ValidatePassword(passwordtext.Text) = False Then
            ''     Pass_PictureBox.Load(scrdirctory + "wrong.jpeg")
            conferpasswordtext.Enabled = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Please check if you password has at lest" + vbNewLine + "   -1 Numeric Character" + vbNewLine + "     -1 Special Character" + vbNewLine + "    -1 Uppercase Character.", "Password Requirements", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
    End Sub

    Private Sub conferpasswordtext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conferpasswordtext.TextChanged
        If String.Compare(conferpasswordtext.Text, passwordtext.Text, False) = 0 Then
            ''    Conform_Pass_PictureBox.Load(scrdirctory + "tick.jpeg")
        Else
            ''     Conform_Pass_PictureBox.Load(scrdirctory + "wrong.jpeg")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog.ShowDialog()
    End Sub

    Private Sub OpenFileDialog_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        faceimage_filename.Text = OpenFileDialog.FileName.ToString
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CInt(page_number.Text) <> 1 Then
            page_number.Text = CInt(page_number.Text) - 1
        End If
    End Sub

    Private Sub page_number_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles page_number.TextChanged
        Select Case page_number.Text
            Case "1"
                Panel1.Visible = True
                Panel2.Visible = False
                Panel3.Visible = False
                OK_Button.Text = "Next >"
            Case "2"
                Panel1.Visible = False
                Panel2.Visible = True
                Panel3.Visible = False
                OK_Button.Text = "Next >"
                OK_Button.Enabled = False
            Case "3"
                Panel1.Visible = False
                Panel2.Visible = False
                Panel3.Visible = True
                OK_Button.Text = "Finish"
        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked() = True Then
            OK_Button.Enabled = True
        ElseIf CheckBox1.Checked() = False Then
            OK_Button.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = "sefs"
        TextBox2.Text = "sefs"
        TextBox3.Text = "sefs"
        AgeText.Text = "55"
        TextBox5.Text = "fss"
        passwordtext.Text = "Vin@89660"
        conferpasswordtext.Text = "Vin@89660"
        security_question.Text = "sdf"
        answer.Text = "sdf"
        E_mail.Text = "dv.d@sdf.com"
        Phonenumbertext.Text = "1234567890"
    End Sub

    Private Sub Dialog3_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        page_number.Text = "1"
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
        PictureBox1.Load(Label28.Text)
    End Sub

    Private Sub Read_Terms_of_Service_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Read_Terms_of_Service.LinkClicked
        TOS_Dialog.ShowDialog()
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged

    End Sub

    Private Sub OK_Button_Click_1(sender As Object, e As EventArgs) Handles OK_Button.Click

    End Sub
End Class
