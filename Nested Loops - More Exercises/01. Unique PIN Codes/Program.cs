using System;


namespace _01._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstBoundary = int.Parse(Console.ReadLine());
            int secondBoundary = int.Parse(Console.ReadLine());
            int thirdoundary = int.Parse(Console.ReadLine());
            //•	Първата и третата цифра трябва да бъдат четни.
            //•	Втората цифра трябва да бъде просто число в диапазона[2...7].


            for (int i = 1; i <= firstBoundary; i++)
            {

                for (int j = 1; j <= secondBoundary; j++)
                {
                    for (int k = 1; k <= thirdoundary; k++)
                    {
                        if (i % 2 == 0 && k % 2 == 0)
                        {
                            if(j == 2 || j == 3 || j == 5 || j == 7)
                            {
                                Console.WriteLine(i + " " + j + " " + k + " ");
                                
                            }
                            

                        }

                   
                    }
                }

            }


        }

    }
}

