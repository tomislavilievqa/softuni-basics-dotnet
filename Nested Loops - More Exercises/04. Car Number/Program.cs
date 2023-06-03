using System;
namespace _04._Car_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int firstNum = int.Parse(Console.ReadLine());
           int secondNum = int.Parse(Console.ReadLine());
            //•	Ако номерът започва с четна цифра, то той трябва да завършва на нечетна цифра и обратното – ако започва с нечетна, завършва на четна
           //•	Първата цифра от номера е по-голяма от последната
           //• Сумата от втората и третата цифра трябва да е четно число


            for (int i = firstNum; i <= secondNum; i++)
            {
                string currentDigit1 = i.ToString();
                
                for (int j = firstNum; j <= secondNum; j++)
                {   
                    string currentDigit2 = j.ToString();
                   
                    for (int k = firstNum; k <= secondNum; k++)
                    {
                        string currentDigit3 = k.ToString();  
                        
                        for (int p = firstNum; p <= secondNum; p++)
                        {
                            string currentDigit4 = p.ToString();
                            
                            string total = currentDigit1 + currentDigit2 + currentDigit3 + currentDigit4;
                            int currentNum = int.Parse(total);
                            int currentDigit = 0;
                            
                            int firstDigit = 0;
                            int secondDigit = 0;
                            int thirdDigit = 0;
                            int fourthDigit = 0;
                            for (int g = 1; g <= 4; g++)
                            {
                                currentDigit = currentNum % 10;

                                if (g == 1) 
                                {
                                    
                                    fourthDigit += currentDigit;

                                } else if(g == 2){

                                    thirdDigit += currentDigit;

                                } else if (g == 3){
                                   
                                    
                                    secondDigit += currentDigit;

                                } else if (g == 4){

                                    firstDigit += currentDigit;
                                }
                                currentNum = currentNum / 10;   
                            }
                            if (firstDigit % 2 == 0 && fourthDigit % 2 != 0)
                            {
                                if(firstDigit > fourthDigit && (secondDigit + thirdDigit) % 2 == 0) {
                                    Console.Write(total + " ");
                                }
                            } else if (firstDigit % 2 != 0 && fourthDigit % 2 == 0)
                            {
                                if(firstDigit > fourthDigit && (secondDigit + thirdDigit) % 2 == 0)
                                {
                                    Console.Write(total + " ");
                                }
                            }                            
                            
                        }
                    }
                }

            }

        }
    }
}