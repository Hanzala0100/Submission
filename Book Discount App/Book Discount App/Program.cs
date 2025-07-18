namespace Book_Discount_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Bagde Book Store-----");
            Book book1 = new Book("C# Programming", "Arun Mittal", 600, true);
            Book book2 = new Book("Java Programming", "Mc Hill", 400, false);
            Book book3 = new Book("Python Programming", "John Sheby", 700, false);
            Book book4 = new Book("JavaScript Programming", "Janit Doshi", 300, true);

            List<Book> books = new List<Book> { book1, book2, book3, book4 };
            foreach (var book in books)
            {
                Console.WriteLine($"\nTitle: {book.Title}, \nAuthor: {book.Author}, \nPrice: {book.Price} Rs, \nDiscounted Price: {book.GetDiscountedPrice()} Rs\n");
            }
        }
    }
}
