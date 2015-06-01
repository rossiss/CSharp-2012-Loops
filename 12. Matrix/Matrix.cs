using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Please provide a number N from 0 to 20: ");
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col <= (row + n - 1); col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}