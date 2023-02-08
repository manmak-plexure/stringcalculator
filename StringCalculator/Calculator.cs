using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    internal class Calculator
    {
        char[] separators = new char[] { ',', '\n' };
        string stringNumbers = "";

        internal int Add(string numbers)
        {
            // Validate
            if (numbers.Length == 0) return 0;

            this.stringNumbers = numbers;

            // Check for custom separator
            if (numbers.Length > 2) CheckForCustomSeparator();

            // Calculate sum
            var stringNumberArray = this.stringNumbers.Split(this.separators);
            var intNumberArray = stringNumberArray.Select(int.Parse).ToArray();
            var sum = intNumberArray.Sum();

            return sum;
        }

        private void CheckForCustomSeparator()
        {
            if (this.stringNumbers.Substring(0, 2) == "//")
            {
                var splitInput = stringNumbers.Split('\n');
                var newSeparator = splitInput[0].Substring(2);

                this.separators = this.separators.Concat(new char[] { char.Parse(newSeparator) }).ToArray();
                this.stringNumbers = splitInput[1];

            }
        }
    }
}
