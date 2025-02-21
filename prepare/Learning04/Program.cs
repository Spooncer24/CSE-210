using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1 = new Assignment();
        student1.SetStudentName("jon");
        student1.SetTopic("english");

        Console.WriteLine(student1.GetSummery());

        MathAssignment a2 = new MathAssignment("Timmy Turner", "Math", "7.3", "8-19");
        Console.WriteLine(a2.GetSummery());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Walter White", "Chemistry", "Cooking with chemicals");
        Console.WriteLine(a3.GetSummery());
        Console.WriteLine(a3.GetWritingInformation());


    }
}