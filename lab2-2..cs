using System;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x=0, b=6, dx=0.5;
            Console.WriteLine("X\t\tY");
            while (x <= b)
            { if (x < 0)
                {
                    Console.WriteLine(Math.Round(x,2) + "\tКоринь з видємного числа неможливий");

                }
                  else if (1 - Math.Sqrt(x) == 0)
                {
                    Console.WriteLine(Math.Round(x, 2) + "\tНа 0 дилити неможливо"); 
                }
            else
                {
                    y = 1 / (1 - Math.Sqrt(x));
                    Console.WriteLine(Math.Round(x, 2) + "\t\t" + Math.Round(y, 2));
                }
                x += dx;
                                  
                        
                        
            }
        }
    }
}