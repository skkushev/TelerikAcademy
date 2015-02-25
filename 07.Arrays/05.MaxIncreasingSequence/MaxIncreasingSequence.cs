/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
Example:

input	                result
3, 2, 3, 4, 2, 2, 4 	2, 3, 4*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxIncreasingSequence
{
    static void Main()
    {
        Console.Write("Number of elements: ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLenght];

        List<int> currentBest = new List<int>();
        List<int> bestSequence = new List<int>();


        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter element {0}", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1] && array[i + 1] - array[i] == 1)
            {
                currentBest.Add(array[i]);
                currentBest.Add(array[i + 1]);

                if (currentBest.Count > bestSequence.Count)
                {
                    bestSequence.Clear();
                    bestSequence.AddRange(currentBest);
                }
            }
            else
            {
                currentBest.Clear();
            }
        }
        List<int> removeEquals = bestSequence.Distinct().ToList();
        for (int i = 0; i < removeEquals.Count; i++)
        {
            Console.Write("{0} ", removeEquals[i]);
        }
    }
}
