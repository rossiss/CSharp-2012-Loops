using System;
using System.Numerics;

class FibonacciSumFirstN
{
    static void Main(string[] args)
    {
        Console.Write("Please write a number N: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger a = -1;
        BigInteger b = 1;
        BigInteger total = 0;

        for (int counter = 0; counter <= n; counter++)
        {
            BigInteger sum = a + b;
            a = b;
            b = sum;
            total += sum;
        }

        Console.WriteLine("The sum of the first N numbers of the Fibonacci sequence is: " + total);
    }
}
