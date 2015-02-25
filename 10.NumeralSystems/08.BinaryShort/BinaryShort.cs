/*
Problem 8. Binary short• Write a program that shows the binary representation of given 16-bit signed integer number (the C# type  short ).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryShort
{
    static string GetShortBinaryString(short n)
    {
        char[] b = new char[16];
        int pos = 15;
        int i = 0;


        while (i < 16)
        {
            if ((n & (1 << i)) != 0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(b);
    }


    static void Main()
    {
        Console.WriteLine("Enter 16 bit short number: ");
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of {0} is {1}", number, GetShortBinaryString(number));

    }
}