using System;
using System.Diagnostics;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String word = Console.ReadLine();

            while(word != "Stop") { 
            
            Console.WriteLine(word);
                
            word = Console.ReadLine();
            }
        }
    }
}