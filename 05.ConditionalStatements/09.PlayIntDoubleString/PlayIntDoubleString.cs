/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
Example 1:

program     	        user
Please choose a type:	
1 --> int	
2 --> double	        3
3 --> string	
Please enter a string:	hello
hello*	
Example 2:

program	                user
Please choose a type:	
1 --> int	
2 --> double	        2
3 --> string	
Please enter a double:	1.5
2.5*/

using System;

class PlayIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type | 1 for int, 2--> for or 3 for string |: ");
        byte choose = byte.Parse(Console.ReadLine());
        switch (choose)
        {
            case 1:
                Console.Write("Please enter integer: ");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Result is = {0}",intNumber + 1);
                break;
            case 2:
                Console.Write("Please enter double: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Result is = {0}",doubleNumber + 1);
                break;
            case 3:
                Console.Write("Please enter string: ");
                string word = Console.ReadLine();
                Console.WriteLine("Result is = {0}*", word);
                break;
        }
    }
}