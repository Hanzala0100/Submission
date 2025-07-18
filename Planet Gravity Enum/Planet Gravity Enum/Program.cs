namespace Planet_Gravity_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice=1;
            while (choice==1) { 
                Console.WriteLine("Enter your weight in KG:");
                double WeightonEarth = double.Parse(Console.ReadLine());
                if (WeightonEarth < 0)
                {
                    Console.WriteLine("Weight cannot be negative. Please enter a valid weight.");
                    continue;
                }
                GetGravity(WeightonEarth);
                Console.WriteLine("Do you want to continue? (1.Yes/2.No)");
                choice = int.Parse(Console.ReadLine());

            }
        }

        private static void GetGravity(double v)
        {
            Console.WriteLine("Weight on different planets:\n");
            Console.WriteLine("Weight on Mercury: {0} KG", v * (double)Planet_Gravity.MERCURY /100);
            Console.WriteLine("Weight on Venus: {0} KG", v * (double)Planet_Gravity.VENUS / 100);
            Console.WriteLine("Weight on Earth: {0} KG", v * (double)Planet_Gravity.EARTH / 100);
            Console.WriteLine("Weight on Mars: {0} KG", v * (double)Planet_Gravity.MARS/ 100);
            Console.WriteLine("Weight on Jupiter: {0} KG", v * (double)Planet_Gravity.JUPITER / 100);
            Console.WriteLine("Weight on Saturn: {0} KG", v * (double)Planet_Gravity.SATURN / 100);
            Console.WriteLine("Weight on Uranus: {0} KG", v * (double)Planet_Gravity.URANUS / 100);
            Console.WriteLine("Weight on Neptune: {0} KG", v * (double)Planet_Gravity.NEPTUNE / 100);
        }
    }
}
