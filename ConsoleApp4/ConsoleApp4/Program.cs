﻿using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            { 
                arr[i] = int.Parse(Console.ReadLine());  
            }
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
