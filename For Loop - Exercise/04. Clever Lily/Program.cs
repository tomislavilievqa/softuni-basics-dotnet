using System;
namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int dollsPrice = int.Parse(Console.ReadLine());
            
            int moneyFromDolls = 0;
            int evenYears = 0;
            int savedMoney = 0;
            int countToys = 0;


            for (int i = 1; i <= years; i++) {

                
                if (i % 2 == 0)
                {
                    evenYears += 10;
                    savedMoney += evenYears - 1;
                }
                else
                {
                    countToys ++;
                }
                


            }
            double totalSum = (countToys * dollsPrice) + savedMoney;
            
            if (totalSum >= washingMachine)
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                double needMoney = washingMachine - totalSum;
                Console.WriteLine("No");
            }

            
        }
    }
}