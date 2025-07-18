using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Discount_App
{
    internal class Book
    {
        public string Title;
        public string Author;
        public double Price;
        public bool IsBestSeller;

        public Book(string title, string author, double price, bool isBestSeller)
        {
            Title = title;
            Author = author;
            Price = price;
            IsBestSeller = isBestSeller;
        }

        public double GetDiscountedPrice()
        {
            if (IsBestSeller && Price >500)
            {
                return Price * 0.85; 
            }
            
            else if (IsBestSeller)
            {
                return Price * 0.90;
            }
            else if(Price >500)
            {
                return Price * 0.95;
            }

            return Price;
        }
    }
}
