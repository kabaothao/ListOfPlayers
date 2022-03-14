using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public static class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new();

            //Player player1 = new Player("Chad");
            //Player player2 = new Player("Steve");
            //Player player3 = new Player("Bao");

            players.Add(new Player("Chad"));
            players.Add(new Player("Steve"));
            players.Add(new Player("Bao"));
            players.Add(new Player("Ashley"));
            for (int i = 0; i < players.Count; i++)
            {
                Player player = players[i];
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

// See https://aka.ms/new-console-template for more information
/*
 List of objects to keep track of the amount of players in our game and their names
 */