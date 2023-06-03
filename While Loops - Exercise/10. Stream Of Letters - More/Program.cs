using System;
using System.Text;


namespace _10._Stream_Of_Letters___More
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Думите скрити в потока са разделени от тайна команда от три букви – "c", "o" и "n". 
            //При първото получаване на една от тези букви, тя се маркира като срещната, но не се запазва в думата. При всяко следващо нейно срещане се записва нормално в думата. 
            //При всяко следващо нейно срещане се записва нормално в думата.
            // След като са налични и трите символа от командата, се печата думата и интервал " "
            //Започва се нова дума, която по същия начин чака тайната команда, за да бъде отпечатана.

            //int letterCounter = 0;
            
            bool cLetter = false;
            bool oLetter = false;
            bool nLetter = false;
            
            string result = "";
            string displayResult = "";
            string letter = Console.ReadLine();

            char previousChar = char.Parse(letter);

            while (letter != "End")
            {

                if (char.Parse(letter) == 'c')
                {
                    if (cLetter == false)
                    {
                        cLetter = true;

                    }
                    else
                    {
                        result += char.Parse(letter);
                    }

                }
                else if (char.Parse(letter) == 'o')
                {
                    if (oLetter == false)
                    {
                        oLetter = true;

                    }
                    else
                    {
                        result += char.Parse(letter);
                    }
                }
                else if (char.Parse(letter) == 'n')
                {
                    if (nLetter == false)
                    {
                        nLetter = true;

                    }
                    else
                    {
                        result += char.Parse(letter);
                    }
                }
                else
                {
                    
                    if (char.IsLetter(char.Parse(letter)))
                    {
                        result += char.Parse(letter);
                    }
                }
                if (cLetter && nLetter && oLetter)
                {
                    result += " ";
                    
                    nLetter = false;
                    cLetter = false;
                    oLetter = false;
                    displayResult += result;
                    
                    result = "";
                }

                previousChar = char.Parse(letter);

                letter = Console.ReadLine();
            }
            Console.WriteLine(displayResult);


        }
    }
}