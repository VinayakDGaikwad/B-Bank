Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        Version.Text = "v" + My.Application.Info.Version.ToString()

        'Label2.Text = "B-Bank is a software based on the idea of B-Bank(The Big Bank, TC/TP). This version of B-Bank <version> was downloaded form the B-Bank site. For more information,  please visit <website>."

        Dim Intor_text As String = Label2.Text
        Replace(Intor_text, "<version>", "v" + My.Application.Info.Version.ToString)
        Replace(Intor_text, "<website>", "http:/website.com")
        Label2.Text = Intor_text

        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Dim scrdirctory As String = System.AppDomain.CurrentDomain.BaseDirectory()

        'Label1.Text = "Checking Files"
        If System.IO.File.Exists(scrdirctory + "B-Bank_logo.bbt") = False Then
            If MessageBox.Show("The file 'B-Bank_logo.bbt' do not exist. Do you want to create it now?", "File does not exist", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Yes Then
                Dim TW As System.IO.TextWriter
                TW = System.IO.File.CreateText(scrdirctory + "B-Bank_logo.bbt")
                TW.Flush()
                TW.Close()
            End If
        ElseIf System.IO.File.Exists(scrdirctory + "B-Bank_logo.bbt") = True Then
            ProgressBar.Minimum = 0
            ProgressBar.Maximum = 100
            ProgressBar.Value = 20
        End If

        If System.IO.File.Exists(scrdirctory + "B-Bank_details.bbt") = False Then
            '   Label1.Text = "Creating Files for first use"
            Try
                Dim TW As System.IO.TextWriter
                TW = System.IO.File.CreateText(scrdirctory + "B-Bank_details.bbt")
                TW.WriteLine("B-Bank Application Information")
                TW.WriteLine("#Please do not edit.")
                TW.WriteLine("#################################################################################")
                TW.WriteLine("Installed on: " + Date.Now.Date.ToString())
                TW.WriteLine("Last used on: " + Date.Now.Date.ToString())
                TW.WriteLine(My.Application.Info.Version.ToString)
                TW.Flush()
                TW.Close()
            Catch ex As Exception
                MsgBox("Error: While creating B-Bank_details.bbt file. " + ex.ToString(), MsgBoxStyle.Critical)
            End Try
        ElseIf System.IO.File.Exists(scrdirctory + "B-Bank_details.bbt") = True Then
            Try
                Dim lines() As String = System.IO.File.ReadAllLines(scrdirctory + "B-Bank_details.bbt")
                lines(4) = CStr("Last Used on: " + Now.Date.ToUniversalTime())
                lines(5) = CStr(My.Application.Info.Version.ToString)
                System.IO.File.WriteAllLines(scrdirctory + "B-Bank_details.bbt", lines)
            Catch ex As Exception
                MsgBox("Error: While writing Last useded on date to file B-Bank_details.bbt" + ex.ToString(), MsgBoxStyle.Critical)
            End Try
            ProgressBar.Value = 100
        End If
        'Label1.Text = "Finished"

    End Sub
End Class
