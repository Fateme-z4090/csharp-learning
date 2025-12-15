using System;

class Program
{
    static void Main()
    {
        // This is a guess the number game.

        Random random = new Random();
        int secretNumber = random.Next(1, 21); // 1 to 20
        Console.WriteLine("I am thinking of a number between 1 and 20.");

        // Ask the player to guess 6 times.
        for (int guessesTaken = 1; guessesTaken <= 6; guessesTaken++)
        {
            Console.WriteLine("Take a guess.");
            Console.Write("> ");
            int guess = int.Parse(Console.ReadLine());

            if (guess < secretNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                // Correct guess!
                Console.WriteLine("Good job! You got it in " + guessesTaken + " guesses!");
                return; // exit the program early
            }
        }

        // If the player didn't guess the number in 6 tries:
        Console.WriteLine("Nope. The number was " + secretNumber);
    }
}
