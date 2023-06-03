using System;

namespace _10.MetricConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            String input = (Console.ReadLine());
            String output = (Console.ReadLine());
            double newNum = 0.0;
            if (input == "mm" & output == "cm")
            {
                newNum = num / 10;
            }
            else if (input == "mm" & output == "m")
            {
                newNum = num / 1000;
            }
            else if (input == "cm" & output == "mm")
            {
                newNum = num * 10;
            }
            else if (input == "cm" & output == "m")
            {
                newNum = num / 100;
            }
            else if (input == "m" & output == "cm")
            {
                newNum = num * 100;
            } else
            {
                newNum = num * 1000;
            }

            Console.WriteLine("{0:F3}",newNum);
        }
    }
}
