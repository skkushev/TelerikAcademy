/*Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
Example:

input	                                result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter the size of array: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter {0} number in array: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Array is {0}", string.Join(", ", array));

        Array.Sort(array);

        int counter = 0;
        int number = 0;

        int bestCount = 0;
        int bestNumber = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                number = array[i];
                counter++;
            }
            else
            {
                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestNumber = number;
                    counter = 0;
                    number = 0;
                }
                else
                {
                    counter = 0;
                    number = 0;
                }
            }
        }
        Console.WriteLine("Most frequent number in an array is {0} ({1} times)", bestNumber, bestCount + 1);
    }
}
