using System;
using System.Text;

namespace _06._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            // top part of the Rhombus
            for (int middleLine = 0; middleLine < n - 1; middleLine++)
            {
                sb.Append(new string(' ', n - middleLine - 1));

                for (int stars = 0; stars < middleLine + 1; stars++)
                {
                    sb.Append("*");
                    if (stars < middleLine)
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();
            }
            
            // middle line of the Rhombus
            for (int middleLine = 0; middleLine < n; middleLine++)
            {
                sb.Append("*");
                sb.Append(" ");
            }
            sb.AppendLine();
            // bottom part of the rhombus

            for (int bottomLine = n-1; bottomLine >= 0; bottomLine--)
            {
                sb.Append(new string(' ', n - bottomLine));

                for (int stars = 0; stars < bottomLine; stars++)
                {
                    sb.Append("*");
                    if (stars < bottomLine)
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();

            }

            Console.WriteLine(sb);
        }

    }
}
