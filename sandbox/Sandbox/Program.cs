using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    static void Main()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);
        int _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter anything for 10 seconds ");
            Console.ReadLine();
            
            _count ++;
        }
        Console.WriteLine(_count);
    }
 
}