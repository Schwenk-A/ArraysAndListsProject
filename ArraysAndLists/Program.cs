using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenOrOdd();
        }
        public static void EvenOrOdd()
        {

            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var even = new List<int>();  //Create two Lists of type int.
             var odd = new List<int>();  // Name one List "evens" * Name the other List "odd 


            for ( var i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    even.Add(myArray[i]);
                }
                else
                    odd.Add(myArray[i]);

            }
            Console.WriteLine("even");
            foreach (var num in even)
            {
                Console.WriteLine($"{num} is an even number");
            }
            Console.WriteLine("Odd");
            foreach(var num in odd)
            {
                Console.WriteLine($"{num} is odd");
            }
        }
    }
}
