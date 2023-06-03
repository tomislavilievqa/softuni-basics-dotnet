using System;
namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            double gradeScore = double.Parse(Console.ReadLine());
            int grade = 0;
            double gradeTotal = 0;
            int excluded = 0;
            while (true)
            {
                
                gradeTotal += gradeScore;
                

                if (gradeScore < 4.00)
                {
                    excluded++; 
                } 
                if(excluded == 2)
                {
                    Console.WriteLine("{0} has been excluded at {1} grade",input, grade);
                    break;
                }
                
                grade++;

                if (grade == 12)
                {
                    Console.WriteLine("{0} graduated. Average grade: {1:f2}",input, gradeTotal / grade);
                    break;
                }
                
                gradeScore = double.Parse(Console.ReadLine());
            }

            
        }
    }
}