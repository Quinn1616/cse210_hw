using System;
public class Read
{
    public static void fileRead()
    {
        string[] lines = File.ReadAllLines("EntriesJournal.txt");
        foreach (string line in lines)  
        Console.WriteLine(line);   
    }
}