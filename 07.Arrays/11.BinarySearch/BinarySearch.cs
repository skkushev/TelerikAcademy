/*Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.*/
//https://www.youtube.com/watch?v=JQhciTuD3E8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main()
    {
        int[] array = { 0, 13, 2, 6, 91, 5, 45, 7, 8, 205, 10, 18, 58, 35, -8, -378, 77, 44, 55, 123, 153, -13};
        Console.Write("Search for number: ");
        int searchedNum = int.Parse(Console.ReadLine());
        int result = 0;
        Console.WriteLine("Array before sort - {0}", string.Join(", ", array));
        Array.Sort(array);
        Console.WriteLine("Array after sort - {0}", string.Join(", ", array));
        int center = array.Length / 2;
        int currentNumber = array[center];

        while (searchedNum != currentNumber)
        {
            while (searchedNum > currentNumber)
            {
                center = (array.Length + center) / 2;
                currentNumber = array[center];
            }
            while (searchedNum < currentNumber)
            {
                center = (center) / 2;
                currentNumber = array[center];
            }
            result = center;
        }
        Console.WriteLine("Number {0} is on {1} position in array", searchedNum, result);
    }
}