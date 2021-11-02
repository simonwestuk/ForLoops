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
            double min = 1000;


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

                        //max = x > max ? x : max;

                        if (x > max)
                        {
                            max = x;
                        }

                        //min = x < min ? x : min;

                        if (x < min)
                        {
                            min = x;
                        }
                    }

                } while (x < 1 && x > 1000);


            }

            //SUM, MIN, MAX, MEAN
            Console.WriteLine($"Total is {sum}");
            Console.WriteLine($"Max is {max}");
            Console.WriteLine($"Min is {min}");
            Console.WriteLine($"Mean is {sum/10}");
        }
    }
}
