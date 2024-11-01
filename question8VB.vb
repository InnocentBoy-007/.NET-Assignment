Imports System
Imports System.Collections
Imports System.Collections.Generic

Module Program
    Sub Main(args As String())
        Dim arrayList As New ArrayList()s

        arrayList.Add("Apple")
        arrayList.Add("Banana")
        arrayList.Add("Cherry")
        arrayList.Add(42)

        ' Displaying elements in the ArrayList
        Console.WriteLine("ArrayList contents:")
        For Each item In arrayList
            Console.WriteLine(item)
        Next

        ' Finding the index of "Banana"
        Dim index As Integer = FindIndexOfItem(arrayList, "Banana")
        If index <> -1 Then
            Console.WriteLine(vbLf & "'Banana' found at index: " & index)
        Else
            Console.WriteLine(vbLf & "'Banana' not found in the ArrayList.")
        End If

        Dim dictionary As New Dictionary(Of String, Integer)()

        dictionary.Add("Apple", 1)
        dictionary.Add("Banana", 2)
        dictionary.Add("Cherry", 3)

        ' Displaying elements in the Dictionary
        Console.WriteLine(vbLf & "Dictionary contents:")
        For Each kvp In dictionary
            Console.WriteLine("Key: " & kvp.Key & ", Value: " & kvp.Value)
        Next

        ' Accessing a value by key
        Dim value As Integer
        If dictionary.TryGetValue("Banana", value) Then
            Console.WriteLine(vbLf & "Value for 'Banana': " & value)
        Else
            Console.WriteLine(vbLf & "Key 'Banana' not found.")
        End If
    End Sub

    ' Function to find the index of an item in the ArrayList
    Function FindIndexOfItem(list As ArrayList, item As Object) As Integer
        Return list.IndexOf(item)
    End Function
End Module