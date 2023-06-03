using System;
namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            
            int maxNum = int.MinValue;
            int sumOfAll = 0;


            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sumOfAll += currentNum;
                
                if (maxNum < currentNum)
                {
                    maxNum = currentNum;
                }


            }
            
            int leftNum = sumOfAll - maxNum;
            if (leftNum == maxNum)
            {
                Console.WriteLine("Yes\nSum = {0}", maxNum);
            } else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(maxNum-leftNum));
            }
            
        }
    }
}