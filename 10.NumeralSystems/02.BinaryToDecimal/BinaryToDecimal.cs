/*
Problem 2. Binary to decimal• Write a program to convert binary numbers to their decimal representation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please, enter a binary number: ");
        string binary = Console.ReadLine();
        long inDecimal = Convert.ToInt32(binary, 2);
        Console.WriteLine("Decimal representation to binary number {0} is {1}", binary, inDecimal);

    }
}