using System;

public class Journal
{
    
    static void promptGenerator()
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

    }
}