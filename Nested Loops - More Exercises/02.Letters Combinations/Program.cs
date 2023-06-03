using System;
namespace _02.Letters_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            char inputFirst = char.Parse(first);
            
            string lastLetter = Console.ReadLine();
            char inputLastLetter = char.Parse(lastLetter); 
            
            string miss = Console.ReadLine();
            


            String result = "";

            for (int i = inputFirst; i <= inputLastLetter; i++)
            {
                
                for (int j = inputFirst; j <= inputLastLetter; j++)
                {
                   
                    for (int k = inputFirst; k <= inputLastLetter; k++)
                    {
                   
                    }

                    
                } 
               
            }

        }
    }
}