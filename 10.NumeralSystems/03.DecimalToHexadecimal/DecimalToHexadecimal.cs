/*

Problem 3. Decimal to hexadecimal• Write a program to convert decimal numbers to their hexadecimal representation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("Enter Decimal number: ");
        string inputDecimalNumber = Console.ReadLine();
        long decimalNumber = long.Parse(inputDecimalNumber);
        StringBuilder result = DecimalNumberToHexadecimal(decimalNumber);
        Console.WriteLine(result);
    }
    static StringBuilder DecimalNumberToHexadecimal(long decimalNumber)
    {
        StringBuilder result = new StringBuilder();
        if (decimalNumber != 0)
        {
            while (decimalNumber != 0)
            {
                switch (decimalNumber % 16)
                {
                    case 10: result.Append('A'); break;
                    case 11: result.Append('B'); break;
                    case 12: result.Append('C'); break;
                    case 13: result.Append('D'); break;
                    case 14: result.Append('E'); break;
                    case 15: result.Append('F'); break;
                    default: result.Append(decimalNumber % 16); break;
                }
                decimalNumber = decimalNumber / 16;
            }
        }
        return result;

    }
}