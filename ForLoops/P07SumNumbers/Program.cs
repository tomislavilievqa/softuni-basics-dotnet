using System;
namespace P07SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numIterations = int.Parse(Console.ReadLine());
            
            
            int finalNum = 0;

            for (int i = 1; i <= numIterations; i++)
            {
                
               int n = int.Parse(Console.ReadLine());
                finalNum = finalNum + n;

            }
            
            Console.WriteLine(finalNum);
        }
    }
}