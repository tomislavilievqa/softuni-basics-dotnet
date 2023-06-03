using System;

namespace _04._Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {

                for (int j = 0; j < row + 1; j++)
                {
                    string result = "$ ";

                    Console.Write(result);
                }
                Console.WriteLine();
            }
        }
    }
}
