/*Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
Example:

input	                    output
* a = 23.2, h = 5	        58
* a = 11, b = 12, c = 13 	61.48
* a = 10, b = 7, C = 25°    14.79*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Chose calculation");
        Console.WriteLine("1. Side and an altitude to it");
        Console.WriteLine("2. Three sides");
        Console.WriteLine("3. Two sides and an angle between them");

        char ch = Console.ReadKey().KeyChar;

        Console.WriteLine();

        switch (ch)
        {
            case '1':
                Console.WriteLine("Enter side: ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter altitude to it: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Area is {0}", (c * d) / 2);
                break;
            case '2':
                Console.WriteLine("Enter side a: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side b: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side c: ");
                double z = double.Parse(Console.ReadLine());
                double p = (x + y + z) / 2;
                Console.WriteLine("Area is {0}", Math.Sqrt(p * (p - x) * (p - y) * (p - z)));
                break;
            case '3':
                Console.WriteLine("Enter side a: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side b: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter angle: ");
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine("Area is {0}", (a * b * Math.Sin(angle)) / 2);
                break;
            default:
                break;
        }
    }
}