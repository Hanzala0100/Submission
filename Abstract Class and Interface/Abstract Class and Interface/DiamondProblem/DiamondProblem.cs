namespace DiamondProblem
{
    public class DiamondProblemDemo
    {
        public static void Run()
        {
            D obj = new D();
            obj.Show();

            ((IB)obj).Show();
            ((IC)obj).Show();
        }
    }
}
