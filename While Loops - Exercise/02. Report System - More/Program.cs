using System;
namespace _02._Report_System___More
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. плащане в брой а 2. плащане с карта
            //•	Ако продуктът надвишава 100лв., за него не може да се плати в брой
            //•	Ако продуктът е на цена под 10лв., за него не може да се плати с кредитна карта
            //Програмата приключва или след като получим команда "End" или след като средствата бъдат събрани.

            int expectedSum = int.Parse(Console.ReadLine());
            int typeOfPaying = 1;
            double sum = 0;
            double withCard = 0;
            double inCash = 0;
            
            while (sum < expectedSum)
            {
                String command = Console.ReadLine();

                if (command != "End")
                {
                    double priceOfItem = double.Parse(command);
                    if (typeOfPaying % 2 == 1 && priceOfItem > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                       
                    }
                    else if (typeOfPaying % 2 == 0 && priceOfItem < 10)
                    {
                        Console.WriteLine("Error in transaction!");
  
                    }
                    else if (typeOfPaying % 2 == 1 && priceOfItem <= 100)
                    {
                        Console.WriteLine("Product sold!");
                        sum += priceOfItem;
                        if (typeOfPaying % 2 == 0)
                        {
                            withCard += priceOfItem;
                        }
                        else if (typeOfPaying % 2 == 1)
                        {
                            inCash += priceOfItem;
                        }
                    }
                    else if (typeOfPaying % 2 == 0 && priceOfItem >= 10)
                    {
                        Console.WriteLine("Product sold!");
                        sum += priceOfItem;
                        
                        if (typeOfPaying % 2 == 0)
                        {
                            withCard += priceOfItem;
                        }
                        else if (typeOfPaying % 2 == 1)
                        {
                            inCash += priceOfItem;
                        }

                    }

                } else if (command == "End" && sum < expectedSum)
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;

                } else if (command == "End" && sum >= expectedSum)
                {
                    Console.WriteLine("Average CS: {0:F2}\nAverage CC: {1:F2}", inCash / 2, withCard / 2);
                    break;
                }

                typeOfPaying++;
            } if (sum >= expectedSum)
            {
                Console.WriteLine("Average CS: {0:F2}\nAverage CC: {1:F2}", inCash / 2, withCard / 2);
            }
        
        }
    }
}