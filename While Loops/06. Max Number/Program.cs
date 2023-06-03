using System;
namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String command = Console.ReadLine();
            int maxNum = int.MinValue;

            while (command != "Stop")
            {
                int number = int.Parse(command);

                if (number > maxNum)
                {
                    maxNum = number;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(maxNum);


        }
    }
}