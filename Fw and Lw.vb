﻿Module Module1

    Sub Main()
        Dim Str1, Str2, Str3, firstword, lastword As String
        Dim Sp As Integer

        Str1 = " "
        Str2 = " "
        Str3 = " "
        Sp = 0

        Console.Write("Enter your first set of 2 words: ")
        Str1 = Console.ReadLine

        Console.Write("Enter your second set of 2 words: ")
        Str2 = Console.ReadLine

        Sp = Instr(Str1, ' ')
        firstword = Left(Str1, Sp - 1)

            Sp = Instr(Str2, ' ')
        lastword = Right(Str2, LENGHT(Str2) - Sp)

        Str3 = firstword & ' ' & lastword
        Str3 = Console.ReadLine

        Console.ReadKey()


    End Sub

End Module
