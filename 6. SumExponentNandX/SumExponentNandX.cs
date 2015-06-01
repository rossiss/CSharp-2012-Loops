using System;
using System.Numerics;

class SumExponentNandX
{
    static void Main()
    {
        Console.WriteLine("Please wirte an integer number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Please write an integer number X: ");
        int x = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        BigInteger power;
        BigInteger sum = 1;
        
        for (int k = 0; k <= n; k++)
        {
            factorial *= k;
            power = (BigInteger)Math.Pow(x, k);
            sum += factorial / power;
        } 

        Console.WriteLine(sum);
    }
}
