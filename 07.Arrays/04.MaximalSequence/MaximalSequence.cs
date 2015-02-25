/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	                        result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2*/

using System;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int start = 0;
        int bestStart = 0;
        int bestLen = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[start] == array[i])
            {
                bestStart = start;
                bestLen = i;
            }
            else
            {
                start = i;
            }
        }
        for (int i = bestStart; i <= bestLen; i++)
        {
            Console.Write("{0} ",array[i]);
        }
    }
}