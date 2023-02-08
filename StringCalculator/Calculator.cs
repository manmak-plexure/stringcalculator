using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    internal class Calculator
    {
        internal int Add(string numbers)
        {
            // Validate
            if (numbers.Length == 0) return 0;

            // Calculate sum
            var stringNumbers = numbers.Split(',', '\n');
            var intNumbers = stringNumbers.Select(int.Parse).ToArray();
            var sum = intNumbers.Sum();

            return sum;
        }
    }
}
