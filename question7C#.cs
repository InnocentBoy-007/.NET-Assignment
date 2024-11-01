
namespace InterfaceExample
{
    public interface IAnimal
    {
        void Speak();
    }

    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("The dog is barking Woof!");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("The duck is flying!");
        }

        public void Swim()
        {
            Console.WriteLine("The duck is swimming!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using the single interface
            IAnimal myDog = new Dog();
            myDog.Speak(); // Output: Woof!

            // Using the multi-interface
            Duck myDuck = new Duck();
            myDuck.Fly();  
            myDuck.Swim(); 
        }
    }
}