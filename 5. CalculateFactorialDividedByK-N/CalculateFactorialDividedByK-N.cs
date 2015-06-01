using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please wirte a positive number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please write a number K that is greater than N: ");
        int k = int.Parse(Console.ReadLine());

        if ((1 < n) && (n < k))
        {
            BigInteger factorial1 = 1;
            BigInteger factorial2 = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial1 *= i;
            }

            for (int i = (k - n + 1); i <= k; i++)
            {
                factorial2 *= i;
            }

            BigInteger result = factorial1 * factorial2;

            Console.WriteLine("The result for N!*K!/(K-N)! is: " + result);
        }
        else
        {
            Console.WriteLine("Incorrect input! Please try again.");
        }
    }
}
