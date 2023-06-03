using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.60;
            int TalkingDoll = 3;
            double BearDoll = 4.10;
            double Minion = 8.20;
            int TruckToy = 2;

            double TripPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int TalkingDollsCount = int.Parse(Console.ReadLine());
            int BearDollsCount = int.Parse(Console.ReadLine());
            int MinionsCount = int.Parse(Console.ReadLine());
            int TrucksCount = int.Parse(Console.ReadLine());
            double afterent = 0;

            double TotalOrderPrice = puzzleCount * puzzle + TalkingDoll * TalkingDollsCount + BearDoll * BearDollsCount + Minion * MinionsCount + TruckToy * TrucksCount;
            int totalCount = puzzleCount + TalkingDollsCount + BearDollsCount + MinionsCount + TrucksCount;

            if (totalCount >= 50)
            {

                TotalOrderPrice = TotalOrderPrice * 0.75;
                afterent = TotalOrderPrice * 0.10;
            }
            else if (totalCount < 50)
            {

                afterent = TotalOrderPrice * 0.10;
            }

            bool isBigger = afterent > TripPrice;
            if (isBigger)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", afterent - TripPrice);

            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", afterent - TripPrice);
            }


        }
    }
}




    


















