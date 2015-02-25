/*
Problem 2. Get largest number• Write a method  GetMax()  with two parameters that returns the larger of two integers.
• Write a program that reads  3  integers from the console and prints the largest of them using the method  GetMax() .
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GetLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int secondNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        int thirdNum = int.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            Console.WriteLine("the greater of this 3 numbers is {0}", Math.Max(firstNum, thirdNum));
        }
        else
        {
            Console.WriteLine("the greater of this 3 numbers is {0}", Math.Max(secondNum, thirdNum));
        }
    }
}