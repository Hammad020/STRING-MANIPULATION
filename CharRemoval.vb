﻿Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim Char1, nextChar As Char
        Dim Counter As Integer

        Str1 = " "
        Str2 = " "
        Counter = 0

        Console.Write("Enter String: ")
        Str1 = Console.ReadLine

        Console.Write("Enter character to remove")
        Char1 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            nextChar = Mid(Str1, Counter, 1)
            If nextChar <> Char1 Then
                Str2 = Str2 & nextChar
            End If
        Next

    End Sub

End Module
