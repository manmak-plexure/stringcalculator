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
            if (numbers.Length > 2 && numbers.Substring(0, 2) == "//")
            {
                var stringCalc = new StringWithSeparatorCalculator();
                return stringCalc.Add(numbers);
            }
            else
            {
                var stringCalc = new StringCalculator();
                return stringCalc.Add(numbers);
            }
        }
    }
}
