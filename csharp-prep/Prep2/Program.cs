using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int final_grade = int.Parse(grade);
        
        string letter = "";

        if (final_grade >= 90)
        {
            letter = "A";
            //Console.Write("Your grade is A");
            //Console.Write("Congratulations you passed the class!");
        }
        else if (final_grade >= 80 && final_grade < 90)
        {
            letter = "B";
            //Console.Write("Your grade is B");
            //Console.Write("Congratulations you passed the class!");
        }
        else if (final_grade >= 70 && final_grade < 80)
        {
            letter = "C";
            //Console.Write("Your grade is C");
            //Console.Write("Congratulations you passed the class!");
        }
        else if (final_grade >= 60 && final_grade < 70)
        {
            letter = "D";
            //Console.Write("Your grade is D");
            //Console.Write("Study some more and try again!");
        }
        else
        {
            letter = "F";
            //Console.Write("Your grade is F");
            //Console.Write("Study some more and try again!");
        }
        Console.WriteLine($"Your final grade is {letter}.");
        
        if (final_grade >= 70)
        {
            Console.WriteLine("You passed, Congrats!");
        }
        else
        {
            Console.WriteLine("Try again next time.");
        }


    }
}