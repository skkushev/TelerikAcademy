/*
Problem 14. Integer calculations• Write methods to calculate  minimum ,  maximum ,  average ,  sum  and  product  of given set of integer numbers.
• Use variable number of arguments.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IntegerCalculations
{
    static void Main()
    {
        Console.Write("Enter how many element will be in your array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = InputArray(n);
        Console.WriteLine("The Minimum of set integers: {0}", Min(array));
        Console.WriteLine("The Maximum of set integers: {0}", Max(array));
        Console.WriteLine("The Average Sum of set integers: {0}", AverageSum(array));
        Console.WriteLine("The Sum of set integers: {0}", Sum(array));
        Console.WriteLine("The Product of set integers: {0}\n", Product(array));
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
    static int Min(params int[] array)
    {
        int min = array[0];


        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
        }
        return min;
    }
    static int Max(params int[] array)
    {
        int max = array[0];


        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        return max;
    }
    static int Sum(params int[] array)
    {
        return array.Sum();
    }
    static decimal AverageSum(params int[] numbers)
    {
        return (decimal)Sum(numbers) / numbers.Length;
    }
    static int Product(params int[] array)
    {
        return array.Aggregate(1, (current, t) => current * t);
    }
}
