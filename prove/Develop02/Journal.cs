using System;


public class Journal
{
    
    public static string promptGenerator()
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
        return (_prompts[index]);
    }
    public static void entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string promptEntry = dateText + " File write test\n";  
        File.AppendAllText(@"C:\Users\Quinn\Desktop\OneDrive - BYU-Idaho\Programming with Classes (CSE 210)\cse210_hw\prove\Develop02\EntriesJournal.txt", promptEntry); 

    }

    public static void fileRead()
    {
        //string text = File.ReadAllText("EntriesJournal.txt");  
        //Console.WriteLine(text);
        string[] lines = File.ReadAllLines("EntriesJournal.txt");
        foreach (string line in lines)  
        Console.WriteLine(line);   
    }
}