Module File_Reader
    Function GetLine(ByVal LineNumber As Integer)
        Try
            Dim Tr As IO.TextReader = System.IO.File.OpenText(Form1.Usernametext.Text + ".bbt")
            Dim MyFileLine As String = Split(Tr.ReadToEnd(), vbCrLf)(LineNumber)
            Tr.Close()

            Return MyFileLine
        Catch Ex As Exception
            Return "Error: " + Ex.ToString
        End Try

    End Function

    Public Sub WriteLine(ByVal LineNumber As Integer, ByVal WriteString As String)
        Dim lines() As String = System.IO.File.ReadAllLines(Form1.Usernametext.Text + ".bbt")
        lines(LineNumber) = WriteString
        System.IO.File.WriteAllLines(Form1.Usernametext.Text + ".bbt", lines)
    End Sub
End Module
