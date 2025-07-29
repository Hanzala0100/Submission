namespace InterfaceDemo
{
    public class InterfaceDemo
    {
        public static void Run()
        {
            IDrive car = new Car();
            car.Start();
            car.Stop();
        }
    }
}
