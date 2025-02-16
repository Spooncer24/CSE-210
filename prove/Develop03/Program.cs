using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;

        //get scripture user wants
        Console.Write("What scripture are you memorizing? ");
        string _scripture = Console.ReadLine() + ";";

        //get scripture verses
        Console.Write("Copy and paste the verse/s you want to memorize (make sure to paste as one line): ");
        string scripture_verse = Console.ReadLine();

        // If user input is just white space it will go to defualt scripture
        Scripture scripture;
        if (string.IsNullOrWhiteSpace(_scripture) || string.IsNullOrWhiteSpace(scripture_verse))
        {
            scripture = new Scripture(); // Use default constructor
        }
        else
        {
            scripture = new Scripture(_scripture, scripture_verse);
        }

        // While loop that continues until done is equal to true.
        while (!done)
        {
            Console.Clear();
            scripture.Display();
            
            //get user input to see if they want to quit
            Console.WriteLine("\n");
            Console.Write("Press ENTER to continue or type Quit to finish: ");
            string input = Console.ReadLine();

            done = scripture.GetDone();

            if (input.ToLower() == "quit")
            {
                done = true;
            }

        }

        Console.Clear();

    }
}