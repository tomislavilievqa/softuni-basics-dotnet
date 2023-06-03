using System;
namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());  
            int salary = int.Parse(Console.ReadLine());
            int alimony = 0;
            for (int i = 1; i <= n; i++)
            {
                String website = Console.ReadLine();

                switch(website)
                {
                    case "Facebook":
                        alimony = alimony + 150;
                        break;
                    case "Instagram":
                        alimony = alimony + 100;
                        break;
                    case "Reddit":
                        alimony = alimony + 50;
                        break;
                    default:
                        alimony += 0;
                        break;
                }
                

            }
            int lefts = salary - alimony;

            if (lefts <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(lefts);
            }
        }
    }
}