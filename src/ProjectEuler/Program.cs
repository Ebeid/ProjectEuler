using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Problem1();
            Console.ReadLine();
        }

        /// <summary>
        /// Project Euler - Problem 1 - Multiples of 3 and 5 [ https://projecteuler.net/problem=1 ]
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        /// <remarks>This is a generic implementation of the solution.</remarks>
        /// Input Format: 
        ///     The first line of the input contains the multiples ( 3 and 5 in our case).
        ///     The second line of input contains the upper bound (1000 in our case).
        public static void Problem1()
        {
            string multiplesRawInput = Console.ReadLine();
            int upperBound = int.Parse(Console.ReadLine());
            int[] multiples = new int[(multiplesRawInput.Split(" ".ToCharArray())).Count()];
            int i = 0;
            foreach(string multiple in multiplesRawInput.Split(" ".ToCharArray()))
            {
                multiples[i] = int.Parse(multiple);
                i++;
            }

            int result = 0;
            for(int j = 1; j<upperBound; j++)
            {
                if ( ((j % 3) == 0) || ((j % 5) == 0))
                    result = result + j;
            }
            Console.WriteLine(result);
        }
    }
}
