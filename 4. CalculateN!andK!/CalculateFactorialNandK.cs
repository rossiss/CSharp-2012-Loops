 using System;
using System.Numerics;

class CalculateFactorialNandK
{
    static void Main()
    {
        Console.WriteLine("Please wirte a positive number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please write a number K that is smaller than N: ");
        int k = int.Parse(Console.ReadLine());

        if ((1 < k) && (k < n)) 
        {
            BigInteger factorial = 1;

            for (int i = (k + 1); i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("N!/K! = " + factorial);          
        }
        else
        {
            Console.WriteLine("Incorrect input! Please try again.");
        }
    }
}
