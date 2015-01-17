/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Input a four-digit number (e.g. 2011): ");
        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber < 1000)
        {
            Console.WriteLine("Enter 4 digit number");
        }
        else if (inputNumber > 9999)
        {
            Console.WriteLine("Enter 4 digits number");
        }
        else 
        {
        int a = (inputNumber / 1000) % 10;
        int b = (inputNumber / 100) % 10;
        int c = (inputNumber / 10) % 10;
        int d = inputNumber % 10;
        int sum = a + b + c + d;
        Console.WriteLine("Calculates the sum of the digits {0}", sum);
        Console.WriteLine("Prints on the console the number in reversed order: dcba = number {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Puts the last digit in the first position: dabc = number {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Exchanges the second and the third digits: acbd = number {0}{1}{2}{3}", a, c, b, d);
        }
    }
}
