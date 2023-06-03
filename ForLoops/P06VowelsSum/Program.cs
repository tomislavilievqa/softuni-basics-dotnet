using System;
namespace P06VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String text = Console.ReadLine();
            int length = text.Length;
            int number = 0;

            for (int i = 0; i < length;i++) {
                
                char c = text[i];

                if (c == 'a') {
                    number = number + 1;
                } else if(c == 'e')
                {
                    number = number + 2;
                }
                else if (c == 'i')
                {
                    number = number + 3;
                }
                else if (c == 'o')
                {
                    number = number + 4;
                }
                else if (c == 'u')
                {
                    number = number + 5;
                } else
                {
                    number = number + 0;
                }
            }
            Console.WriteLine(number);
        }
    }
}