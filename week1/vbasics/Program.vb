Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World! Prepare to play hangman!")
        'idea: 1 letter per string, can + strings
        'start as all #####
        Dim l1 As String = "#"
        Dim l2 As String = "#"
        Dim l3 As String = "#"
        Dim l4 As String = "#"
        Dim l5 As String = "#"

		'our word: water
        Dim ourWord As String = "water"
        Dim guessWord As String = "#####"

        Dim chance As Integer = 6

        Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)

        Dim guess As String

        While chance > 0

	        Console.WriteLine("Please guess a letter.")
    	    guess = Console.ReadLine()
        	Console.WriteLine("Your letter is: " + guess)



	        Select Case guess
	            Case "w"
	                l1 = "w"
	                Console.WriteLine("Congragulations!")
	                Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)
	            Case "a"
	                l2 = "a"
	                Console.WriteLine("Congragulations!")
	                Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)
	            Case "t"
	                l3 = "t"
	                Console.WriteLine("Congragulations!")
	                Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5) 
	            Case "e"
	                l4 = "e"
	                Console.WriteLine("Congragulations!")
	                Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)
	            Case "r"
	                l5 = "r"
	                Console.WriteLine("Congragulations!")
	                Console.Writeline("Current Word: " + l1 + l2 + l3 + l4 + l5)
	            Case Else
	                chance = chance - 1
	                '& means I do not need to change chance
	                Console.WriteLine("Sorry, " & chance & " chances left.")

		        End Select

	        guessWord = l1+l2+l3+l4+l5
	
	        If ourWord.Equals(guessWord) Then 
	            Console.WriteLine("It matches!")
	            Exit While
	        End If

        
            
        End While

        Console.Writeline("Match? " & ourWord.Equals(guessWord))
        
    End Sub

End Module