using System;

class PrintAllNumbersToN
{
    static void Main()
    {
        Console.Write("Please enter a number N: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;

        while (counter <= n)
        {
            Console.WriteLine(counter);
            counter++;
        }
    }
}
