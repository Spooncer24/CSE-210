using System;
using System.IO;
using System.IO.Enumeration;


class Journal
{
    Prompt_Manager prompt = new Prompt_Manager();
    List<string> entryList = new List<string>();

    //Get the date and turn it into a string
    DateTime currentTime = DateTime.Now;

    //Get entry from user and store into a string with the date and prompt
    public void Write()
    {
        //Call the prompt_manager and get a prompt then have user write in their entry
        string usePrompt = prompt.GetPrompt();
        Console.Write("> ");
        string journalEntry = Console.ReadLine();

        //Convert Date into a short string
        string dateText = currentTime.ToShortDateString();

        //Save Date, prompt, and Entry to list
        entryList.Add($"Date: {dateText} - {usePrompt}: {journalEntry}");
    }

    public string Save(string fileName, bool askFile)
    {
        //If bool is false then the if statement will get the name of the file 
        if (!askFile)
        {
            Console.WriteLine("What is the file Name? ");
            fileName = Console.ReadLine();
        }

        // Write entries in entry list to file
        using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
        {
            foreach (string entry in entryList)
            {
                outputFile.WriteLine(entry);
            }

            //Clear entry list
            entryList.Clear();
        }

        Console.WriteLine("File save successfully");

        return fileName;
    }

    public string Load()
    {
        //Get the file the user wants to load from
        Console.WriteLine();
        Console.Write("What File would you like to load? ");
        string fileName = Console.ReadLine();

        //Clear entries when loading
        entryList.Clear();

        return fileName;
    }

    public void Display(string fileName, bool askFile)
    {
        //If no file has been loaded yet will only display entrys in string
        if (askFile)
        {
            //Get the file into a string
            string[] readFile = File.ReadAllLines(fileName);

            //Display each line in the file
            foreach (string line in readFile)
            {
                Console.WriteLine();
                Console.WriteLine(line);
            }


        }

        //Show each entry that has not been saved yet
        foreach (string entry in entryList)
            {
                Console.WriteLine();
                Console.WriteLine(entry);
            }
    }
}