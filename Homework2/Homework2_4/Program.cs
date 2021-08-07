using System;

namespace Homework2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            SayHello();
            Continuation();
            SayGoodbye();

        }
        static void Continuation()
        {
            Console.WriteLine("Write 'yes' if you want to continue?");
            var userInput = Console.ReadLine();
            if (userInput == "yes")
            {
                var operation = EnterOperationType();
                var x = EnterCalculationOperand();
                var y = EnterCalculationOperand();
                Calculate(x, y, operation);
            }
            else
            {
                SayGoodbye();

            }
            Continuation();
        }

        static void SayHello()
        {
            Console.WriteLine($"Hello from Calculator App!");
        }

        static void SayGoodbye()
        {
            Console.WriteLine("Bye Calculator User!");
        }

        static double EnterCalculationOperand()
        {
            Console.WriteLine("Please enter number for calculation:");
            var userInput = Console.ReadLine();
            if (userInput == "0")
            {
                Console.WriteLine("Kindly remainder that if you try to divide by zero - that's impossible");
            }
            var x = Convert.ToDouble(userInput);
            return x;
        }

        static string EnterOperationType()
        {
            Console.WriteLine("Please enter operation symbol(+,-,*,/,^,!)");
            return Console.ReadLine();
        }

        static double CalculateSum(double a, double b)
        {
            return a + b;
        }

        static double CalculateMultiplication(double a, double b)
        {
            return a * b;
        }

        static double CalculateDivide(double a, double b)
        {
            if (b == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect operation! You can't divide by zero!");
                return 0;
            }
            return a / b;
        }

        static double CalculateDifference(double a, double b)
        {

            return a - b;
        }
        static double CalculateDegree(double a, double b)
        {

            return Convert.ToInt32(Math.Pow(a, b));

        }


        static long CalculateFactorial(double a)
        {

            if (a < 0)
            {
                return 0;
            }
            if (a == 0)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(a) * CalculateFactorial(Convert.ToInt32(a - 1));
            }
        }



        static void Calculate(double a, double b, string operationType)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            double result = 0;

            switch (operationType)
            {
                case "+":
                    result = CalculateSum(a, b);
                    Console.WriteLine($"{a} {operationType} {b} = {result}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "-":
                    result = CalculateDifference(a, b);
                    Console.WriteLine($"{a} {operationType} {b} = {result}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "*":
                    result = CalculateMultiplication(a, b);
                    Console.WriteLine($"{a} {operationType} {b} = {result}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "/":
                    result = CalculateDivide(a, b);
                    Console.WriteLine($"{a} {operationType} {b} = {result}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "^":
                    result = CalculateDegree(a, b);
                    Console.WriteLine($"{a} {operationType} {b} = {result}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "!":
                    result = CalculateFactorial(a);
                    Console.WriteLine($"{a} {operationType} = {result}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect operation");
                    break;
            }
        }
    }
}
