/*Problem 4. Unicode Character

Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be * */

using System;

class UnicodeCharacter
{
    static void Main()
    {
        //Im using Console.WriteLine(name.ToString("X")); to find the representation
        int hexadecimal = 42;
        Console.WriteLine("Representation of 42 in hexadecimal is {0}", hexadecimal.ToString("X")); 
        char symbol = '\u002a';
        Console.WriteLine("The symbol is {0}", symbol);
    }
}
