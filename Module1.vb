'Taylor Herndon
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/TaylorHerndon/MultiplicationTable

Imports System.Threading
Module Module1

    Sub Main()

        Dim Bounds As Integer = Nothing
        Dim Index As Integer = 0
        Dim Index2 As Integer = 0
        Dim IndexString As String = ""
        Dim Total As Integer = 0

        'Get the bounds of the multiplication table.
        Do Until Bounds <> Nothing

            Console.WriteLine("[Enter a number you want to make a table of.]")

            Try

                Bounds = Console.ReadLine()

            Catch

                Bounds = Nothing

                Console.Clear()

            End Try

        Loop

        Console.Clear()

        'Writes out the multiplication table

        For Index = 1 To Bounds

            For Index2 = 1 To Bounds

                'Value = Row x Column
                Total = Index * Index2

                IndexString = String.Format(Total)
                Console.Write(IndexString.PadLeft(5))

            Next

            Console.WriteLine(vbNewLine)

        Next

        Console.ReadKey()

    End Sub

End Module
