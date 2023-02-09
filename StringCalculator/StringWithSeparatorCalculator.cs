using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    internal class StringWithSeparatorCalculator : StringCalculator
    {
        internal override int Add(string numberStringwithSeparator)
        {
            var splitInput = numberStringwithSeparator.Split("\n");
            var newSeparator = splitInput[0].Substring(2);

            Separators = Separators.Concat(new string[] { newSeparator }).ToArray();
            var stringNumbers = splitInput[1];

            return base.Add(stringNumbers);
        }

    }
}
