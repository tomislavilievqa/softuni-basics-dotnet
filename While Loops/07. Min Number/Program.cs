using System;
namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String command = Console.ReadLine();
            int minNum = int.MaxValue;

            while (command != "Stop")
            {
                int number = int.Parse(command);

                if (number < minNum)
                {
                    minNum = number;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}