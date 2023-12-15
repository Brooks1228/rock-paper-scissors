Imports System.Runtime.InteropServices

Module Module1
    'brooks keller
    '12/12/23
    'rock paper scissors
    Private usermoves(4), compmoves(4) As Integer
    Private outcomes(4) As String


    Sub Main()
        ascii()

        For i As Integer = 0 To usermoves.Length - 1
            usermoves(i) = getValidIntInput()
            compmoves(i) = compMove()
            outcomes(i) = determineOutcome(usermoves(i), compmoves(i))
            Console.WriteLine($"You played {ConvertNumToWord(usermoves(i))}, the computer played {ConvertNumToWord(compmoves(i))} You {outcomes(i)}.")
        Next


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
    Function getValidIntInput() As Integer
        Dim input As String
        Dim num As Integer
        Dim valid As Boolean = False
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

    Function DetermineOutcome(user As Integer, comp As Integer) As String
        Dim outcome As String = "Lost"
        If (user = 1 AndAlso comp = 3) OrElse (user = 2 AndAlso comp = 1) OrElse (user = 3 AndAlso comp = 2) Then
            outcome = "Won"
        ElseIf user = comp Then
            outcome = "Tied"
        End If
        Return outcome
    End Function

End Module