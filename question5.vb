Module Program
    Public Class Person
        Public value As String

        Public Sub New()
            value = "This is default constructor"
        End Sub

        Public Sub New(name As String)
            value = name
        End Sub

        Public Sub PrintName()
            Console.WriteLine(value)
        End Sub
    End Class
    Sub Main()

        Dim person1 As New Person()
        person1.PrintName()

        Dim person2 As New Person("This is parameterized constructor")
        person2.PrintName()

        Console.ReadLine()
    End Sub

End Module
