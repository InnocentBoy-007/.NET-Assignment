namespace Program
{
    public class Person
    {
        public string Value;

        public Person()
        {
            Value = "This is default constructor";
        }

        public Person(string name)
        {
            Value = name;
        }

        public void PrintName()
        {
            Console.WriteLine(Value);
        }
    }

    class MainClass
    {
        static void Main()
        {
            
            Person person1 = new Person();
            person1.PrintName();

            Person person2 = new Person("This is parameterized constructor");
            person2.PrintName();

            Console.ReadLine();
        }
    }
}
