using System;

/*

Rock paper scissors game that tracks:

forever:

Device 
Time spent playing
Dates played
Wins and losses

during runtime:

spelling mistakes

with possibilities of prohibiting player from playing
and other fun logic

*/
namespace RockPaperScissors
{
    class Program
    {
        static string[] PLAYERMOVES = {"Rock", "Paper", "Scissors"};
        static void Main()
        {
            Console.Write("Lets play RPS, pick you move: ");
            string playerMove = Console.ReadLine();

            if (!PLAYERMOVES.Contains(playerMove))
            {
                Console.WriteLine("Thy not proceed. Exiting");
                Environment.Exit(0);
            }

            Random rand = new Random();
            string computerMove = PLAYERMOVES[rand.Next(PLAYERMOVES.Length)];

            int player = Array.IndexOf(PLAYERMOVES, playerMove);
            int computer = Array.IndexOf(PLAYERMOVES, computerMove);

            switch ((player - computer + 3) % 3)
            {
                case 0:
                    Console.WriteLine("Draw!");
                    break;

                case 1:
                    Console.WriteLine("Player wins!");
                    break;

                case 2:
                    Console.WriteLine("Computer wins!");
                    break;
            }
        }
    }
}