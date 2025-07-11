namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please pass a comma-separated string like: Sachin,Aurionpro,Mumbai");
                return;
            }

            string input = args[0];
            string[] parts = input.Split(',');

            if (parts.Length != 3)
            {
                Console.WriteLine("Invalid input format. Expected format: Name,Company,Location");
                return;
            }

            Console.WriteLine("Developer name is : " + parts[0]);
            Console.WriteLine("Company name is : " + parts[1]);
            Console.WriteLine("Locaiton is : " + parts[2]);
        }
    }

}
