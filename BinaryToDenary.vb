Module Module1

    Sub Main()


        '(a)'

        Dim Str1, Str2, NextChar As String
        Dim Count, NextNum, DenaryNo As Integer
        Dim validBinaryString As Boolean

        Str1 = " "
        Str2 = " "
        NextChar = " "
        Count = 0
        NextNum = 0
        DenaryNo = 0
        validBinaryString = True

        Console.Write("Enter Binary Number: ")
        Str1 = Console.ReadLine

        If Len(Str1) <= 8 And Len(Str1) > 0 Then
            For Count = 1 To Len(Str1)
                NextChar = Mid(Str1, Count, 1)
                If NextChar <> "1" And NextChar <> "0" Then
                    validBinaryString = False

                End If
            Next
        Else : validBinaryString = False

        End If

        If validBinaryString = False Then
            Console.Write("Not a valid binary number...")

        End If

        '(b)'

        If validBinaryString = True Then

            For Count = 1 To Len(Str1)
                Str2 = Mid(Str1, Count, 1) & Str2
            Next

            For Count = 1 To Len(Str2)
                NextChar = Mid(Str2, Count, 1)
                NextNum = 0
                If NextChar = "1" Then
                    NextNum = 1
                End If

                If Count = 1 Then
                    DenaryNo = DenaryNo + NextNum
                End If

                If Count = 2 Then
                    DenaryNo = DenaryNo + NextNum * 2
                End If

                If Count = 3 Then
                    DenaryNo = DenaryNo + NextNum * 4
                End If

                If Count = 4 Then
                    DenaryNo = DenaryNo + NextNum * 8
                End If

                If Count = 5 Then
                    DenaryNo = DenaryNo + NextNum * 16
                End If

                If Count = 6 Then
                    DenaryNo = DenaryNo + NextNum * 32
                End If

                If Count = 7 Then
                    DenaryNo = DenaryNo + NextNum * 64
                End If

                If Count = 8 Then
                    DenaryNo = DenaryNo + NextNum * 128
                End If
            Next

            Console.WriteLine(Str1 & " = " & DenaryNo)
        End If

        Console.ReadKey()
    End Sub

End Module
