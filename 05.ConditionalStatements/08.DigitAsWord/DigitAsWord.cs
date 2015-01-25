﻿/*Problem 8. Digit as Word

Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.
Examples:

d	    result
2	    two
1	    one
0	    zero
5	    five
-0.1	not a digit
hi	    not a digit
9	    nine
10	    not a digit*/

using System;

class DigitAsWord
{
    static void Main()
    {
        Console.Write("Ask for a digit from 0-9: ");
        string digit = Console.ReadLine();
        switch (digit)
        {
            case "0":
                Console.WriteLine("{0} = zero", digit);
                break;
            case "1":
                Console.WriteLine("{0} = one", digit);
                break;
            case "2":
                Console.WriteLine("{0} = two", digit);
                break;
            case "5":
                Console.WriteLine("{0} = five", digit);
                break;
            case "9":
                Console.WriteLine("{0} = nine", digit);
                break;
            default:
                Console.WriteLine("not a digit");
                break;
        }
    }
}