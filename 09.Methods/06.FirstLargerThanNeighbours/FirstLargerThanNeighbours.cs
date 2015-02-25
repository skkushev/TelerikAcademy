/*
Problem 6. First larger than neighbours• Write a method that returns the index of the first element in array that is larger than its neighbours, or  -1 , if there’s no such element.
• Use the method from the previous exercise.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter how many element will be in your array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = InputArray(n);
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (CkeckNeighbours(array, i))
            {
                Console.WriteLine("The index of the first element in array that is larger than its neighbours is: {0}", i);
                count++;
                return;
            }
        }


        if (count == 0) Console.WriteLine(-1);
    }
    static int[] InputArray(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    static bool CkeckNeighbours(int[] array, int position)
    {
        bool result = false;
        if (position == 0)
        {
            return result = array[0] > array[1];
        }
        else if (position == array.Length - 1)
        {
            return result = array[position] > array[position - 1];
        }
        else
        {
            return result = (array[position] > array[position - 1] && array[position] > array[position + 1]);
        }
        return result;
    }

}
