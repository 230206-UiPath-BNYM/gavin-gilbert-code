Imports System

Module Program

    Sub Main(args As String())

		Dim arr = New Integer() { 1, 1, 2, 2, 3 }
		Dim sightings As New Dictionary(Of Integer, Integer)

		For Each num As Integer In arr
			If sightings.ContainsKey(num) Then
				sightings(num) = sightings(num) + 1
			Else
				sightings.Add(num, 1)
			End If

		Next

		For Each sighting As KeyValuePair(Of Integer, Integer) In sightings
			Console.WriteLine("{0}: {1}", sighting.Key, sighting.Value)
		Next

    End Sub

End Module
