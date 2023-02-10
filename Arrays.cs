/*
 Author: Zowaib Farooq
 Date1/31/2023
 Description:This is a C# console application computes the first 25 numbers of the Fibonaccisequence
*/


using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < 25; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
            }
        }
    }
}