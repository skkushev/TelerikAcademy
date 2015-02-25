/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.*/

using System;
using System.Linq;
class CompareArrays
{
    static void Main()
    {
        int[] arr1 = { 2, 5, 3, 6, 1 };
        int[] arr2 = { 2, 5, 3, 6, 1 };
        Console.WriteLine("Compare one = {0}", arr1.SequenceEqual(arr2));

        int[] arr3 = { 2, 5, 3, 6, 1 };
        int[] arr4 = { 1, 6, 3, 5, 2 };
        Console.WriteLine("Compare two = {0}", arr3.SequenceEqual(arr4.Reverse()));
    }
}