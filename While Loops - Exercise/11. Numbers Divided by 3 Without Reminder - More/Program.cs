using System;
namespace _11._Numbers_Divided_by_3_Without_Reminder___More
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            bool withoutRemainder = false;

            while (num <= 100)
            {
                num++;
                if (num % 3 == 0)
                {
                    withoutRemainder = true;

                    if (withoutRemainder)
                    {

                        Console.WriteLine(num);
                    }
                }
                else

                {
                    withoutRemainder = false;
                    continue;
                }



            }
        }
    }
}

