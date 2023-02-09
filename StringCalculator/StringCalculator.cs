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

            ValidatePositiveNumbers(intNumberArray);
            var sum = intNumberArray.Sum();

            return sum;
        }

        internal void ValidatePositiveNumbers(int[] numbers)
        {
            List<int> negativeNumbers = new();
            foreach (var number in numbers)
            {
                if (number < 0) negativeNumbers.Add(number);
            }

            if (negativeNumbers.Count > 0)
            {
                var errorMessage = $"negatives not allowed: {string.Join(' ', negativeNumbers)}";
                throw new Exception(errorMessage);
            }
        }
    }
}
