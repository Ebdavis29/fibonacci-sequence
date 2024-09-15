using System;

namespace FibonacciSequence
{
    class Program
    {
        static int FibonacciLoop(int n)
        {
            int a = 0, b = 1, c;
            if (n == 0) return a;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }

        static int FibonacciRecursion(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci using loops:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"F({i}) = {FibonacciLoop(i)}");
            }

            Console.WriteLine("Fibonacci using recursion:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"F({i}) = {FibonacciRecursion(i)}");
            }
        }
    }
}