Module Program
    Public Interface IAnimal
        Sub Speak()
    End Interface


    Public Class Dog
        Implements IAnimal

        Public Sub Speak() Implements IAnimal.Speak
            Console.WriteLine("The dog is barking Woof!")
        End Sub
    End Class

    Public Interface IFlyable
        Sub Fly()
    End Interface

    Public Interface ISwimmable
        Sub Swim()
    End Interface

    Public Class Duck
        Implements IFlyable
        Implements ISwimmable

        Public Sub Fly() Implements IFlyable.Fly
            Console.WriteLine("The duck is flying!")
        End Sub

        Public Sub Swim() Implements ISwimmable.Swim
            Console.WriteLine("The duck is swimming!")
        End Sub
    End Class

    Sub Main()
        ' Using the single interface
        Dim myDog As IAnimal = New Dog()
        myDog.Speak()

        ' Using the multi-interface
        Dim myDuck As Duck = New Duck()
        myDuck.Fly()
        myDuck.Swim()
    End Sub
End Module