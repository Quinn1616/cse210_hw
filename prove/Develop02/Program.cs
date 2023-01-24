using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Quit");

        string userInput;
        Console.Write("What would you like to do? ");
        userInput = Console.ReadLine(); 

        while (userInput == "1" || userInput == "2")

            if (userInput == "1")
            {
             Journal.promptGenerator();
             Console.Write("What would you like to do? ");
             userInput = Console.ReadLine();
            }

            else if (userInput == "2")
            {
             Read.fileRead();
             Console.Write("What would you like to do? ");
             userInput = Console.ReadLine();
            }

        if (userInput == "3")
        {
         Console.WriteLine("Goodbye.");
        }

        else
        {
         Console.WriteLine("Invalid input.");
        }
    }
}

        