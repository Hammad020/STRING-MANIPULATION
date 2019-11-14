Module Module1

    Sub Main()
        Dim currentchar, lastcharcount, count As Integer 
        Dim Str1, nextchar, mostrepeatedchar, Str2, FixStr As String

        currentchar = 0
        lastcharcount = 1 
        count = 0
        Str1 = ""
        nextchar = ""
        mostrepeatedchar = ""
        Str2 = "" 
        FixStr = "" 

        Console.Write("Enter a String: ")
        Str1 = Console.ReadLine
        Str1 = LCase(Str1)

        If Str1 <> "" Then 
            For count = 1 To Len(Str1)
                Str2 = Str1
                nextchar = Mid(Str1, count, 1)
                Do Until InStr(Str2, nextchar) = 0
                    currentchar = currentchar + 1
                    Str2 = Left(Str2, InStr(Str2, nextchar) - 1) & Right(Str2, Len(Str2) - InStr(Str2, nextchar))
               
                If currentchar > lastcharcount Then
                   mostrepeatedchar = nextchar
                End If
                lastcharcount = currentchar
                currentchar = 0
            Next

            If mostrepeatedchar = "" Then
                Console.WriteLine("all characters can be seen once ")
            End If
            If mostrepeatedchar <> "" Then
                Console.WriteLine("most repeated char is: " & mostrepeatedchar)
            End If
        Else
            Console.WriteLine("Please enter a valid String")
        End If
        
        For count = 1 To Len(Str1)
            nextchar = Mid(Str1, count, 1)
            If nextchar = " " Then
                nextchar = ""
            End If
            FixStr = FixStr & nextchar
        Next
        Str1 = FixStr
        EndFor
        
        Console.ReadKey()
    End Sub

End Module
