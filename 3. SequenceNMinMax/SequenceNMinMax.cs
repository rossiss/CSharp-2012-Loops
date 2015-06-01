using System;

class SequenceNMinMax
{
    static void Main()
    {
        Console.Write("Please write how many numbers you want to compare: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please enter number 1: ");
        int currentNumber = int.Parse(Console.ReadLine());

        int min, max;
        min = max = currentNumber;

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("Please enter number {0}: ", i+1);
            currentNumber = int.Parse(Console.ReadLine());

            if (max < currentNumber)
            {
                max = currentNumber; 
            }

            if (min > currentNumber)
            {
                min = currentNumber;
            }
        }
        Console.WriteLine("The smallest is {0}", min);
        Console.WriteLine("The biggest is {0}", max);
    }
    }
}
