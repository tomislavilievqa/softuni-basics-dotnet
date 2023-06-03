
using System;
namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int coinsCounter = 0;
            double totalsum = sum * 100;
            while(totalsum > 0.1)
            {
                if (totalsum >= 200)
                {
                    coinsCounter++;
                    totalsum -= 200;
                }
                else if (totalsum >= 100)
                {
                    coinsCounter++;
                    totalsum -= 100;
                }
                else if (totalsum >= 50)
                {
                    coinsCounter++;
                    totalsum -= 50;
                }
                else if (totalsum >= 20)
                {
                    coinsCounter++;
                    totalsum -= 20;
                }
                else if (totalsum >= 10)
                {
                    coinsCounter++;
                    totalsum -= 10;
                }
                else if (totalsum >= 5)
                {
                    coinsCounter++;
                    totalsum -= 5;
                }
                else if (totalsum >= 2)
                {
                    coinsCounter++;
                    totalsum -= 2;
                }
                else
                {
                    coinsCounter++;
                    totalsum -= 1;

                }
            }
            Console.WriteLine(coinsCounter);
            
        }
    }
}