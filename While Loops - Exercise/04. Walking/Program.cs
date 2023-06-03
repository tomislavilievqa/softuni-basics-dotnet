using System;
namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int targetStepsForADay = 10000;
            int stepsCount = 0;
            bool goingHome = false;

            while (stepsCount < targetStepsForADay)
            {
                String input = Console.ReadLine();

                //stepsCount += input;

                if (input == "Going home") {
                    int lastSteps = int.Parse(Console.ReadLine());
                    stepsCount += lastSteps;
                    //goingHome = true;
                    break;
                }
                else
                {
                    int inputSteps = int.Parse(input);
                    stepsCount += inputSteps;
                }

            }
            if (stepsCount >= targetStepsForADay)
            {
                Console.WriteLine("Goal reached! Good job!\n{0} steps over the goal!\r", stepsCount - targetStepsForADay);

            } else
            {
                Console.WriteLine("{0} more steps to reach goal.", targetStepsForADay - stepsCount);
            }
        }

        }
    }
