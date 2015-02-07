/*Problem 13. Binary to Decimal Number

Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Examples:

binary	                        decimal
0	                               0
11	                               3
1010101010101011	             43691
1110000110000101100101000000	236476736*/

using System;

class BinaryDecimalNum
{
    static void Main()
    {
        // input
        Console.WriteLine("Enter number in Binary representacion: ");
        Console.WriteLine(new string('-', 40));
        Console.Write("Enter Binary number -> ");
        string input = Console.ReadLine();

        int count = input.Length - 1;
        long decimalNumber = 0;

        for (int i = 0; i < input.Length; i++)
        {
            decimalNumber += long.Parse(input[i].ToString()) * (long)Math.Pow(2, (count - i));
        }

        // output
        Console.WriteLine(decimalNumber);
    }
}