using System;
namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int additionalPoints = 0;
            int wins = 0;
            for (int i = 1; i <= countTournaments; i++)
            {
                String stage = Console.ReadLine();

                if(stage == "W")
                {
                    additionalPoints += 2000;
                    wins++;
                }else if (stage == "F")
                {
                    additionalPoints += 1200;
                }
                else
                {
                    additionalPoints += 720;
                }
            }

            int averagePoints = additionalPoints / countTournaments;
            double winnedTournaments = (wins * 1.0) / countTournaments * 100;

            Console.WriteLine("Final points: {0}\nAverage points: {1}\n{2:F2}%",additionalPoints + startPoints, averagePoints, winnedTournaments );
        }
    }
}