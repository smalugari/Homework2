using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
             int i = 0;
            double sum = 0;
            int number;

            Console.WriteLine("Enter a number: ");

            do
            {
                number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                {
                    i++;
                    sum += number;
                }
            }
            while (number != 0);
            Console.WriteLine($"The number of numbers entered : " + (i + 1));
            Console.WriteLine($"Total sum: " + sum);
            Console.WriteLine($"Arithmetic mean: " + sum / (i + 1));
            Console.ReadLine();
        
        }
    }
}
