/*

Problem 10. N Factorial• Write a program to calculate  n!  for each  n  in the range [ 1..100 ].

Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NFactorial
{
    static void Main()
    {
        Console.Write("Enter a number N:");
        int n = int.Parse(Console.ReadLine());
        List<int> factorial = CalculateFactorial(n);
        Console.WriteLine("{0}! = {1}", n, string.Join("", factorial));
    }
    static List<int> CalculateFactorial(int n)
    {
        int[] array = { 1 };
        int left = 0;
        for (int i = 2; i <= n; i++, left = 0)
        {
            int[] b = i.ToString().Select(ch => ch - '0').ToArray();
            int[] c = new int[array.Length + b.Length];
            for (int k = array.Length - 1; k >= 0; k--)
            {
                for (int j = b.Length - 1; j >= 0; j--)
                {
                    c[array.Length - k + b.Length - j - 2] += array[k] * b[j];
                }
            }


            for (int j = 0; j < c.Length; j++)
            {
                var digits = c[j] + left;
                c[j] = digits % 10;
                left = digits / 10;
            }
            array = c;
            Array.Reverse(c);
        }
        int start = 0;
        while (array[start] == 0) start++;
        List<int> result = new List<int>();
        for (int i = start; i < array.Length; i++)
        {
            result.Add(array[i]);
        }
        return result;
    }

}