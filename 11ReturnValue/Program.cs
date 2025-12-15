using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ask a yes or no question:");
        Console.ReadLine();

        Random random = new Random();
        int r = random.Next(1, 10);  // 1 to 9 inclusive

        string fortune = GetAnswer(r);
        Console.WriteLine(fortune);
    }

    static string GetAnswer(int answerNumber)
    {
        // Returns a fortune string based on answerNumber 1–9
        if (answerNumber == 1)
            return "It is certain";
        else if (answerNumber == 2)
            return "It is decidedly so";
        else if (answerNumber == 3)
            return "Yes";
        else if (answerNumber == 4)
            return "Reply hazy, try again";
        else if (answerNumber == 5)
            return "Ask again later";
        else if (answerNumber == 6)
            return "Concentrate and ask again";
        else if (answerNumber == 7)
            return "My reply is no";
        else if (answerNumber == 8)
            return "Outlook not so good";
        else if (answerNumber == 9)
            return "Very doubtful";

        return "Error: Invalid number";
    }
}