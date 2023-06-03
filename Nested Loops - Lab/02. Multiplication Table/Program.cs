using System;
namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Отпечатайте на конзолата таблицата за умножение за числата от 1 до 10 във формат: 
            //"{първи множител} * {втори множител} = {резултат}".


            int result = 0;
            
            for (int firstNUm = 1; firstNUm <= 10; firstNUm++)
            {
                for (int secondNum = 1; secondNum <= 10; secondNum++)
                {
                    Console.WriteLine("{0} * {1} = {2}",firstNUm,secondNum,firstNUm*secondNum);
                }
            }
        }
    }
}