using System;

public class EuclideanGCD
{
    static int GCD(int a, int b)
    {
        int Remainder;

        while (b != 0)
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }
        return a;
    }

    static int Main(string[] args)
    {
        Console.Write("Please write an integer number X: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Please write an integer number Y: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("The Greatest Common Divisor (GCD) of ");
        Console.WriteLine("{0} and {1} is {2}", x, y, GCD(x, y));

        return 0;
    }
}