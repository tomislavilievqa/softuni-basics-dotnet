using System;

namespace _05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int countRowsFirstSector = int.Parse(Console.ReadLine()); 
            int countSeatsOddFloor = int.Parse(Console.ReadLine());


            //От конзолата се чете броят на редовете в първия сектор (A), като във всеки следващ сектор редовете се увеличават с 1. 
            //На всеки ред има определен брой места - тяхната номерация е представена с малките латински букви. 

            //Да се отпечата на конзолата всяко място на отделен ред по следния формат:
            //{ сектор} {ред} { място}

            int currentRows = 0;
            int counter = 0;
            for (char firstSector = 'A'; firstSector <= lastSector; firstSector++)
                {

                
                for (int rows = 1; rows <= countRowsFirstSector; rows++)
                {
                    int currentSeats = 0;

                    if (rows % 2 ==0 )
                    {
                        currentSeats = countSeatsOddFloor + 2;
                    }
                    else
                    {
                        currentSeats = countSeatsOddFloor;
                    }
                    char seatsInLetters = 'a';

                    for (int seats = 1; seats <= currentSeats; seats++)
                    {
                     
                     Console.WriteLine($"{firstSector}{rows}{seatsInLetters}");
                        counter++;
                        seatsInLetters++;
                    }
                    
                }
                countRowsFirstSector++;
            }
            Console.WriteLine(counter);
            }
                
        }
    }

