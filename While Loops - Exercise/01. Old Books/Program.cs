using System;
namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String searchedBook = Console.ReadLine();
            //string foundBook = "";
            int countOfBooks = 0;
            
            while (true)
            {
                String foundBook = Console.ReadLine();
                if (searchedBook == foundBook)
                {
                    Console.WriteLine($"You checked {countOfBooks} books and found it.");
                    break;
                }
                if(foundBook == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!\nYou checked {countOfBooks} books.");
                    break;
                }

                countOfBooks++;

            }
           
        }
    }
}