using System;
using System.Windows.Forms;


    class Program
    {


    [STAThread]
    static void Main()
        {
        //get text from clipboard
        string text = Clipboard.GetText();

        //split text into seprated lines
        string[] lines = text.Split(
            new[] { "\r\n", "\n" },
            StringSplitOptions.None
            );

        // Add "* " to the beginning of every line
        for (int i = 0; i< lines.Length; i++)
        {
            lines[i] = "*" + lines[i];        
        }

        // Join the lines back into one string
        string result = string.Join(Environment.NewLine, lines);

        // Copy the result to the clipboard
        Clipboard.SetText(result);

        // Display the result
        Console.WriteLine(result);

    }
}


