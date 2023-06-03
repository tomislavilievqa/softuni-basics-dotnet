using System;

namespace _05.Aritmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double inches = 2.54;
            double result = num * inches;

            Console.WriteLine(result);
        }
    }
}
