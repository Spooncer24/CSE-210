using System;

class Menu
{
    //Displays menu options when called
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine("1) Write a new entry.");
        Console.WriteLine("2) Display Journal.");
        Console.WriteLine("3) Load Journal.");
        Console.WriteLine("4) Save Journal.");
        Console.WriteLine("5) Quit.");
        Console.WriteLine();
    }
}