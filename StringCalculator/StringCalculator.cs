using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    internal class StringCalculator
    {
        protected string[] Separators;
        protected int MaximumNumber;

        internal StringCalculator(string[]? separators = null, int maximumNumber = 1000)
        {
            Separators = separators ?? new string[] { ",", "\n" };
            MaximumNumber = maximumNumber;
        }

        internal virtual int Add(string numberString)
        {
            // Validate
            if (numberString.Length == 0) return 0;

            // Calculate sum
            var stringNumberArray = numberString.Split(Separators, StringSplitOptions.None);
            var intNumberArray = stringNumberArray.Select(int.Parse).ToArray();
            var filteredNumberArray = FilterNumbersLargerThanMax(intNumberArray);
            ValidatePositiveNumbers(filteredNumberArray);
            
            var sum = filteredNumberArray.Sum();

            return sum;
        }

        internal void ValidatePositiveNumbers(int[] numbers)
        {
            List<int> negativeNumbers = new();
            foreach (var number in numbers) if (number < 0) negativeNumbers.Add(number);

            if (negativeNumbers.Count > 0)
            {
                var errorMessage = $"negatives not allowed: {string.Join(' ', negativeNumbers)}";
                throw new Exception(errorMessage);
            }
        }

        internal int[] FilterNumbersLargerThanMax(int[] numbers)
        {
            List<int> numbersLessThanMax = new();
            foreach (int number in numbers) if (number <= MaximumNumber) numbersLessThanMax.Add(number);
            return numbersLessThanMax.ToArray();
        }
    }
}
