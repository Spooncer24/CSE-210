using System;

class Prompt_Manager
{
    public string GetPrompt()
    {   
        //Making a list of prompts
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion I felt today?", 
            "If I had one thing I could do over today, what would it be?",
            "What was a challenge I faced today? How did I overcome it?",
            "How did I show kindness today?",
            "What was the highlight of my day?",
            "What is something I learned today that I didnt know before?", 
            "What did I do to take care of myself today?",
            "Was there Any suprises in my day?"
        };

        //Chosing one prompt at Random
        Random random = new Random();

        int randomIndex = random.Next(prompts.Count);
        string randomPrompt = prompts[randomIndex];

        //Display Random Prompt
        Console.WriteLine();
        Console.WriteLine(randomPrompt);

        //Return prompt so it can be save later
        return randomPrompt;
    }
}