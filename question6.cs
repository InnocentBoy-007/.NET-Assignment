public class Person
{
    public void Identify()
    {
        Console.WriteLine("I am a person.");
    }
}

// Class MyFriend inherits from Person (Single Inheritance)
public class MyFriend : Person
{
    public void Speak()
    {
        Console.WriteLine("My friend can speak");
    }

    public void Eat()
    {
        Console.WriteLine("My friend can eat");
    }
}

// Class Me inherits from MyFriend (Single Inheritance) and implements multiple interfaces
public class Me : MyFriend
{
    public void Speak()
    {
        Console.WriteLine("I can speak");
    }

    public void Eat()
    {
        Console.WriteLine("I can eat");
    }

    public void Run()
    {
        Console.WriteLine("But only I can run");
    }
}

class Program
{
    public static void Main()
    {
        MyFriend obj1 = new MyFriend();
        obj1.Identify(); 
        obj1.Speak();
        obj1.Eat();

        Me obj2 = new Me();
        obj2.Identify(); 
        obj2.Speak();
        obj2.Eat();
        obj2.Run();

        Console.ReadLine();
    }
}
