/*Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[,] array = new int[number, number];
        int digit = 1;

        //A
        for (int cols = 0; cols < number; cols++)
        {
            for (int rows = 0; rows < number; rows++)
            {
                array[cols, rows] = digit;
                digit++;
            }
        }
        // Print A
        for (int col = 0; col < number; col++)          
        {
            for (int row = 0; row < number; row++)
            {
                Console.Write("{0, 4}", array[row, col]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        //B
        for (int cols = 0; cols < number; cols++)
        {
            if (cols % 2 == 0)
            {
                for (int rows = 0; rows < number; rows++)
                {
                    array[cols, rows] = digit;
                    digit++;
                }
            }
            else
            {
                for (int rows = number - 1; rows >= 0; rows--)
                {
                    array[cols, rows] = digit;
                    digit++;
                }
            }
        }
        // Print B
        for (int col = 0; col < number; col++)
        {
            for (int row = 0; row < number; row++)
            {
                Console.Write("{0, 4}", array[row, col]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        //C
        int Row = number - 1;
        int Col = 0;
        int startRow = number - 1;
        int startCol = 0;

        while (digit < number * number)
        {
            if (Row == (number - 1) && Col < (number - 1))
            {
                if (digit == 1)
                {
                    array[Col, Row] = digit;
                }
                startRow--;
                startCol = 0;
                Row = startRow;
                Col = startCol;
                digit++;
                array[Col, Row] = digit;

                while (Row < (number - 1) && Col < (number - 1))
                {
                    Row++;
                    Col++;
                    digit++;
                    array[Col, Row] = digit;
                }
            }
            if (Row <= (number - 1) && Col == (number - 1))
            {
                startRow = 0;
                startCol++;
                Row = startRow;
                Col = startCol;
                digit++;
                array[Col, Row] = digit;

                while (Col < (number - 1))
                {
                    Col++;
                    Row++;
                    digit++;
                    array[Col, Row] = digit;
                }
            }
        }
        // Print C
        for (int c = 0; c < number; c++)           
        {
            for (int r = 0; r < number; r++)
            {
                Console.Write("{0, 4}", array[r, c]);
            }
            Console.WriteLine();
        }
        digit = 1;
        Console.WriteLine();

        //D

        int offset = 0;
        int ROW = 0;
        int COL = 0;
        while (digit <= number * number)
        {
            for (ROW = offset; ROW < number - offset; ROW++)
            {
                COL = offset;
                array[ROW, COL] = digit;
                digit++;
            }
            for (COL = 1 + offset; COL < number - offset; COL++)
            {
                ROW = number - 1 - offset;
                array[ROW, COL] = digit;
                digit++;
            }
            for (ROW = number - 2 - offset; ROW >= offset; ROW--)
            {
                COL = number - 1 - offset;
                array[ROW, COL] = digit;
                digit++;
            }
            for (COL = number - 2 - offset; COL >= offset + 1; COL--)
            {
                ROW = offset;
                array[ROW, COL] = digit;
                digit++;
            }
            offset++;
        }
        // Print D
        for (int irow = 0; irow < number; irow++)           
        {
            for (int column = 0; column < number; column++)
            {
                Console.Write("{0, 4}", array[irow, column]);
            }
            Console.WriteLine();
        }


    }
}