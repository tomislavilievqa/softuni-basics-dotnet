using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //всички възможни комбинации от двойка числа в интервала от две дадени числа. 
            //На изхода се отпечатва, коя поред е комбинацията чиито сбор от числата е равен на дадено магическо число. 

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            bool isTheRightCombination = false;
            int counter = 0;
            int firstNum = 0;
            int secondNum = 0;
         
            for (firstNum = start; firstNum <= end; firstNum++)
            {
                for (secondNum = start; secondNum <= end; secondNum++)
                {
                    int sum = firstNum+ secondNum;
                    counter++;
                    if (sum == magicNum)
                    {
                        isTheRightCombination= true;
                        break;
                    }
                } if(isTheRightCombination)
                {
                    Console.WriteLine($"Combination N:{counter} ({firstNum} + {secondNum} = {magicNum})");
                    //Console.WriteLine($"({firstNum} + {secondNum} = {magicNum})");

                    break;
                } 
                
            }
            if(isTheRightCombination == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
           
        }
    }
}