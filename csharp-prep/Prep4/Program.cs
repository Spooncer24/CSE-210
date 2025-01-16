using System;

class Program
{
    static void Main(string[] args)
    {
        //Creating a list for numbers to go into
        List<int> numbers = new List<int>();
        int list_sum = 0;

        int input_number = 0;

        Console.WriteLine("Enter a list of numbers type 0 when done.");

        do
        {
            //gets number from user
            Console.Write("Enter number: ");
            string user_response = Console.ReadLine();
            input_number = int.Parse(user_response);

            //add user number to list
            if (input_number != 0)
            {
                numbers.Add(input_number);
            }

        } while (input_number != 0);
        
        //For each loop to add numbers
        foreach (int number in numbers)
        {
            list_sum += number;
        }

        //Gets the average of the list
        float list_average = ((float)list_sum) / numbers.Count;

        //Finds the Biggest number
        int max = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }


        Console.WriteLine($"The sum is: {list_sum}");
        Console.WriteLine($"The average is: {list_average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}