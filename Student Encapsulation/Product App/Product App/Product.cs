using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_App
{
    internal class Product
    {
        private int Id;
        private string Name;
        private decimal Price;
        private readonly double DiscountPercentage = 20;

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public decimal GetPrice()
        {
            return Price;
        }
        public decimal GetDiscountedPrice()
        {
            return Price - (Price * (decimal)(DiscountPercentage / 100));
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"\nProduct ID: {Id}");
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Original Price: {Price} Rs");
            Console.WriteLine($"Discounted Price: {GetDiscountedPrice()} Rs\n");
        }
    }
}
