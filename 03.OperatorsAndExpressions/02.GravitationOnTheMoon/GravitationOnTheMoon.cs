/*Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
Examples:

weight	weight on the Moon
86	    14.62
74.6	12.682
53.7	9.129*/

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weigh: ");
        double kilos = double.Parse(Console.ReadLine());
        double moonKilos = kilos * 0.17d;
        Console.WriteLine("Your weigh on the moon will be " + moonKilos + " kilos");
    }
}
