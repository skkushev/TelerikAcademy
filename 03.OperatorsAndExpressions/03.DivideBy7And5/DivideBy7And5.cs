/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
Examples:

n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
35	true
140	true*/

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Write integer: ");
        int inputNumbers = int.Parse(Console.ReadLine());
        bool result = (inputNumbers % 7 == 0) && (inputNumbers % 5 == 0) && (inputNumbers !=0);
        Console.WriteLine(result);
    }
}