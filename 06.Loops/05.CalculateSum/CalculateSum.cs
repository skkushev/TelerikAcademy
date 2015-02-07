/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
Examples:

n	x	S
3	2	2.75000
4	3	2.07407
5	-4	0.75781*/

using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Number n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Number x= ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1;
        double factorial = 1;
        double xPowN = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xPowN = Math.Pow(x, i);
            sum += factorial / xPowN;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}