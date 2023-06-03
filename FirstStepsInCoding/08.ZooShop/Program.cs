using System;

namespace _08.ZooShop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dogsCount = int.Parse(Console.ReadLine());
            int theRestAnimals = int.Parse(Console.ReadLine());
            double DogsFood = 2.50 * dogsCount;
            double neighborsAnimals = 4.00 * theRestAnimals;
            double finalPrice = DogsFood + neighborsAnimals;


            Console.WriteLine($"{finalPrice} lv.");
        }
    }
}
