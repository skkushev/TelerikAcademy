/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
Examples:

numbers	sum
3	    90
20	
60	
10	
5   	6.5
2	
-1	
-0.5	
4	
2	
1	    1
1*/

using System;

class SumOfN
{
    static void Main()
    {
        Console.Write("How many numbers you want to sum ?: ");
        double number = double.Parse(Console.ReadLine());
        double sum = 0;
        Console.WriteLine("Enter numbers: ");
        for (int i = 1; i <= number; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Result is: " + sum);
    }
}