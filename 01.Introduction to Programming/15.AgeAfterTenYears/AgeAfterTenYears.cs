/*Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birthday in format dd.mm.yyyy: ");
        DateTime birthdDate = DateTime.Parse(Console.ReadLine());
        DateTime timeNow = DateTime.Now;
        int ageNow = timeNow.Year - birthdDate.Year;
        if (DateTime.Now.AddYears(-ageNow) < birthdDate) --ageNow;
        Console.WriteLine("Now you are on {0}", ageNow);
        Console.WriteLine("After ten years you'll be {0}", ageNow + 10);
    }
}
