Module Code
    Function GetTransactionCode(ByRef Transaction_pin As String)

        'This part of code will be in syn with the code in the BankSide Application as far as i remenber
        'Coding
        Dim CodeUD1 As String = Transaction_pin.Replace("9", "p")
        Dim CodeUD2 As String = CodeUD1.Replace("8", "j")
        Dim CodeUD3 As String = CodeUD2.Replace("7", "u")
        Dim CodeUD4 As String = CodeUD3.Replace("6", "g")
        Dim CodeUD5 As String = CodeUD4.Replace("5", "7")
        Dim CodeUD6 As String = CodeUD5.Replace("4", "a")
        Dim CodeUD7 As String = CodeUD6.Replace("3", "z")
        Dim CodeUD8 As String = CodeUD7.Replace("2", "r")
        Dim TransactionCode As String = CodeUD8.Replace("1", "0")

        Return TransactionCode.ToString.ToUpper
    End Function

    'Used to Genrate TransactionPin that is to be given to the User
    Function GetTransactionPin(ByVal TransactionType As Integer, ByVal amount As String)
        Dim ToReturn As String = TransactionType.ToString + "-" + Date.Now.Month.ToString + "-" + amount + "-" + Date.Now.Year.ToString
        'TODO: Add the CodeConversion Code Here and will be updated everywere
        Return ToReturn
    End Function
End Module
