using System;

namespace _09.LandscapingTheGardens
{
    class Program
    {
        static void Main(string[] args)
        {
            double landscapedFieldsByCubicMeters = double.Parse(Console.ReadLine());
            double priceForOneCubicMeter = 7.61;
            double LandscapedFields = landscapedFieldsByCubicMeters * priceForOneCubicMeter;
            double finalPrice = LandscapedFields * 0.82;
            double discount = LandscapedFields - finalPrice;

            Console.WriteLine("The final price is: {0:F2} lv.  The discount is: {0:F2}", finalPrice, discount);

            // {0:F2} - два знака след десеттична, {0:F3} - три знака и т.н.
        }
    }
}
