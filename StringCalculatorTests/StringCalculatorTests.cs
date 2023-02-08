using Xunit;
using StringCalculator;
using System.Net.Http.Headers;

namespace StringCalculatorTests
{
    public class StringCalculatorTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("4", 4)]
        [InlineData("1,2", 3)]
        public void CommaSeparatedNumberStringReturnsSum(string input, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(input);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}