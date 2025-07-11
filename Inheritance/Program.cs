namespace Inheritance
{

    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }

    public class Mammal : Animal
    {
        public void Walk()
        {
            Console.WriteLine("The mammal is walking.");
        }
    }

    public class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("The dog is barking.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog DogObject = new Dog();
            DogObject.Eat();
            DogObject.Walk();
            DogObject.Bark();
        }
    }
}
