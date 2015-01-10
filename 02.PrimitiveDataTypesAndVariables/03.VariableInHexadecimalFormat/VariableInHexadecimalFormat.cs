/*Problem 3. Variable in Hexadecimal Format

Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). 
Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is 254.*/

using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {
        //Im using Console.WriteLine(name.ToString("X")); to find the representation
        int value = 254;
        Console.WriteLine(value.ToString("X"));
        int symbol = 0xFE;
        Console.WriteLine("0xFE in decimal is {0}", symbol);
    }
}
