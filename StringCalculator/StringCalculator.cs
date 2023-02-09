using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    internal class StringCalculator
    {
        protected char[] Separators;

        internal StringCalculator(char[]? separators = null)
        {
            Separators = separators ?? new char[] { ',', '\n' };
        }

        internal virtual int Add(string numberString)
        {
            // Validate
            if (numberString.Length == 0) return 0;

            // Calculate sum
            var stringNumberArray = numberString.Split(Separators);
            var intNumberArray = stringNumberArray.Select(int.Parse).ToArray();
            var sum = intNumberArray.Sum();

            return sum;
        }

    }
}
