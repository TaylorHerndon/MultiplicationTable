Option Strict On
Option Explicit On

'Taylor Herndon
'RCET0265
'Spring 2021
'Multiplication Table
'https://github.com/TaylorHerndon/MultiplicationTable
Module MultiplicationTable

    Sub Main()

        Dim bounds As Integer = Nothing
        Dim row As Integer = 0
        Dim collumn As Integer = 0
        Dim indexString As String = ""
        Dim total As Integer = 0

        'Get the bounds of the multiplication table.
        Do Until bounds <> Nothing
            Console.WriteLine("[Enter a number you want to make a table of.]")
            Try
                bounds = Convert.ToInt32(Console.ReadLine())
            Catch
                bounds = Nothing
                Console.Clear()
            End Try

        Loop

        Console.Clear()

        'Writes out the multiplication table
        For row = 1 To bounds

            For column = 1 To bounds
                total = row * column
                indexString = Convert.ToString(total)
                Console.Write(indexString.PadLeft(5))
            Next

            Console.WriteLine(vbNewLine)
        Next

        Console.ReadKey()

    End Sub

End Module
