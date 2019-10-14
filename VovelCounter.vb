Module Module1

    Sub Main()
        Dim Str, vovel As String
        Dim Count, noofvovels As Integer

        Str = " "
        vovel = "AEIOU"
        Count = 0
        noofvovels = 0

        Console.WriteLine("Enter the string that you to Check")
        Str = Console.ReadLine

        Str = UCase(Str)

        For Count = 1 To Len(Str)
            If InStr(vovel, Mid(Str, Count, 1)) > 0 Then
                noofvovels = noofvovels + 1
            End If
        Next
        Console.WriteLine("The number of vovels in the entered string is: " & noofvovels)
        Console.ReadKey()

    End Sub

End Module
