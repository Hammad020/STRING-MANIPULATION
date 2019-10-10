Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim Char1, Char2, nextChar As Char
        Dim Counter As Integer

        Str1 = " "
        Str2 = " "
        Counter = 0

        Console.Write("Enter String: ")
        Str1 = Console.ReadLine

        Console.Write("Enter character to remove")
        Char1 = Console.ReadLine

        Console.Write("Enter character to replace")
        Char2 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            nextChar = Mid(Str1, Counter, 1)
            If nextChar = Char1 Then
                nextChar = Char2
            End If
            Str2 = Str2 & nextChar
            End
        Next
    End Sub

End Module

