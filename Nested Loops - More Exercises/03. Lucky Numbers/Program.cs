using System;
namespace _03._Lucky_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Щастливо число е 4-цифрено число, на което сбора от първите две цифри е равен на сбора от последните две. 
            int n = int.Parse(Console.ReadLine());
            
            int currentNum = 0;
            int counter = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                
                int lastDigit = 0;
                currentNum = i;
                int firstNumbersSum = 0;
                int secondNumbersSum = 0;
                int firstNumber = 0;
                int secondNumber = 0;
                int thirdNumber = 0;
                int forthNumber = 0;

                for (int j = 1; j <= 4; j++)
                {
                    
                    lastDigit = currentNum % 10;
                    if(j <= 2)
                    {
                        secondNumbersSum += lastDigit;
                        if (j == 1)
                        {
                            firstNumber += lastDigit;
                        }
                        else if (j == 2)
                        {
                            secondNumber += lastDigit;
                        }
                    }
                    else
                    {
                        firstNumbersSum += lastDigit;
                        if (j == 3)
                        {
                            thirdNumber+= lastDigit;
                        }
                        else if (j == 4)
                        {
                            forthNumber+= lastDigit;
                        }
                    }
                    currentNum = currentNum / 10;
                }
                if (firstNumber != 0 && secondNumber != 0 && thirdNumber != 0 && forthNumber != 0)
                {
                    if (firstNumber != n && secondNumber != n && thirdNumber != n && forthNumber != n)
                    {
                        if (firstNumbersSum == secondNumbersSum && n % firstNumbersSum == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
             
                


            }
        }
    }

}