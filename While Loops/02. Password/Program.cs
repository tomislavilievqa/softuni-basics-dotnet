using System;
namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            string password = Console.ReadLine();
            String passwordInput = Console.ReadLine();

            while (password != passwordInput)
            {
                

                passwordInput = Console.ReadLine();
            }
            Console.WriteLine("Welcome {0}!", name);

        }
    }
}