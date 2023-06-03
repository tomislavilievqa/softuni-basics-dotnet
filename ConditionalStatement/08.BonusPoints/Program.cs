using System;

namespace _08.BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonuspoints = 0.0;
            if (num <= 100)
            {
                bonuspoints = 5;
                
            } else if ( num > 1000 ) {
                bonuspoints =  num * 0.1;

            } else
            {
                bonuspoints = num * 0.2;
            }

            if (num % 2 == 0)
            {

               bonuspoints += 1;
            } if (num % 10 == 5)
            {
                bonuspoints += 2;
            }

            Console.WriteLine(bonuspoints);
            Console.WriteLine(bonuspoints+num);

        }
    }
}
