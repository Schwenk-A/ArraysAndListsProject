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

            List<int> even = new List<int>();  //Create two Lists of type int.
            List<int> odd = new List<int>();  // Name one List "evens" * Name the other List "odd 


            foreach (var numbers in myArray)
            {
                if ( numbers % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                    Console.WriteLine("odd");

            }
        }
    }
}
