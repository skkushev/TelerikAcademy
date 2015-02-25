/*Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:

array	                S	    result
4, 3, 1, 4, 2, 5, 8 	11	    4, 2, 5*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FindSumInArra
{
    static void Main()
    {
        Console.WriteLine("Enter the size of array");
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];
        Console.WriteLine("Size of array is: {0}", arraySize);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter {0} number in array", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }


        Console.Write("S = ");
        int s = int.Parse(Console.ReadLine());

        int start = 0;
        int sumArray = 0;
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (sumArray == s)
            {
                for (int p = i - counter; p < i; p++)
                {
                    Console.Write("{0}, ", array[p]);
                }
            }
            else if (sumArray + array[i] <= s)
            {

                sumArray += array[i];
                counter++;
            }
            else
            {
                sumArray = 0;
                i = i - counter;
                counter = 0;
            }
        }
    }
}
