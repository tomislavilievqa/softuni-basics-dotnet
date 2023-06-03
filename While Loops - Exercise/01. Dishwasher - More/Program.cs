using System;
using System.Data;

namespace _01._Dishwasher___More
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countBottles = int.Parse(Console.ReadLine());
            int availableLitres = countBottles * 750;
            int loadingCounter = 1;
            int countPots = 0;
            int countDishes = 0;

         //  От конзолата се четат:
          //•	Брой бутилки от препарат, който ще бъде използван за миенето на чинии - цяло число в интервала[1…10]
         //На всеки следващ ред, до получаване на командата "End" или докато количеството препарат не се изчерпи, брой съдове, които трябва да бъдат измити -цяло число в интервала[1…100]


            while (availableLitres >= 0)
            {
                String command = Console.ReadLine();
                

                if(command != "End")
                {
                    if (loadingCounter % 3 == 0)
                    {
                        int amountPots = int.Parse(command);
                        availableLitres = availableLitres - (amountPots * 15);
                        countPots += amountPots;
                    }
                    else
                    {
                        int amountDishes = int.Parse(command);
                        availableLitres = availableLitres - (amountDishes * 5);
                        countDishes += amountDishes;
                    }
                }
                if(command == "End" && availableLitres < 0)
                {
                    Console.WriteLine("Not enough detergent, {0} ml. more necessary!", Math.Abs(availableLitres));
                    break;
                } else if (command == "End")
                {
                    Console.WriteLine("Detergent was enough!\n{0} dishes and {1} pots were washed.\nLeftover detergent {2} ml.", countDishes, countPots,availableLitres);
                    break;
                }
                loadingCounter++;

            }
            if (availableLitres < 0)
            {
                Console.WriteLine("Not enough detergent, {0} ml. more necessary!", Math.Abs(availableLitres));
            }
        }
    }
}