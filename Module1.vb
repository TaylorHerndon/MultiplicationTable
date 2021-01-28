'Taylor Herndon
'RCET0265
'Spring 2021
'Multiplication Table
'

Imports System.Threading
Module Module1

    Sub Main()

        Dim Bounds As Integer = Nothing
        Dim Index As Integer = 0
        Dim Index2 As Integer = 0
        Dim IndexString As String = ""
        Dim Total As Integer = 0

        Console.WriteLine("[Enter a number you want to make a table of.]")

        Do Until Bounds <> Nothing

            Try

                Bounds = Console.ReadLine()

            Catch

                Bounds = Nothing

                Console.Clear()
                Console.WriteLine("No, no, no that wont work...")
                Thread.Sleep(2000)
                Console.WriteLine("Just a single number, that's all.")
                Thread.Sleep(2000)

            End Try

        Loop

        Console.Clear()

        For Index = 1 To Bounds

            For Index2 = 1 To Bounds

                Total = Index * Index2

                IndexString = String.Format(Total)
                Console.Write(IndexString.PadLeft(5))

            Next

            Console.WriteLine(vbNewLine)

        Next

        Console.ReadKey()

    End Sub

End Module
