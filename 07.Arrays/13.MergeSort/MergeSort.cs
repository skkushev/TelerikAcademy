/*Problem 13.* Merge sort

Write a program that sorts an array of integers using the Merge sort algorithm.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MergeSort
{
    static void Main()
    {

        /*  Write a program that sorts an array of integers using
         *  the merge sort algorithm (find it in Wikipedia). */

        // "CLASSICAL" RECURSIVE SOLUTION - memory consuming.

        Console.Write("Enter array lenght (or 0 for array autogeneration): ");
        int n = int.Parse(Console.ReadLine());
        int[] arr;
        if (n == 0)
        {
            Random rnd = new Random();
            n = rnd.Next(10, 20);
            Console.WriteLine();
            Console.WriteLine("Generated N: {0}", n);
            arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(100);
        }
        else
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        // inpit is done.

        Console.WriteLine("Unsorted array:");
        for (int i = 0; i < n; i++)
            Console.Write("{0,3}", arr[i]);
        Console.WriteLine();
        Console.WriteLine();

        MyMergeSort(arr);

        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        for (int i = 0; i < n; i++)
            Console.Write("{0,3}", arr[i]);
        Console.WriteLine();
    }

    static void MyMergeSort(int[] array)
    {
        Console.Write("Split: ");
        foreach (int i in array)
            Console.Write("{0} ", i);

        if (array.Length < 2)   // array contain only one element
        {
            Console.WriteLine(" <- Splited to single element");
            return;             // nothing to do, return.
        }
        else
            Console.WriteLine();
        int[] leftArray = new int[array.Length / 2];                    // left half of array
        int[] rigthArray = new int[array.Length - leftArray.Length];    // remainin part of array
        Array.Copy(array, 0, leftArray, 0, leftArray.Length);           // copy values in left part
        Array.Copy(array, leftArray.Length, rigthArray, 0, rigthArray.Length); // copy values in right part
        MyMergeSort(leftArray);                                         // recursive call to MyMergeSort for left part
        MyMergeSort(rigthArray);                                        // recursive call to MyMergeSort for right part

        //start of joining two parts

        Console.WriteLine("Merge: ");
        foreach (int i in leftArray)
            Console.Write("{0} ", i);
        Console.Write("+ ");
        foreach (int i in rigthArray)
            Console.Write("{0} ", i);
        Console.Write(" -> ");

        int leftMarker = 0; // pointer for left array
        int rightMarker = 0; // pointer for right array
        do
        {
            if (leftArray[leftMarker] < rigthArray[rightMarker])
            {
                array[leftMarker + rightMarker] = leftArray[leftMarker];
                leftMarker++;
            }
            else
            {
                array[leftMarker + rightMarker] = rigthArray[rightMarker];
                rightMarker++;
            }
        } while (leftMarker < leftArray.Length && rightMarker < rigthArray.Length); // all pieces are moved, or there is pieces only in one subarray (no future comaprasion needed)

        for (int i = leftMarker; i < leftArray.Length; i++) // if there is some remaining elements in left subarray
            array[i + rightMarker] = leftArray[i];          // move them to root array;
        for (int i = rightMarker; i < rigthArray.Length; i++) // same for right subarray;
            array[leftMarker + i] = rigthArray[i];
        foreach (int i in array)
            Console.Write("{0} ", i);
        Console.WriteLine();
        // may be Array.Copy will be faster, but indexes in this case are ... very complicated :)
    }
}