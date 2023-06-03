using System;
namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialNum = int.Parse(Console.ReadLine());
            int sum = 0;
         
            
            while(sum < initialNum)
            {
                
                int newNumber = int.Parse(Console.ReadLine());
                sum += newNumber;
            }
            
            Console.WriteLine(sum);

        }
    }
}