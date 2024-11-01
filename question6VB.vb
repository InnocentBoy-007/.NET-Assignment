Public Class Person
    Public Sub Identify()
        Console.WriteLine("I am a person.")
    End Sub
End Class

Public Class MyFriend
    Inherits Person

    Public Sub Speak()
        Console.WriteLine("My friend can speak")
    End Sub

    Public Sub Eat()
        Console.WriteLine("My friend can eat")
    End Sub
End Class

Public Class Myself
    Inherits MyFriend

    Public Sub Speak()
        Console.WriteLine("I can speak")
    End Sub

    Public Sub Eat()
        Console.WriteLine("I can eat")
    End Sub

    Public Sub Run()
        Console.WriteLine("But only I can run")
    End Sub
End Class

Module Program
    Sub Main()
        Dim obj1 As New MyFriend()
        obj1.Identify()
        obj1.Speak()
        obj1.Eat()

        Dim obj2 As New Myself()
        obj2.Identify()
        obj2.Speak()
        obj2.Eat()
        obj2.Run()

        Console.ReadLine()
    End Sub
End Module