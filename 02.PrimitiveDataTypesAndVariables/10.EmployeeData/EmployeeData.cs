/*Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name Last name Age (0...100) Gender (m or f) Personal ID number (e.g. 8306112507) Unique employee number (27560000…27569999) 
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.*/

using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("Hello, please enter your First and Last name: ");
        string firstLastName = Console.ReadLine();
        Console.Write("How old are you (0 to 100)?: ");
        byte ages = byte.Parse(Console.ReadLine());
        if (ages > 100)
        {
            Console.WriteLine("Hello turtle! Try again :)");
            return;
        }
        Console.Write("What gender are you ? (m or f):");
        char gender = char.Parse(Console.ReadLine());
        if (gender == 'm')
        {
            Console.WriteLine();
        }
        else if (gender == 'f')
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Wrong symbol");
            return;
        }
        Console.Write("Enter your ID number (e.g. 8306112507)!: ");
        long idNumber = long.Parse(Console.ReadLine());
        Console.WriteLine("You are {0}, {1} years old, {2}, ID NUMBER: {3}", firstLastName, ages, gender, idNumber);
        Console.WriteLine("You have successfully registered in the system!");
        Console.WriteLine("Press any key to recive unique number...");
        Console.ReadLine();
        Random randomNumber = new Random();
        int employeeNumber = randomNumber.Next(27560000, 27569999);
        Console.WriteLine("Your Unique employee number is {0}", employeeNumber);
    }
}
