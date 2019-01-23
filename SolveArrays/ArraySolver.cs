using System;
using System.Collections.Generic;
using System.Linq;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            // using the linq function "Sum()" to calculate the sum of the "numbers" array and returning the result.
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            //using a where statement to gather all even numbers and returning the sum.
            var evens = (from x in numbers where x % 2 == 0 select x);
            return evens.Sum();
        }

        public double AverageEvens(int[] numbers)
        {
            //WHERE statement that gets all even numbers
            var evens = (from x in numbers where x % 2 == 0 select x);
            // ? operator is used to weed out null values to prevent exceptions being thrown.
            return evens.Any() ? evens.Average() : 0.0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            //run sum function on numbers and check if odd with a modulus against 2 is not equal to zero
            return numbers.Sum() % 2 != 0;
        }
    }
}
