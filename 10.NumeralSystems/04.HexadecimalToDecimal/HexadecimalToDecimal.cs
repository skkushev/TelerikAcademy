/*
Problem 4. Hexadecimal to decimal• Write a program to convert hexadecimal numbers to their decimal representation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Please, enter a hexademical number: ");
        string hex = Console.ReadLine();
        Console.WriteLine(Convert.ToInt64(hex, 16));

    }
}