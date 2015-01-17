/*Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
Examples:

 x	    y	    inside
 0	    1	    true
-2	    0	    true
-1	    2	    false
 1.5   -1	    true
-1.5   -1.5	    false
 100   -30	    false
 0	    0	    true
 0.2   -0.8	    true
 0.9   -1.93	false
 1	    1.655	true*/

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        bool isInCirle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(2,2);
        Console.WriteLine("Is the points ({0}, {1}) is in cirle? --> {2}", x, y, isInCirle);
    }
}
