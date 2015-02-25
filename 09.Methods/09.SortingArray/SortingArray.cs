/*
Problem 9. Sorting array• Write a method that return the maximal element in a portion of array of integers starting at given index.
• Using it write another method that sorts an array in ascending / descending order.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortingArray
{
    static void Main()
    {

        int[] numbers = { 66, 999, 42, 11, 32, 44, 33, 61, 24, 42, 5, 7, 51, 3, 23, 84, 20, 22, 16, 73, 43, 33, 66, 39, 99, 
                         88, 6, 51, 53, 25, 57, 95, 31, 61, 17, 81, 22, 61, 68, 52, 64, 32, 67, 38, 48, 58, 45, 62, 40, 19};


        int index = 3;
        Console.WriteLine(numbers[MaxElement(numbers, index)]);
        SortDescending(numbers);


        PrintArray(numbers);


        SortAscending(numbers);
    }


    private static void SortAscending(int[] numbers)
    {
        int[] arr = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            arr[i] = numbers[numbers.Length - 1 - i];
        }
        PrintArray(arr);
    }


    private static void PrintArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(i < numbers.Length - 1 ? "{0}, " : "{0}.", numbers[i]);
        }
        Console.WriteLine();
    }


    static void SortDescending(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int maxIndex = MaxElement(numbers, i);
            int temp = numbers[i];
            numbers[i] = numbers[maxIndex];
            numbers[maxIndex] = temp;
        }
    }


    static int MaxElement(int[] numbers, int index)
    {
        int maxElement = int.MinValue;
        int maxIndex = 0;
        for (int i = index; i < numbers.Length; i++)
        {
            if (numbers[i] > maxElement)
            {
                maxElement = numbers[i];
                maxIndex = i;
            }
        }
        return maxIndex;
        //return maxElement; 
    }

}