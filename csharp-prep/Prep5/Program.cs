using System;

class Program
{
    static void Main(string[] args)
    {
        display_welcome_message();
        string user_name = prompt_user_name();
        int favorite_number = prompt_user_number();
        int squared_number = squar_number(favorite_number);
        display_results(user_name, squared_number);
    }

    //Display message
    static void display_welcome_message()
    {
        Console.WriteLine("Welcom to the program.");
    }

    //Gets Name from user
    static string prompt_user_name()
    {
        Console.Write("What is your name? ");
        string user_name = Console.ReadLine();

        return user_name;
    }

    //Gets favorite number from user
    static int prompt_user_number()
    {
        Console.Write("What is your favorite number? ");
        int user_number = Convert.ToInt32(Console.ReadLine());

        return user_number;
    }

    //Squares users favorite number
    static int squar_number(int number)
    {
        int square = number * number; 

        return square;
    }

    static void display_results(string name, int squared_number)
    {
        Console.WriteLine($"{name}, your number squared is {squared_number}");
    }
}