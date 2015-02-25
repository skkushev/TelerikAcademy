/*

Problem 1. Decimal to binary• Write a program to convert decimal numbers to their binary representation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToBinary
{
    static string DecimalToBinaryFunc(int number)
    {
        int remainder;
        string result = string.Empty;


        while (number > 0)
        {
            remainder = number % 2;
            number /= 2;
            result = remainder.ToString() + result;
        }


        return result;
    }


    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of {0} dec is {1} bin.", number, DecimalToBinaryFunc(number));
    }

}