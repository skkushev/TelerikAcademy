/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
Examples:

n	Catalan(n)
0	1
5	42
10	16796
15	9694845*/

using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        BigInteger factorialPlus = 1;
        BigInteger facotrialMultiplay = 1;
        if (n > 0 && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            for (int i = 1; i <= n + 1; i++)
            {
                factorialPlus *= i;
            }
            for (int i = 1; i <= n * 2; i++)
            {
                facotrialMultiplay *= i;
            }
        }
        BigInteger sum = (facotrialMultiplay / (factorialPlus * factorial));
        Console.WriteLine(sum);
    }
}