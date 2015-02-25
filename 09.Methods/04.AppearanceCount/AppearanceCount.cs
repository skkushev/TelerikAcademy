/*
Problem 4. Appearance count• Write a method that counts how many times given number appears in given array.
• Write a test program to check if the method is workings correctly.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AppearanceCount
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 56, 87, 3, 99, 56, 3, 78, 3, 5, 9, 3 };
        int number = 3;
        Console.WriteLine(CountNumberInArray(arr, number));
    }


    static int CountNumberInArray(int[] numbers, int number)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (number == numbers[i])
            {
                count++;
            }
        }
        return count;
    }

}