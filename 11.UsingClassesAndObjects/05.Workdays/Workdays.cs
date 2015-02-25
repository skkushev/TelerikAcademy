/*Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Workdays
{
    static void Main()
    {
        int god = 2015;
        byte month = 3;
        byte date = 27;

        DateTime[] holidays = new DateTime[3];
        holidays[0] = new DateTime(2015, 3, 2);
        holidays[1] = new DateTime(2015, 3, 3);
        holidays[2] = new DateTime(2015, 3, 4);


        DateTime enteredDate = new DateTime(god, month, date);
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(enteredDate);
        Console.WriteLine("Workdays between dates:{0}", WorkDaysCalculator(god, month, date, holidays));

    }
    static int WorkDaysCalculator(int god, int month, int day, DateTime[] arr)
    {
        DateTime enteredDate = new DateTime(god, month, day);
        DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        TimeSpan temp = enteredDate.Subtract(today);
        int result = temp.Days;
        int counter = 0;
        for (int i = 0; i <= result; i++)
        {
            if ((int)today.AddDays(i).DayOfWeek >= 1 && (int)today.AddDays(i).DayOfWeek <= 5)
            {
                counter++;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (DateTime.Compare(today.AddDays(i), arr[j]) == 0)
                    {
                        counter--;
                    }
                }

            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Holidays" + " " + arr[i]);
        }
        return counter;
    }
}