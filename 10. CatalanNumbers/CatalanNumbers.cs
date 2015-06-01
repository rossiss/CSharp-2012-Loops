using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Please insert a positive number N: ");
        int n = int.Parse(Console.ReadLine());
            
        if (n >= 0)
        {
            BigInteger factorial = 1;
            BigInteger factorial2 = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            for (int i = 1; i <= n + 1; i++)
            {
                factorial2 *= i;
            }

            BigInteger catalanN = (2*factorial) / (factorial2 * factorial);

            Console.WriteLine("The Nth Catalan number by the given N is: {0}", catalanN);
        }
        else
        {
            Console.WriteLine("Incorrect input!");
        }

    }
}
