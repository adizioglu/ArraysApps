Imports System

Module Program
    Sub Main(args As String())

        ' 0-based counting - 0,1,2,3,4
        ' 1-based counting - 1,2,3,4,5

        'Dim firstNames(4) As String

        'firstNames(0) = "Tim"
        'firstNames(1) = "Sue"
        'firstNames(2) = "Bob"
        'firstNames(4) = "Jane"

        'Console.WriteLine($"The firstNames are {firstNames(0)}, {firstNames(1)}, {firstNames(2)}, {firstNames(4)}")

        'firstNames(0) = "Timothy"

        'Console.WriteLine(firstNames(0))

        'firstNames(5) = "Robert"

        ' single quote identifies a char
        ' double quotes identifies a string
        Dim data As String = "Tim,Sue,Bob,Jane,Frank"
        Dim firstNames() As String = data.Split(","c)

        Console.WriteLine(firstNames(firstNames.Length - 1))

        Console.WriteLine(firstNames.Length)

        Dim lastNames() As String = {"Corey", "Smith", "Jones"}

        Dim ages() As Integer = {2, 3, 4}

    End Sub
End Module
