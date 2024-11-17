using System;
class Program
{
    static void Main()
    {
        int count = 0;
        for (int n = 0; n <= 365 / 28; n++)
        {
            for (int k = 0; k <= (365 - 28 * n) / 30; k++)
            {
                for (int m = 0; m <= (365 - 28 * n - 30 * k) / 31; m++)
                {
                    if (28 * n + 30 * k + 31 * m == 365)
                    {
                        Console.WriteLine($"Решение: (n={n},k={k},m={m})");
                        count++;
                    }
                }
            }
        }
    }
}


            





