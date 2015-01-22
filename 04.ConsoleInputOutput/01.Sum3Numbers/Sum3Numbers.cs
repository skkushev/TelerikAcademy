/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
Examples:

a	    b	    c	    sum
3   	4	    11	    18
-2  	0	    3	    1
5.5	    4.5 	20.1	30.1*/

using System;

class Sum3Numbers
{
    static void Main()
    {
        Console.Write("Enter number a=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b=");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter number c=");
        int c = int.Parse(Console.ReadLine());
        int sum = a + b + c;
        Console.WriteLine("The sum of a+b+c={0}", sum);
        
    }
}