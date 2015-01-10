/*Problem 1. Declare Variables

Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short,
ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.*/

using System;

class DeclareVariables
{
    static void Main()
    {
        byte firstNumber = 97;
        Console.WriteLine("For number {0} we can use byte data type (range from - 0 to 255)", firstNumber);
        sbyte secondNumber = -115;
        Console.WriteLine("For number {0} we can use sbyte data type (range from -128 to 127)", secondNumber);
        short thirdNumber = -10000;
        Console.WriteLine("For number {0} we can use short data type (range from -32768 to 32767)", thirdNumber);
        ushort fourthNumber = 52130;
        Console.WriteLine("For number {0} we can use ushort date type (range from 0 to 65535)", fourthNumber);
        int fifthNumber = 4825932;
        Console.WriteLine("For number {0} we can use int date type (range from -2147483648 to 2147483647)", fifthNumber);
    }
}
