// See https://aka.ms/new-console-template for more information


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Bao");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }



            Console.ReadKey();
        }
    }


    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}