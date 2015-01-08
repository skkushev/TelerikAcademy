/*Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

using System;

namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.Write("Enter your birthday (Use DD.MM.YYYY format):");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int AgeNow = now.Year - birthday.Year;
            Console.WriteLine("Now you are on {0} !", AgeNow);
            Console.WriteLine("After 10 years you will be on {0}", AgeNow + 10);
        }
    }
}
