/*Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).*/

using System;
using System.Linq;
class CompareCharArrays
{
    static void Main()
    {
        char[] arr1 = {'b', 'd', 'e', 's', 'r'};
        char[] arr2 = { 'b', 'd', 'e', 's', 'r'};
        bool compareOne = arr1.SequenceEqual(arr2);
        Console.WriteLine("Compare one = {0}", compareOne);

        char[] arr3 = { 'b', 'd', 'G', 's', 'r' };
        char[] arr4 = { 'b', 'd', 'e', 's', 'r' };
        bool compareTwo = arr3.SequenceEqual(arr4);
        Console.WriteLine("Compare two = {0}", compareTwo);

        char[] arr5 = { 'B', 'D', 'E', 'S', 'R' };
        char[] arr6 = { 'b', 'd', 'e', 's', 'r' };
        bool compareThree = arr5.SequenceEqual(arr6);
        Console.WriteLine("Compare three = {0}", compareThree);
    }
}