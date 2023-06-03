using System;

namespace _11.NewWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Рекордът в секунди – реално число в интервала [0.00 … 100000.00]
            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]



            double recentRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeFor1m = double.Parse(Console.ReadLine());

            double time = distance * timeFor1m; //+ ((distance / 15) * 12.5);
            double timePlus = Math.Floor(distance / 15);
            timePlus = timePlus * 12.5;
            double totalTime = time + timePlus;
            if ( totalTime < recentRecord)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", totalTime);
            } else
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", Math.Abs(recentRecord - totalTime));
            }
            




        }
    }
}
