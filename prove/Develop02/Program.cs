using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Journal journal = new Journal();

        //Declaring Boolean for use later
        bool done = false;
        bool askFile = false;

        //Making a empty string for file name
        string fileName = ("NONE");

        // Display menu and get input from user.
        while (!done)
        {
            menu.Display();

            //Getting Menu choice from user.
            Console.Write("What would you like to do? ");
            int choice = Convert.ToInt32(Console.ReadLine());

            //Iterating through each choic.
            if (choice == 1)  //Write Entry
            {
                journal.Write();

            }else if (choice == 2)  //Display Journal
            {
                journal.Display(fileName, askFile);

            }else if (choice == 3)  //Load Journal
            {
                // Make askFile bool true
                 askFile = true;

                //call the Journal Load.
                fileName = journal.Load();

            }else if (choice == 4)  //Save Journal
            {
                //call the Journal Save.
                fileName = journal.Save(fileName, askFile);

                //Make bool askFile true after saving it will be true
                askFile = true;

            }else  //Quit
            {
                done = true;
            }
        }
    }
}