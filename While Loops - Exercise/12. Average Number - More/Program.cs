using System;
using System.Runtime.InteropServices;

namespace _12._Average_Number___More
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            double sumOfNumbers = 0;
            int countNumbers = 0;
            
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumOfNumbers += number;
                countNumbers++;

            }
            Console.WriteLine("{0:F2}",sumOfNumbers/countNumbers);
        }
    }
}