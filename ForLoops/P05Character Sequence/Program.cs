using System;
namespace P05Character_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String text = Console.ReadLine();
            int length = text.Length;

            for (int i = 0; i < length; i++)
            {
                char c = text[i];
                Console.WriteLine(c);
            }

            
        }
    }
}