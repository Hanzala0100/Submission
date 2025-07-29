namespace InterfaceDemo
{
    class Car : IDrive
    {
        public void Start() => Console.WriteLine("Car starting...");
        public void Stop() => Console.WriteLine("Car stopping...");
    }
}
