/*Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

using System;


namespace _15.AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.Write("Enter your birthday in format dd.mm.yyyy: ");
            DateTime birthdate = DateTime.Parse (Console.ReadLine());
            DateTime timenow = DateTime.Now;
            int agenow = timenow.Year - birthdate.Year;
            if (DateTime.Now.AddYears(-agenow) < birthdate) --agenow;
            Console.WriteLine("Now you are on {0}", agenow);
            Console.WriteLine("After ten years you'll be {0}", agenow + 10);
        }
    }
}
