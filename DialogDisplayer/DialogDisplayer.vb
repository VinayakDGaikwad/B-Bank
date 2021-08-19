Module DialogDisplayer
    '
    '                               How to use this module?
    '                               ```````````````````````
    '> To display the error dialog use.
    '
    '   DialogDisplayer.DisplayError("File not found","The file 'text.txt' was not found.", "Please select anouther file")
    '    
    '                                          Or
    '                                          --
    '   DialogDisplayer.DisplayError("File not found","The file 'text.txt' was not found.")
    '
    'If you want to diaplay a Int then use the Tostring() method.
    'The  defalt soultion will be "There was an error while executing B-Bank as shown below. Please help us improving our software quality. Click Upload to Upload the Error Details.
    '                        No Personal Information will be uploaded."
    'Give an empty string for no soultion 


    '> To display the error dialog use.
    '
    '   DialogDisplayer.DisplayInformation("File not found","The file 'text.txt' was not found.", "Please select anouther file")
    '    
    '                                          Or
    '                                          --
    '   DialogDisplayer.DisplayInformation("File not found","The file 'text.txt' was not found.")
    '
    'If you want to diaplay a Int then use the Tostring() method.
    'The  defalt soultion will be empty


    Public Sub DisplayError(ByVal DisplayError As String, ByVal Errordetails As String, Optional ByVal solution As String = _
                              "There was an error while executing B-Bank as shown below. Please help" + vbNewLine _
                            + "us improving our software quality. Click Upload to Upload the Error Details." + vbNewLine _
                            + "No Personal Information will be uploaded.")

        MessageDialog.Show()

        MessageDialog.Error_Message.Text = DisplayError
        MessageDialog.ERRORdETAILS_TO_sHOW = Errordetails
        MessageDialog.solution.Text = "Solution: " + solution

        MessageDialog.DialogImage.Image = My.Resources._Error

    End Sub

    Public Sub DisplayInformation(ByVal DisplayInfo As String, ByVal Infodetails As String, Optional ByVal solution As String = " ")
        'Show the dialog
        MessageDialog.Show()

        'Set the texts in the dialog
        MessageDialog.Error_Message.Text = DisplayInfo
        MessageDialog.ERRORdETAILS_TO_sHOW = infodetails
        MessageDialog.solution.Text = solution

        'Set the Image
        MessageDialog.DialogImage.Image = My.Resources.information
    End Sub
End Module
