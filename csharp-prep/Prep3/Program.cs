using System;

class Program
{
    static void Main(string[] args)

    {
        // Used to ask user for magic number
        //Console.Write("What is the magic number? ");
        //int magic_number = Convert.ToInt32(Console.ReadLine());

        //Random generator to generat a number
        Random random_generator = new Random();
        int magic_number = random_generator.Next(1,101);

        //Declaring variables that determine winner and total guesses made
        string winner = "no";
        int total_guesses = 0;

        //While loop that repeats until correct guess is made
        while (winner == "no")
        {
            Console.Write("What is your guess? ");
            int user_guess = Convert.ToInt32(Console.ReadLine());

            total_guesses++;

            //If, else if, and else statement that check guess to magic number
            if (user_guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (user_guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed the number. You Made {total_guesses} guesses");
                winner = "yes";
            }
        }
    }
}