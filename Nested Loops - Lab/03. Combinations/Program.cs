using System;
namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Напишете програма, която изчислява колко решения в естествените числа (включително и нулата) има уравнението:
            //            x1 + x2 + x3 = n
            //Числото n е цяло число и се въвежда от конзолата. 
            
            
            int n = int.Parse(Console.ReadLine());
            bool isCorrectNum = false;
            int counter = 0;    
            for (int firstNum = 0; firstNum <= n; firstNum++)
            {

                for (int secondNum = 0; secondNum <= n; secondNum++)
                {
                    
                    for (int thirdNum = 0; thirdNum <= n; thirdNum++)
                    {
                        int total = firstNum + secondNum + thirdNum;
                        
                        if (total==n)
                        {
                           counter++;
                            isCorrectNum = true;
                        }

                    }
                }
            }
            Console.WriteLine(counter);
        }   
    }
}