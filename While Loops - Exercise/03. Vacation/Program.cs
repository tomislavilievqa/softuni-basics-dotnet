using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double requiredMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            
        
            int days = 0;
            int streakSpending = 0;
            double totalMoney = ownedMoney;
            bool cantSaveMoney = false;

            while (totalMoney < requiredMoney)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;

                switch (command)
                {
                    case "save":
                        streakSpending = 0;
                        totalMoney += money;
                        break;
                   
                    case "spend":
                        streakSpending++;
                        totalMoney -= money;
                        break;           
                }
               
                if (streakSpending == 5) {
                    cantSaveMoney = true;
                    break;

                }if (totalMoney <= 0)
                {
                    totalMoney = 0;
                }
        
            }
            if (cantSaveMoney)
            {
                Console.WriteLine($"You can't save the money.\n{streakSpending}");
            } if (totalMoney >= requiredMoney) {
                Console.WriteLine($"You saved the money for {days} days.");
            }



        }
    }
}