namespace AbstractClassDemo
{
    abstract class Animal
    {
        public abstract void MakeSound();
        public void Sleep() => Console.WriteLine("Sleeping...");
    }
}
