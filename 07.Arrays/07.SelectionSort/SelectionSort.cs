/*Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter {0} number in array: ", i + 1);
            int enterNumbers = int.Parse(Console.ReadLine());
            array[i] = enterNumbers;
        }

        Console.Write("Array before sort is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write ("{0} ", array[i]);
        }
        Array.Sort(array);
        Console.WriteLine();
        Console.Write("Array after sort is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
    }
}