using System;

class PrintNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Please enter a number N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % (3 * 7) == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}
