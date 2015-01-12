/*Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.*/

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intNullValue = null;
        double? doubleNullValue = null;
        Console.WriteLine("Here is result of int null value - {0} and null value for double - {1}", intNullValue, doubleNullValue);
        intNullValue = 5;
        doubleNullValue = 18;
        Console.WriteLine("Here is result of int with a value - {0} and double with a value - {1}", intNullValue.GetValueOrDefault(), doubleNullValue.GetValueOrDefault());
    }
}
