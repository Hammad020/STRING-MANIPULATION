Module Module1

    Sub Main()
        Dim alpha, Str1 As String
        Dim Count As Integer
        Dim ispangram As Boolean

        alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Str1 = " "
        Count = 0
        ispangram = False

        Console.WriteLine("Enter a pangram: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)
        If Len(Str1) >= 26 Then
            ispangram = True
            For Count = 1 To 26
                If InStr(Str1, Mid(alpha, Count, 1)) = 0 Then
                    ispangram = False
                End If
            Next
        End If
        If ispangram = True Then
            Console.WriteLine("The entered string is a pangram")
        Else
            Console.WriteLine("The entered string is not a pangram")
        End If
        Console.ReadKey()
    End Sub

End Module
