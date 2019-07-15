using System;
using System.Linq;

namespace factorial
{
    class Program

    {
        static void Main(string[] args)

        {
            if (args.Length !=1)
            {
                Console.WriteLine("You must pass exactly one argument");
                Environment.Exit(-1);

            }
            var n = int.Parse(args[0]);
         
            Console.WriteLine($"Factorial of {n} is {Factorial_recursive(n)}");
            Console.WriteLine($"Factorial of {n} is {Factorial_tailrecursive(n)}");
            Console.WriteLine($"Factorial of {n} is {Factorial_for(n)}");
            Console.WriteLine($"Factorial of {n} is {Factorial_LinqAggregate(n)}");
            Console.WriteLine($"Fib {n}: {Fib(8)}");
        }

        static int Factorial_LinqAggregate(int n) => Enumerable.Range(1, n - 1).Aggregate(1, (x, y) => x * y);

        static int Factorial_recursive(int n)
        { 
            //base case, n == 1
            if (n == 1) return 1;

            // otherwise
            return n * Factorial_recursive(n - 1);
        }

        static int Factorial_tailrecursive(int n, int accumulator = 1)

        {
            //base case, n == 1
            if (n == 1) return accumulator;

            // otherwise
            return n * Factorial_tailrecursive(n - 1, accumulator * n);
        }
        static int Fib(int n, int x=0, int y =1)
        {
            if (n == 0) return x;

            return Fib(n - 1, y, x + y);

        }
        static int Factorial_for(int n)
        {
            var accum = 1;

            for (int i = 1; i <=n; ++i)
            {
                accum = accum * i;
                accum *= i;


            }
            return accum;

        }
    }
}          


    

       
