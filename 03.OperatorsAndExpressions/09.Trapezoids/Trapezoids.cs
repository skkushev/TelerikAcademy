/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.
Examples:

a	       b	    h	    area
5	       7	    12	    72
2	       1        33	    49.5
8.5	      4.3	    2.7	    17.28
100	      200	    300	    45000
0.222	  0.333	    0.555	0.1540125*/

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Please enter side A= ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Please enter side B= ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Please enter height H= ");
        double height = double.Parse(Console.ReadLine());
        double area = (((sideA + sideB) / 2) * height);
        Console.WriteLine("Trapezoid with sides A={0}, B={1} and height={2} have area={3}", sideA, sideB, height, area);
    }
}
