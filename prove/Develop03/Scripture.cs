using System;
using System.Runtime.InteropServices.Marshalling;

class Scripture
{   
    Verse verse = new Verse();

        //varibal to see if this is first time scripture is being ran through if so it won't hid words
        int count_runs = 0;

    //Private vaiables only this class can access
    private string _scripture;

    private List<string> _verse = new List<string>();

    //set defualt scripture if nothing is given
    public Scripture()
    {
        _scripture = "Proverbs 3:5-6";
        _verse = new List<string> {"Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine","own", "understanding;", "In", "all", "thy", "ways", "acknowledge", "him,", "and", "he", "shall", "direct", "thy", "paths."};

        //Call verse to make a list of bools
        verse.VerseToBool(_verse);
    }

    public Scripture(string scripture, string scripture_verse)
    {
        _scripture = scripture;
        _verse = verse.MakeVerseString(scripture_verse);

        // call verse to make list of bools and to hold it
        verse.VerseToBool(_verse);
    }

    //Display scripter list into console using for loop to make it readable.
    public void Display()
    {
        Console.Write($"{_scripture} ");
        int _count = 0;
    
        //Run program after the first time to start hiding words
        if (count_runs > 0)
        {
            _verse = verse.HideWords(_verse);
        }
        count_runs ++;

        //Print scripture in readable format
        foreach (string word in _verse)
        {
            Console.Write($"{word} ");
            _count ++;
            if (_count == 10)
            {
                Console.WriteLine();
                _count = 0;
            }
        }
    }

    public bool GetDone()
    {
        bool done = verse.GetDone();

        return done;
    }

}