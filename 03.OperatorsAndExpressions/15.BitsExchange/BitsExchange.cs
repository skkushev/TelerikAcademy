﻿/*Problem 15.* Bits Exchange

Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
Examples:

n	         binary representation of n	                    binary result	                    result
1140867093	 01000100 00000000 01000000 00010101	        01000010 00000000 01000000 00100101	1107312677
255406592	 00001111 00111001 00110010 00000000	        00001000 00111001 00110010 00111000	137966136
4294901775	 11111111 11111111 00000000 00001111	        11111001 11111111 00000000 00111111	4194238527
5351	     00000000 00000000 00010100 11100111	        00000100 00000000 00010100 11000111	67114183
2369124121	 10001101 00110101 11110111 00011001	        10001011 00110101 11110111 00101001	2335569705*/

using System;
using System.Text;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        uint number = uint.Parse(Console.ReadLine());
        uint mask = ((7 << 3) | (7 << 24));
        uint firstBitGroup = (number >> 3) & 7;
        uint secondBitGroup = (number >> 24) & 7;
        Console.WriteLine((number & (~mask)) | ((firstBitGroup << 24) | (secondBitGroup << 3)));
    }
}