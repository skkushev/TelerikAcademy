/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
Example 1:

input   	output
2 
5 
1	        min = 1 
            max = 5 
            sum = 8 
            avg = 2.67
Example 2:

input	output
2 
-1 
4	    min = -1 
        max = 4 
        sum = 3 
        avg = 1.50*/

using System;

class MinMaxSum
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int number;

        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            number = int.Parse(Console.ReadLine());

            if (number > max)
            {
                max = number;
            }

            if (number < min)
            {
                min = number;
            }

            sum += number;
        }
        double avg = (double)sum / n;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = {0:F2}", avg);
    }
}