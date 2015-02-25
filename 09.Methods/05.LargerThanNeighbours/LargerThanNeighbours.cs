/*

Problem 5. Larger than neighbours• Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter array's elements:");
        int elementsNumber = int.Parse(Console.ReadLine());
        int[] array = new int[elementsNumber];


        FillTheArray(array);


        PrintArray(array);


        Console.WriteLine("Enter the element to check:");
        int checkedElement = EnterElementToCheck(array);


        bool isLarger = IfLargerThanNeighbours(array, checkedElement);
        Console.Write("The element at position {0} is larger than its two neighbours: {1}", checkedElement, isLarger);
        Console.WriteLine();
    }


    public static bool IfLargerThanNeighbours(int[] array, int checkedElement)
    {
        bool result = ((array[checkedElement] > array[checkedElement - 1]) && (array[checkedElement] > array[checkedElement + 1]));
        return result;
    }


    private static int EnterElementToCheck(int[] array)
    {
        int element = int.Parse(Console.ReadLine());


        if ((element == 0) || (element == (array.Length - 1)))
        {
            Console.WriteLine("This element has only one neighbour. Enter another one!");
            return EnterElementToCheck(array);
        }
        if ((element < 0) || (element > (array.Length - 1)))
        {
            Console.WriteLine("Input is out of the array. Enter another one!");
            return EnterElementToCheck(array);
        }
        else
        {
            return element;
        }
    }


    private static void FillTheArray(int[] array)
    {
        Console.WriteLine("Enter array's elements:");
        int element = 0;


        for (int i = 0; i < array.Length; i++)
        {
            element = int.Parse(Console.ReadLine());
            array[i] = element;
        }
    }


    private static void PrintArray(int[] array)
    {
        Console.WriteLine("The array is: {0}", string.Join(", ", array));
    }

}
