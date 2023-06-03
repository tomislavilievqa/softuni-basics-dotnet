using System;
using System.Xml.Schema;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1.широчина на свободното пространство - цяло число в интервала [1...1000]
            ////2.дължина на свободното пространство - цяло число в интервала[1...1000]
            ////3.височина на свободното пространство - цяло число в интервала[1...1000]
            //4.на следващите редове(до получаване на команда "done") -брой кашони, които се пренасят в квартирата - цяло число в интервала[1...10000]
            //програмата трябва да приключи прочитането на данни при команда "done" или ако свободното място свърши.

            int widthOfFreeSpace = int.Parse(Console.ReadLine());
            int lengthOfFreeSpace = int.Parse(Console.ReadLine());
            int heightOfFreeSpace = int.Parse(Console.ReadLine());

            int totalFreeSpace = widthOfFreeSpace * lengthOfFreeSpace * heightOfFreeSpace;
            int totalBoxesDimension = 0;
            bool notEnoughSpace = false;
            while (totalFreeSpace > totalBoxesDimension)
            {
                String command = Console.ReadLine();

                if (command != "Done")
                {
                    int boxesDimensions = int.Parse(command);
                    totalBoxesDimension = totalBoxesDimension + boxesDimensions;
                } else if (command == "Done" && totalFreeSpace < totalBoxesDimension)
                {
                    notEnoughSpace = true;
                    break;
                } else if (command == "Done" && totalFreeSpace == totalBoxesDimension)
                {
                    Console.WriteLine("{0} Cubic meters left.", totalFreeSpace - totalBoxesDimension);
                    break;
                }
                else if (command == "Done")
                {
                    Console.WriteLine("{0} Cubic meters left.", totalFreeSpace - totalBoxesDimension);
                    break;
                }


            }
            if (notEnoughSpace)
            {
                Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(totalBoxesDimension - totalFreeSpace));
            } else if (totalFreeSpace < totalBoxesDimension)
            {
                Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(totalBoxesDimension - totalFreeSpace));
            } else if (totalFreeSpace == totalBoxesDimension) {
                Console.WriteLine("{0} Cubic meters left.", totalFreeSpace - totalBoxesDimension);
            }

           
        }
    }
}