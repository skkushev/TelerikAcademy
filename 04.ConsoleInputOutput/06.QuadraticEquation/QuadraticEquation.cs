/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
Examples:

a	    b   	c	    roots
2	    5	    -3	    x1=-3; x2=0.5
-1	    3	    0	    x1=3; x2=0
-0.5	4	    -8	    x1=x2=4
5	    2	    8	    no real roots*/


using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("A=");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("B=");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("C=");
        double numberC = double.Parse(Console.ReadLine());

        //"discriminant =" Quadratic equation formula http://en.wikipedia.org/wiki/Quadratic_equation

        double discriminant = Math.Sqrt(Math.Pow(numberB, 2) - 4 * (numberA) * (numberC));
        if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            double x2 = (-numberB + discriminant) / (2 * numberA);
            double x1 = (-numberB - discriminant) / (2 * numberA);
            Console.WriteLine("x1={0} and x2={1}", x1, x2);
        }
    }
}