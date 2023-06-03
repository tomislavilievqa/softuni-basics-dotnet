using System;
namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //При настаняване всеки мъж и всяка жена получават талончета с поредни номера стартирайки от 1. 
            //Ако бъдат заети всички маси, програмата трябва да приключи. Всяка маса има две места.

            int countMen = int.Parse(Console.ReadLine());
            int countWomen = int.Parse(Console.ReadLine());
            int maxCountTabels = int.Parse(Console.ReadLine());
            bool isFull = false;
            int usedPlaces = 0;

                for (int i = 1; i <= countMen; i++)
                {
                    for (int j = 1; j <= countWomen; j++)
                    {
                    if (maxCountTabels > 0)
                    {
                        Console.Write("(" + i + " " + "<->" + " " + j + ")" + " "); 
                    }
                    maxCountTabels--;
                    }
                }

            }

        }
    }
