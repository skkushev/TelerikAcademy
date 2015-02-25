/*

Problem 3. English digit• Write a method that returns the last digit of given integer as an English word.

Examples:


input      output

512         two 
1024        four 
12309       nine 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EnglishDigit
{
    static void Main()
    {
        Console.WriteLine("Enter digit");
        int number = int.Parse(Console.ReadLine());
        int lastDigit = Convert.ToInt32(number.ToString().AsEnumerable().Last().ToString());
        #region Switch
		 

        switch (lastDigit)
        {
            case 0:
                {
                    Console.WriteLine("zero");
                    break;
                }
            case 1:
                {
                    Console.WriteLine("one");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("two");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("three");
                    break;
                }
            case 4:
                {
                    Console.WriteLine("four");
                    break;
                }
            case 5:
                {
                    Console.WriteLine("five");
                    break;
                }
            case 6:
                {
                    Console.WriteLine("six");
                    break;
                }
            case 7:
                {
                    Console.WriteLine("seven");
                    break;
                }
            case 8:
                {
                    Console.WriteLine("eight");
                    break;
                }
            case 9:
                {
                    Console.WriteLine("nine");
                    break;
                }
            default:
                break;
        #endregion
        }
    }
}