using System;
namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;


            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    count1++;
                }else if (number >= 200 && number <= 399)
                {
                    count2++;
                }else if(number >= 400 && number <= 599)
                {
                    count3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    count4++;
                }
                else if (number >= 800)
                {
                    count5++;
                }

               
            }
            
           double p1 = 1.0 * count1 / n * 100;
           double p2 = 1.0 * count2 / n * 100;
           double p3 = 1.0 * count3 / n * 100;
           double p4 = 1.0 * count4 / n * 100;
           double p5 = 1.0 * count5 / n * 100;

            Console.WriteLine("{0:F2}%", p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);
            Console.WriteLine("{0:F2}%", p4);
            Console.WriteLine("{0:F2}%", p5);
        }
    }
}