using System;

namespace Homework_2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            int StartRange;
            int StopRange;

            Console.WriteLine("Enter start of the range: ");
            StartRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter stop of the range: ");
            StopRange = Convert.ToInt32(Console.ReadLine());

            int i = StartRange;
            while (i <= StopRange)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                i++;
            }
            Console.WriteLine("The sum of odd numbers: " + sum);
        }
    
    }
}
