using System;
using System.Collections.Generic;
using System.Linq;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            var evens = (from x in numbers where x % 2 == 0 select x);
            return evens.Sum();
        }

        public double AverageEvens(int[] numbers)
        {
            var evens = (from x in numbers where x % 2 == 0 select x);
            return evens.Any() ? evens.Average() : 0.0;
        }

        public bool IsSumOdd(List<int> numbers)
        {

            return numbers.Sum() % 2 != 0;
        }
    }
}
