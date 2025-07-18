using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_App
{
    internal class Player
    {
        private readonly int id;
        private readonly string name;
        private readonly int age;

        public Player(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public Player(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.age = 20;
        }

        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }

        public void WhoIsElder(Player player1, Player player2)
        {
            if (player1.getAge() > player2.getAge())
            {
                Console.WriteLine($"{player1.getName()} is elder than {player2.getName()}");
            }
            else if (player1.getAge() < player2.getAge())
            {
                Console.WriteLine($"{player2.getName()} is elder than {player1.getName()}");
            }
            else
            {
                Console.WriteLine($"{player1.getName()} and {player2.getName()} are of the same age");
            }
        }
    }
}
