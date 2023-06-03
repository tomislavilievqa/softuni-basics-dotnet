﻿using System;
namespace _05._Travelling
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String destination = Console.ReadLine();
            
            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                
                while(budget > savedMoney)
                {
                    savedMoney += double.Parse(Console.ReadLine());
                }
                
                Console.WriteLine($"Going to {destination}!");
                
                destination = Console.ReadLine();

            }
             
        }
    }
}