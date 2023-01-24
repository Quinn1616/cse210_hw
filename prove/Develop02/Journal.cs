using System;
public class Journal
{
    public static void promptGenerator()
    {
        var random = new Random();
        var _prompts = new List<string>();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        string promptEntry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        promptEntry = dateText + " " + _prompts[index] + " " + promptEntry + "\n";  
        File.AppendAllText(@"C:\Users\Quinn\OneDrive - BYU-Idaho\Programming with Classes (CSE 210)\cse210_hw\prove\Develop02\EntriesJournal.txt", promptEntry); 
    }
    public static void fileRead()
    {
        string[] lines = File.ReadAllLines("EntriesJournal.txt");
        foreach (string line in lines)  
        Console.WriteLine(line);   
    }
}