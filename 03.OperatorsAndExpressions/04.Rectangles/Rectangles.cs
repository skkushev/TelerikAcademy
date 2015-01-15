/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:

width	height	perimeter	area
  3	      4	       14	    12
 2.5 	  3	       11	    7.5
  5	      5	       20	    25*/

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Please enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter height: ");
        double height = double.Parse(Console.ReadLine());
        //Second way
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine("The perimeter is " + perimeter + " and the area is " + area);
        //Second way
        Console.WriteLine("Perimeter = " + 2 * (width + height) + ". Area = " + (width * height) + ".");
    }
}

