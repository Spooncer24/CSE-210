using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

class Verse
{   
    Word word = new Word();
    private List<bool> verse_bool = new List<bool>();
 
    public List<string> MakeVerseString(string input_verse)
    {   
        List<string> verse_list = new List<string>();

        //Get rid of numbers in verse. Made by chatGPT
        input_verse = Regex.Replace(input_verse, "\\d+\\s+", "");

        //Split verse white space into a list.
        verse_list = input_verse.Split(' ').ToList();

        return verse_list;
    }


    //create list of bools to tell if word is hidden or not
    public List<bool> VerseToBool(List<string> input_list)
    {
        foreach (string word in input_list)
        {
            verse_bool.Add(false);
        }

        return verse_bool;
    }

    public List<string> HideWords(List<string> verses)
    {
        //get list of bools that determine if word is hidden or not
        verse_bool = word.HidenWordsBools(verse_bool);

        //If word hidden bool is true then hide word using underscores
        for (int i = 0; i < verse_bool.Count; i++)
        {
            if (verse_bool[i] == true)
            {
                verses[i] = new string('_', verses[i].Length);
            }
        }

        return verses;
    }

    public bool GetDone()
    {
        bool done = word.CheckDone(verse_bool);

        return done;
    }
}