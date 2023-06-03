using System;
namespace P10Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if(i % 2 == 0)
                {
                    evenSum += currentNum;
                }else
                {
                    oddSum+= currentNum;
                }

            }

            if(oddSum == evenSum) {
                Console.WriteLine("Yes\nSum = {0}",evenSum);
            }else
            {
                Console.WriteLine("No\nDiff = {0}",Math.Abs(evenSum-oddSum));
            }

        }
    }
}