/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
Examples:

n	k	n! / (k! * (n-k)!)
3	2	3
4	2	6
10	6	210
52	5	2598960*/

using System;

class CalculateNAndK2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factN = 1;
        int factK = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factN *= i;
        }
        for (int i = 1; i <= (n - k); i++)
        {
            factK *= i;
        }
        int sum = factN / factK;
        Console.WriteLine(sum);
    }
}