/*

Problem 7. Reverse number• Write a method that reverses the digits of given decimal number.

Example:


input       output


256         652 
123.45      54.321 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enten your number:");
        int n = int.Parse(Console.ReadLine());
        int reverse = ReverseDecimal(n);
        Console.WriteLine(reverse);
    }
    static int ReverseDecimal(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }
        return result;
    }

}