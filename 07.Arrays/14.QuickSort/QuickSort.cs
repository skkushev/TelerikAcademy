/*Problem 14. Quick sort

Write a program that sorts an array of integers using the Quick sort algorithm.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class QuickSort
{
    static void Main()
    {

        int[] arr = { 4, 3, 2, 1, -1, 99, 12, 33, 99, 10 };
        q_sort(ref arr);
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }

    public static void q_sort(ref int[] input)
    {
        System.Collections.Stack stack = new System.Collections.Stack();
        int pivot;
        int pivotIndex = 0;
        int leftIndex = pivotIndex + 1;
        int rightIndex = input.Length - 1;

        stack.Push(pivotIndex);//Push always with left and right
        stack.Push(rightIndex);

        int leftIndexOfSubSet, rightIndexOfSubset;

        while (stack.Count > 0)
        {
            rightIndexOfSubset = (int)stack.Pop();//pop always with right and left
            leftIndexOfSubSet = (int)stack.Pop();

            leftIndex = leftIndexOfSubSet + 1;
            pivotIndex = leftIndexOfSubSet;
            rightIndex = rightIndexOfSubset;

            pivot = input[pivotIndex];

            if (leftIndex > rightIndex)
                continue;

            while (leftIndex < rightIndex)
            {
                while ((leftIndex <= rightIndex) && (input[leftIndex] <= pivot))
                    leftIndex++;	//increment right to find the greater 
                //element than the pivot

                while ((leftIndex <= rightIndex) && (input[rightIndex] >= pivot))
                    rightIndex--;//decrement right to find the 
                //smaller element than the pivot

                if (rightIndex >= leftIndex)   //if right index is 
                    //greater then only swap
                    SwapElement(ref input, leftIndex, rightIndex);
            }

            if (pivotIndex <= rightIndex)
                if (input[pivotIndex] > input[rightIndex])
                    SwapElement(ref input, pivotIndex, rightIndex);

            if (leftIndexOfSubSet < rightIndex)
            {
                stack.Push(leftIndexOfSubSet);
                stack.Push(rightIndex - 1);
            }

            if (rightIndexOfSubset > rightIndex)
            {
                stack.Push(rightIndex + 1);
                stack.Push(rightIndexOfSubset);
            }
        }
    }

    private static void SwapElement(ref int[] arr, int left, int right)
    {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
    }
}