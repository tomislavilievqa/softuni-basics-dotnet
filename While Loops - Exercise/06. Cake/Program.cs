using System;
namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int countOfSlices = length * width;
            bool notEnoughSlices = false;
            //bool stoppedProgram = false;
            
            while (countOfSlices > 0)
            {
                String command = Console.ReadLine();
                
                if (command == "STOP" && countOfSlices < 0)
                {
                    notEnoughSlices = true;
                    break;
                }else if(command == "STOP")
                {
                    Console.WriteLine("{0} pieces are left.", countOfSlices);
                    break;
                }
                if (command != "STOP")
                {
                    int eatenSlice = int.Parse(command);
                    countOfSlices = countOfSlices - eatenSlice;
                }
                

            }
            if (notEnoughSlices)
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(countOfSlices));
            } else if (countOfSlices < 0)
            {
                Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(countOfSlices));
            }

             
            }


        }
    }
