Imports System

Module Program

    Sub Main(args As String())

		Dim input As String
		Dim numSightings As Integer
		Dim temp As Integer = 0
		Dim lst As New List(of Integer)

		Console.WriteLine("How many sightings would you like to enter: ")
		input = Console.ReadLine()
		Integer.TryParse(input, numSightings)


		For i As Integer = 1 To numSightings
			Console.WriteLine("Enter Sighting {0}: ", i)
			input = Console.ReadLine()
			Integer.TryParse(input, temp)
			lst.add(temp)
		Next
		
		Dim sightings As New Dictionary(Of Integer, Integer)

		For Each num As Integer In lst
			If sightings.ContainsKey(num) Then
				sightings(num) = sightings(num) + 1
			Else
				sightings.Add(num, 1)
			End If

		Next

		Dim mostSpotted As Integer
		Dim maxSpots As Integer = 0

		For Each sighting As KeyValuePair(Of Integer, Integer) In sightings
			If sighting.Value > maxSpots Then
				maxSpots = sighting.Value
				mostSpotted = sighting.Key
			End If
		Next

		Console.WriteLine()
		Console.WriteLine("Most Sighted: {0}", mostSpotted)
		Console.WriteLine("# of Sightings: {0}", maxSpots)

    End Sub

End Module
