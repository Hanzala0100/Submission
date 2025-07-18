namespace Player_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "Abhay", 21);
            Player player2 = new Player(2, "Vivek");

            Console.WriteLine($"Player 1: {player1.getName()}, ID: {player1.getId()}, Age: {player1.getAge()}");
            Console.WriteLine($"Player 2: {player2.getName()}, ID: {player2.getId()}, Age: {player2.getAge()}\n");

            player1.WhoIsElder(player1, player2);
        }
    }
}
