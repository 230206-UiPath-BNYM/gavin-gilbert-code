Imports System

Module Program

	Sub Main(args As String())

		Dim mistakesAllowed As Integer = 6
		Dim guesses As String = ""

		Console.WriteLine("Hello! Let's play Hangman!")
		Console.WriteLine("What would you like the mystery word to be? ")
		
		Dim wordToBeGuessed As String = Console.ReadLine()
		Dim wordCopy As String = wordToBeGuessed

		Console.WriteLine("The mystery word has {0} letters.", wordToBeGuessed.Length)

		While mistakesAllowed > 0 And wordCopy.Length > 0

			Console.WriteLine("Enter your guess: ")
			Dim guess As String = Console.ReadLine()

			If (wordToBeGuessed.contains(guess)) Then
				Console.WriteLine("Mystery Word contains {0}.", guess)
				wordCopy = Replace(wordCopy, guess, "")
			Else
				Console.WriteLine("Mystery Word does NOT contain {0}.", guess)
				mistakesAllowed = mistakesAllowed - 1
			End If

			guesses += guess

			For Each letter As Char In wordToBeGuessed
				If (guesses.Contains(letter)) Then
					Console.Write(letter)
				Else
					Console.write("_")
				End If
			Next

			Console.WriteLine()

		End While

		If (wordCopy.Length > 0) Then
			Console.WriteLine("You Lost.")
		Else
			Console.WriteLine("You Won!")
		End If

	End Sub

End Module