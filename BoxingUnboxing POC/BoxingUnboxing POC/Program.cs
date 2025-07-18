namespace BoxingUnboxing_POC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 123456;              
            object boxedNum = num;      

            Console.WriteLine($"Boxed Value: {boxedNum}");

            int unboxedNum = (int)boxedNum;
            Console.WriteLine($"Unboxed Value: {unboxedNum}");
        }
    }
}
