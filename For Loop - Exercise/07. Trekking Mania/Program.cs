using System;
namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int countOfGroups = int.Parse(Console.ReadLine());
            int total = 0;
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;


            for (int i = 1; i <= countOfGroups; i++)
            {
                int countOfPeopleInGroup = int.Parse(Console.ReadLine());
                total += countOfPeopleInGroup;


                if (countOfPeopleInGroup <= 5)
                {
                    p1 += countOfPeopleInGroup;
                }else if (countOfPeopleInGroup >= 6 && countOfPeopleInGroup <= 12)
                {

                    p2 += countOfPeopleInGroup;
                }else if(countOfPeopleInGroup >= 13 && countOfPeopleInGroup <= 25) {
                
                    p3 += countOfPeopleInGroup;
                }else if(countOfPeopleInGroup >= 26 && countOfPeopleInGroup <= 40)
                {
                    p4 += countOfPeopleInGroup;

                } else
                {
                    p5 += countOfPeopleInGroup;
                }
            }

            double musala = (p1 * 1.0) / total * 100;
            double monblan = (p2 * 1.0) / total * 100;
            double kilimangaro = (p3 * 1.0) / total * 100;
            double k2 = (p4 * 1.0) / total * 100;
            double everest = (p5 * 1.0) / total * 100;

            Console.WriteLine("{0:F2}%",musala);
            Console.WriteLine("{0:F2}%", monblan);
            Console.WriteLine("{0:F2}%", kilimangaro);
            Console.WriteLine("{0:F2}%", k2);
            Console.WriteLine("{0:F2}%", everest);
        }
    }
}