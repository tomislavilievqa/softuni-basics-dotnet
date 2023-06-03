using System;
using System.Text;

namespace _05._Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int topRow = 0; topRow < n; topRow++)
            {
                if (topRow == 0 || topRow == n - 1)
                {
                    sb.Append("+ ");
                }
                else
                {
                    sb.Append("- ");
                }
                
                if (topRow == n - 1)
                {
                    sb.AppendLine();
                }
            }
            for (int middleRow = 0; middleRow < n-2; middleRow++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == 0 || i == n - 1)
                    {
                        sb.Append("| ");
                    }
                    else
                    {
                        sb.Append("- ");
                    }
                }
                sb.AppendLine();
            }         
            for (int bottom = 0; bottom < n; bottom++)
            {
                if (bottom == 0 || bottom == n - 1)
                {
                    sb.Append("+ ");
                }
                else
                {
                    sb.Append("- ");
                }
            }

            Console.WriteLine(sb);
        }
    }
}
