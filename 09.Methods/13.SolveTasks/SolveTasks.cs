/*
Problem 13. Solve tasks• Write a program that can solve these tasks: ◦ Reverses the digits of a number
◦ Calculates the average of a sequence of integers
◦ Solves a linear equation  a * x + b = 0  

• Create appropriate methods.
• Provide a simple text-based menu for the user to choose which task to solve.
• Validate the input data: ◦ The decimal number should be non-negative
◦ The sequence should not be empty
◦  a  should not be equal to  0  

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SolveTasks
{
    static void Main()
    {
        Menu();


        Console.WriteLine(new string('=', 32));
        Console.WriteLine("Thank you for using the program!");
        Console.WriteLine(new string('-', 32));
        Console.WriteLine("Press \"return\" to exit!");
        Console.WriteLine(new string('=', 32));
    }


    private static void Menu()
    {
        Console.WriteLine(new string('=', 52));
        Console.Write(new string(' ', 19));
        Console.WriteLine("SELECT TASK");
        Console.WriteLine(new string('-', 52));
        Console.WriteLine("1. Reverse the digits of a number");
        Console.WriteLine("2. Calculate the average of a sequence of integers");
        Console.WriteLine("3. Solve a linear equation (a * x + b = 0)");
        Console.WriteLine(new string('-', 52));
        Console.WriteLine("Press 1 / 2 / 3 for choise or any other key to exit.");
        Console.WriteLine(new string('=', 52));


        char key = char.Parse(Console.ReadLine());
        Console.Clear();


        switch (key)
        {
            case '1':
                ReverseDigits();
                break;
            case '2':
                CalculateAverage();
                break;
            case '3':
                SolveEquation();
                break;
            default:
                return;
        }
    }


    private static void SolveEquation()
    {
        Console.WriteLine(new string('=', 27));
        Console.Write("Enter value for 'a': ");
        double a = double.Parse(Console.ReadLine());
        double b = 0;
        Console.WriteLine(new string('-', 27));


        if (a == 0)
        {
            Console.WriteLine("The only option for 'b' is 0.");
        }
        else
        {
            Console.Write("Enter value for 'b': ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 27));
        }


        Console.WriteLine("x = {0}", (-b / a));
        Console.WriteLine(new string('=', 27));


        Console.WriteLine("Press 1 to start a new task");
        Console.WriteLine("or other key for Menu.");
        Console.WriteLine(new string('-', 27));


        char key = char.Parse(Console.ReadLine());
        Console.Clear();


        if (key == '1')
        {
            SolveEquation();
        }
        else
        {
            Menu();
        }
    }


    private static void CalculateAverage()
    {
        int elementsNumber = 0;


        do
        {
            Console.WriteLine(new string('=', 27));
            Console.WriteLine("Enter integers' number");
            Console.WriteLine(new string('-', 27));
            elementsNumber = int.Parse(Console.ReadLine());
        }
        while (elementsNumber <= 0);


        decimal[] array = new decimal[elementsNumber];
        decimal sum = 0;
        Console.WriteLine(new string('-', 27));
        Console.WriteLine("Enter the integers");


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = decimal.Parse(Console.ReadLine());
            sum += array[i];
        }


        decimal average = sum / elementsNumber;


        Console.WriteLine(new string('-', 27));
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine(new string('-', 27));
        Console.WriteLine("The average is: {0}", average);
        Console.WriteLine(new string('=', 27));


        Console.WriteLine("Press 1 to start a new task");
        Console.WriteLine("or other key for Menu.");
        Console.WriteLine(new string('-', 27));


        char key = char.Parse(Console.ReadLine());
        Console.Clear();


        if (key == '1')
        {
            CalculateAverage();
        }
        else
        {
            Menu();
        }
    }


    private static void ReverseDigits()
    {
        decimal number = 0;


        do
        {
            Console.WriteLine(new string('=', 27));
            Console.WriteLine("Enter a non-negative number");
            Console.WriteLine(new string('-', 27));
            number = decimal.Parse(Console.ReadLine());
        }
        while (number < 0);


        string stringNumber = Convert.ToString(number);
        string temporary = string.Empty;


        for (int i = 0; i < stringNumber.Length; i++)
        {
            temporary = Convert.ToString(stringNumber[i]) + temporary;
        }


        Console.WriteLine(new string('-', 27));
        Console.WriteLine(temporary);
        Console.WriteLine(new string('-', 27));
        Console.WriteLine("Your number is reversed!");
        Console.WriteLine(new string('=', 27));


        Console.WriteLine("Press 1 to start a new task");
        Console.WriteLine("or other key for Menu.");
        Console.WriteLine(new string('-', 27));


        char key = char.Parse(Console.ReadLine());
        Console.Clear();


        if (key == '1')
        {
            ReverseDigits();
        }
        else
        {
            Menu();
        }
    }

}
