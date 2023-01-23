using System;
using System.IO;
using System.Text;
public class Entries
{
    public static void FileOpen()
    {
        string filePath = @"C:\Users\Quinn\Desktop\OneDrive - BYU-Idaho\Programming with Classes (CSE 210)\cse210_hw\prove\Develop02\EntriesJournal.txt";
        using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read));
    }
    //Load EntriesJournal.txt
    
}