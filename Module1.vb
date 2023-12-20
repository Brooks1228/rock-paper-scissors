Imports System.Runtime.InteropServices

Module Module1
    'brooks keller
    '12/12/23
    'rock paper scissors
    Private usermoves(4), compmoves(4) As Integer
    Private outcomes(4) As String
    Private win, loss, tie As Integer


    Sub Main()
        ascii()
        Dim rounds As Integer = 1
        For i As Integer = 0 To usermoves.Length - 1
            Console.WriteLine($"round {rounds}!")
            usermoves(i) = getValidIntInput()
            compmoves(i) = compMove()
            outcomes(i) = DetermineOutcome(usermoves(i), compmoves(i))
            Console.WriteLine($"You played {ConvertNumToWord(usermoves(i))}, the computer played {ConvertNumToWord(compmoves(i))} You {outcomes(i)}.")
            rounds += 1
            Console.WriteLine()
        Next
        printTable()
        Console.WriteLine()

        Console.WriteLine("press any key to quit")
        Console.ReadKey()
    End Sub
    ''' <summary>
    ''' this sub here simply prints out the ascii art in order to reduce mess
    ''' </summary>
    Sub ascii()

        Console.WriteLine(".-. .-. .-. . .     .-. .-. .-. .-. .-.     .-. .-. .-. .-. .-. .-. .-. .-.")
        Console.WriteLine("|(  | | |   |<      |-' |-| |-' |-  |(      `-. |    |  `-. `-. | | |(  `-.")
        Console.WriteLine("' ' `-' `-' ' ` ,   '   ` ' '   `-' ' ' ,   `-' `-' `-' `-' `-' `-' ' ' `-'")
        Console.WriteLine("    _______           _______               _______")
        Console.WriteLine("---'   ____)      ---'   ____)____     ---'    ____)____")
        Console.WriteLine("      (_____)               ______)               ______)")
        Console.WriteLine("      (_____)               _______)           __________)")
        Console.WriteLine("      (____)               _______)           (____)")
        Console.WriteLine("---.__(___)       ---.__________)      ---.__(___)")
    End Sub
    ''' <summary>
    ''' gets a valid integer input from the user and makes sure its a correct input
    ''' </summary>
    ''' <returns>the number the user entered</returns>
    Function getValidIntInput() As Integer
        Dim input As String
        Dim num As Integer
        Dim valid As Boolean = False
        Dim rounds As Integer = 1
        While Not valid
            Console.Write("enter 1 for rock, 2 for paper, or 3 for scissors > ")
            input = Console.ReadLine
            Integer.TryParse(input, num)
            If num >= 1 AndAlso num <= 3 Then
                valid = True
            Else
                Console.WriteLine("Invalid Input")
            End If
        End While
        Return num
    End Function
    ''' <summary>
    ''' this here gets a random number and then has the computer play that random move.
    ''' </summary>
    ''' <returns>the computers move</returns>
    Function compMove() As Integer
        Dim compplay As Integer
        Dim rand As New Random
        compplay = rand.Next(1, 4)

        Return compplay
    End Function
    ''' <summary>
    ''' this here parses the number the computer and user gets, and converts it to a word
    ''' </summary>
    ''' <param name="num"></param>
    ''' <returns>converted number</returns>
    Function ConvertNumToWord(num As Integer) As String
        Dim word As String = "undefined"
        If num = 1 Then
            word = "Rock"
        ElseIf num = 2 Then
            word = "Paper"
        ElseIf num = 3 Then
            word = "Scissors"
        End If
        Return word
    End Function
    ''' <summary>
    ''' determines the outcome and sees if the computer won, if the user won, or if it was a tie
    ''' </summary>
    ''' <param name="user"></param>
    ''' <param name="comp"></param>
    ''' <returns></returns>
    Function DetermineOutcome(user As Integer, comp As Integer) As String
        Dim outcome As String
        If (user = 1 AndAlso comp = 3) OrElse (user = 2 AndAlso comp = 1) OrElse (user = 3 AndAlso comp = 2) Then
            outcome = "Won"
            win += 1
        ElseIf user = comp Then
            outcome = "Tied"
            tie += 1
        Else
            outcome = "Lost"
            loss += 1
        End If
        Return outcome
    End Function
    ''' <summary>
    ''' a sub for formatting the report line
    ''' </summary>
    ''' <param name="str1"></param>
    ''' <param name="str2"></param>
    ''' <param name="str3"></param>
    ''' <param name="str4"></param>
    Sub printReportLine(str1 As String, str2 As String, str3 As String, str4 As String)
        Console.WriteLine("| {0} | {1} | {2} | {3} |", str1.PadLeft(6), str2.PadLeft(17), str3.PadLeft(17), str4.PadLeft(7))
    End Sub
    ''' <summary>
    ''' prints the table to show all of the data using the arrays and the printReportLine sub for help
    ''' </summary>
    Sub printTable()
        Dim round As Integer = 1
        printReportTitle()
        Console.WriteLine("".PadRight(60, "-"))
        printReportLine("round", "user played", "computer played", "outcome")
        For i As Integer = 0 To usermoves.Length - 1
            Console.WriteLine("".PadRight(60, "-"))
            printReportLine(round, ConvertNumToWord(usermoves(i)), ConvertNumToWord(compmoves(i)), outcomes(i))
            round += 1

        Next
        Console.WriteLine("".PadRight(60, "-"))
        getPercentAndWin()


    End Sub
    ''' <summary>
    ''' prints the title that says rock paper scissors report (this is being used to minimize messy code in the table sub
    ''' </summary>
    Sub printReportTitle()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("".PadRight(60, "#"))
        Console.WriteLine("###############  Rock Paper Scissors Report  ###############")
        Console.WriteLine("".PadRight(60, "#"))
    End Sub
    ''' <summary>
    ''' this here determines the percents and determines your win or loss outcome
    ''' </summary>
    Sub getPercentAndWin()
        Dim wperc As Double = win / usermoves.Length
        Dim lperc As Double = loss / usermoves.Length
        Dim tperc As Double = tie / usermoves.Length
        Console.WriteLine($"You won {wperc.ToString("P2")} of the times")
        Console.WriteLine($"You tied {tperc.ToString("P2")} of the times")
        Console.WriteLine($"You lost {lperc.ToString("P2")} of the games")
        Console.WriteLine()
        If wperc > lperc Then
            Console.WriteLine("you won the game!!!")
        ElseIf lperc > wperc Then
            Console.WriteLine("you lost...")
        Else
            Console.WriteLine("you tied!")
        End If
    End Sub
End Module