namespace DiamondProblem
{
    class D : IB, IC
    {
        void IB.Show() => Console.WriteLine("IB's Show");
        void IC.Show() => Console.WriteLine("IC's Show");

        public void Show() => Console.WriteLine("D's own Show");
    }
}
