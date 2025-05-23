﻿using System;
using System.Collections.Generic;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.WriteLine($"Index of 1: {numbers.IndexOf(1)}");
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count); 
            
            numbers.Remove(1);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }

}
            
           
        
        
           