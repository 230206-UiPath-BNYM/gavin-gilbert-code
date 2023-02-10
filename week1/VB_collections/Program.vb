Imports System

Module Program

    Sub Main(args As String())
    ' Arrays, Lists, Dictionaries    

		' ======Arrays======
		' Arrays are a homogenous collection of items stored in a contiguous memore space
		' Declare arrays by including () after the variable name
		' Fun Fact: VB Arrays are zero-indexed
		Dim fruits(3) as String
		fruits(0) = "kiwi"
		fruits(1) = "strawberry"
		fruits(2) = "pineapple"

		For Each fruit As String In fruits
			Console.WriteLine(fruit)
		Next

		Console.WriteLine()

		' Problem is, Arrays are statically sized.

		' ======List======
		' Lists are an ordered, homogenous collection of items
		' Like arrays, they are also zero-indexed, but they can dynamically change size
		Dim students As New List(of String)

		students.add("Irving")
		students.add("Gavin")
		students.add("Chase")
		students.add("Amol")

		For Each student As String In students
			Console.WriteLine(student)
		Next

		Console.WriteLine()

		students(3) = "Amol Apte"
		students.Remove("Irving")

		Console.WriteLine(students(3))

		Console.WriteLine()

		' ======Dictionary======
		' A Dictionary is a collection of key-value pairs
		' You access these values based on their keys, not based on index

		Dim gradeBook As New Dictionary(Of String, Integer)
		gradeBook.Add("Justin", 95)
		gradeBook.Add("Marielle", 100)
		gradeBook.Add("Coco", 200)

		Console.WriteLine("Marielle got a grade of {0}.", gradeBook("Marielle"))

		Console.WriteLine()

		gradeBook.Remove("Marielle")

		For Each grade As KeyValuePair(Of String, Integer) In gradeBook
			Console.WriteLine("{0} got a grade of {1}.", grade.Key, grade.Value)
		Next

    End Sub

End Module