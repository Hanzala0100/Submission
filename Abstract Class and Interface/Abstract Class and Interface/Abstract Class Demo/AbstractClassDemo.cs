namespace AbstractClassDemo
{
    class Dog : Animal
    {
        public override void MakeSound() => Console.WriteLine("Woof!");
    }

    public class AbstractClassDemo
    {
        public static void Run()
        {
            Animal dog = new Dog();
            dog.MakeSound();
            dog.Sleep();
        }
    }
}
