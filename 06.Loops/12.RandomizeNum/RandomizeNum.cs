/*Problem 12.* Randomize the Numbers 1…N

Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
Examples:

n	    randomized numbers 1…n
3	    2 1 3
10	    3 4 8 2 6 7 9 1 10 5
Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.*/

using System;

class RandomizeNum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] pool = new int[n];
        bool[] printed = new bool[n + 1];
        Random r = new Random();
        int randomized = r.Next(1, n + 1);

        for (int index = 0; index < n; index++)
        {
            randomized = r.Next(1, n + 1);
            if (!printed[randomized])
            {
                Console.Write("{0} ", randomized);
                printed[randomized] = true;
            }
            else
            {
                index--;
            }
        }
        Console.WriteLine();
    }
}