using System;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedScore = int.Parse(Console.ReadLine());
            
            int failedTimes = 0;
            int solvedProblemsCount = 0;
            int sumScore = 0;
            string lastProblem = "";
            bool isHeFailed = true;

            while (failedTimes < failedScore)
            {
                String problemName = Console.ReadLine();
                if("Enough" == problemName)
                {
                    isHeFailed= false;
                    break;
                }
                
                int grade = int.Parse(Console.ReadLine());
               
                if (grade <= 4)
                {
                    failedTimes++;
                }
                sumScore+= grade;
                solvedProblemsCount++;
                lastProblem= problemName;

            }
            if(isHeFailed) {

                Console.WriteLine("Average score: ");
            }
            else
            {
                Console.WriteLine("Average score: ");
                Console.WriteLine("Number of problems: ");
                Console.WriteLine("Last problem: ");
            }

        
        }
    }
}