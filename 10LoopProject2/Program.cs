using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ROCK, PAPER, SCISSORS");

        int wins = 0;
        int losses = 0;
        int ties = 0;

        Random random = new Random();

        while(true)
        {
            Console.WriteLine($"{wins} Wins, {losses} Losses, {ties} Ties");

            string playerMove;

            while(true)
            {
                Console.WriteLine("inter your move: (r)ock (p)aper (s)cissors or (q)uit");
                Console.Write(">");
                playerMove = Console.ReadLine();

                if(playerMove == "q")
                {
                    return;
                }

                if(playerMove == "r" || playerMove == "p" || playerMove == "s")
                {
                    break;
                }

                Console.WriteLine("Type on of r, p, s or q.");
            }

            if(playerMove == "r")
            {
                Console.WriteLine("Rock versus ...");
            }
            if(playerMove == "p")
            {
                Console.WriteLine("Paper versus ...");
            }
            if(playerMove == "s")
            {
                Console.WriteLine("Scissors versus ...");
            }

            int moveNumber = random.Next(1, 4);
            string computerMove = "";

            if(moveNumber == 1)
            {
                computerMove = "r";
                Console.WriteLine("Rock");
            }
            else if(moveNumber == 2)
            {
                computerMove = "p";
                Console.WriteLine("Paper");
            }
            else if(moveNumber == 3)
            {
                computerMove = "s";
                Console.WriteLine("Scissors");
            }

            if(playerMove == computerMove)
            {
                Console.WriteLine("It is a tie!");
                ties++;
            }
            else if(playerMove == "r" && computerMove == "s" ||
                    playerMove == "s" && computerMove == "p" ||
                    playerMove == "p" && computerMove == "r" )
            {
                Console.WriteLine("You win!");
                wins++;
            }
            else
            {
                Console.WriteLine("You lose1");
                losses++;
            }
        }
    }
}