using System;

namespace Homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the height of the triangle");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 1; j < height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = height - 2 * i; j <= height; j++)
                {
                    Console.Write("^");
                }
                Console.ReadLine();
            }
        }
    }
}
