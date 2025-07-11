namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ProductApp product = new ProductApp(1, "Laptop", 1000);
            product.DisplayProductDetails(product);
           ProductApp product2 = new ProductApp(2, "Smartphone", 500);
            product2.DisplayProductDetails(product2);
        }
    }
}
