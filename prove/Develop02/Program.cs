using System;

class Program
{
    static void Main(string[] args)
    {
       
       Console.WriteLine("Welcome to the Journal Program!");
       Console.WriteLine("Please select one of the following choices:");
       Console.WriteLine("1. Write");
       Console.WriteLine("2. Display");
       Console.WriteLine("3. Load");
       Console.WriteLine("4. Save");
       Console.WriteLine("5. Quit");
       //Console.Write("What would you like to do? ");
       string userInput = "1"; 
       //userInput = Console.ReadLine();

       if (userInput == "1")
        {
        Console.WriteLine(Journal.promptGenerator());
        //string promptEntry = Console.ReadLine();
        Journal.entry();
        }

       else if (userInput == "2")
       {
        Journal.fileRead();
       }

       else if (userInput == "3")
        {
        Entries.FileOpen();
        }

       else if (userInput == "4")
       {}

       else if (userInput == "5")
       {
        Console.WriteLine("Goodbye.");
       }

       else
       {
            Console.WriteLine("Invalid input.");
       }

    }
}

// class for entries and a class for prompts
// display method for each class
// entry attributes - str date/time. str entry text
// prompt attributes - str promp text


// menu / user interface
// journa/prompt class
// entries class
// save and load functions
// maybe json
        