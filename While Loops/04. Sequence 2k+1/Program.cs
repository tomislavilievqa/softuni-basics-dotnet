﻿using System;
namespace _04._Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            int k1 = 0;
            while (n >= k)
            {
                
                Console.WriteLine(k);
                k = k * 2 + 1;
            }

            
        }
    }
}