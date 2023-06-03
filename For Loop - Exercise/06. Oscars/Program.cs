using System;
namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int countOfEvaluative = int.Parse(Console.ReadLine());
          

            for (int i = 1; i <= countOfEvaluative; i++)
            {
                String evaluativeName = Console.ReadLine();
                double pointsByEvaluative = double.Parse(Console.ReadLine());
                int lengthActorName = evaluativeName.Length;
                academyPoints += ((lengthActorName * 1.0) * pointsByEvaluative / 2);

            
                if(academyPoints > 1250.5)
                {
                    Console.WriteLine("Congratulations, {0} got a nominee for leading role with {1:F1}!",actorName,academyPoints);
                    break;
                }
            
            }
            double actualResult = academyPoints - 1250.5;
            if (academyPoints < 1250.5)
            {
                Console.WriteLine("Sorry, {0} you need {1:F1} more!",actorName,Math.Abs(actualResult));

            }
           

        }
    }
}