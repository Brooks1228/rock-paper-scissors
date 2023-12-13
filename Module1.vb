Module Module1
    'brooks keller
    '12/12/23
    'rock paper scissors
    Dim rand As New Random


    Sub Main()
        ascii()
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
    ''' this here promps the user for input, and collects their response
    ''' </summary>
    ''' <returns>rock paper or scissors</returns>
    Function getvalidinput()
        Dim answer As String
        Do
            Console.WriteLine("enter 1 for rock, 2 for paper, or 3 for scissors")
            answer = Console.ReadLine
            If answer = "1" Then

            End If
        Loop
    End Function
End Module
