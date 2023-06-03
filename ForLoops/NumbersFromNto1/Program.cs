using System;
namespace NumbersFromNto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; 1 <= i; i--)
            {
                Console.WriteLine(i);  
            }
        }
    }
}