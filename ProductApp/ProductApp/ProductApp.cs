using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    public class ProductApp
    {
        public int id;
        public string name;
        public int price;
        public readonly int DISCOUNT_PERCENTAGE = 10;


        public ProductApp(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int calculateDiscountedPrice()
        {
            return price - (price * DISCOUNT_PERCENTAGE / 100);
        }

    public void DisplayProductDetails(ProductApp product)
        {
            Console.WriteLine("-----------Product Details-----------");
            Console.WriteLine($"Product ID: {product.id}");
            Console.WriteLine($"Product Name: {product.name}");
            Console.WriteLine($"Original Price: {product.price}");
            Console.WriteLine($"Discounted Price with {DISCOUNT_PERCENTAGE}% Discount: {product.calculateDiscountedPrice()}");
            Console.WriteLine("-------------------------------------");
        }
    }

}


