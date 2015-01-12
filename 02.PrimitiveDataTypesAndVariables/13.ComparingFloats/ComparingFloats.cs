/*Problem 13.* Comparing Floats

Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter first number to compare");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number to compare");
        double secondNumber = double.Parse(Console.ReadLine());
        double compare = Math.Abs(firstNumber - secondNumber);
        double eps = 0.000001;
        if (compare <= eps)
        {
            Console.WriteLine("equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}

