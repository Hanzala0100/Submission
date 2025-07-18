snamespace Product_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------ANUPAM SHOPPING CENTER------");

            Console.WriteLine("Welcome to Anupam Shopping Center!");

            Product Wheat = new Product(1, "Wheat", 50.00m);
            Product Rice = new Product(2, "Rice", 60.00m);
            Product Sugar = new Product(3, "Sugar", 40.00m);
            Product Salt = new Product(4, "Salt", 20.00m);

            Wheat.DisplayProductInfo();
            Rice.DisplayProductInfo();
            Sugar.DisplayProductInfo();
            Salt.DisplayProductInfo();
        }
    }
}
