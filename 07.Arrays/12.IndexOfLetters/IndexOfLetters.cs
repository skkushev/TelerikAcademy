/*Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IndexOfLetters
{
    static void Main()
    {
        //For A to Z
        char[] lettersUp = new char[26];
        int counter = 0;
        int counterTwo = 0;
        for (int i = 0; i < lettersUp.Length; i++)
        {
            lettersUp[i] = (char)(65 + (counter++));

        }

        //For a to z
        char[] lettersDown = new char[26];
        for (int i = 0; i < lettersDown.Length; i++)
        {
            lettersDown[i] = (char)(97 + (counterTwo++));

        }

        Console.Write("Enter word: ");
        string word = Console.ReadLine();
        foreach (char item in word)
        {
            if (lettersUp.Contains(item))
            {
                Console.WriteLine("{0} on {1} position in alphabet", item, Array.IndexOf(lettersUp, item));
            }
            else if (lettersDown.Contains(item))
            {
                Console.WriteLine("{0} on {1} position in alphabet", item, Array.IndexOf(lettersDown, item));
            }
        }
    }
}