using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double sum = 0;
            double max = 0;
            double min = 0;
            double mean = 0;


            for (int i = 1; i <= 10; i++)
            {
 
                do
                {
                    Console.WriteLine($"Enter number {i}:");
                    x = Convert.ToDouble(Console.ReadLine());

                    if (x < 1 || x > 1000) //Invalid 
                    {
                        Console.WriteLine("Number nees to be between 1 - 1000.");
                        i--;
                    }
                    else //Valid
                    {
                        sum = sum + x;
                    }

                } while (x < 1 && x > 1000);

                //SUM, MIN, MAX, MEAN
                Console.WriteLine($"Total is {sum}");
            }

        
        }
    }
}
