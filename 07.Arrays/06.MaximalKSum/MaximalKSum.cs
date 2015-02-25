/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements in array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("K elements: ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        int eleWithMaxSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter number {0} in array: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Array.Reverse(array);
        for (int i = 0; i < k; i++)
        {
            eleWithMaxSum += array[i];
        }
        Console.WriteLine(eleWithMaxSum);
    }
}
