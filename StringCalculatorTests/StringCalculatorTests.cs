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
        [InlineData("1,2,3,4,5,6,7,8,9", 45)]
        [InlineData("1\n2", 3)]
        [InlineData("//;\n1;2", 3)]
        public void SeparatedNumberStringReturnsSum(string input, int expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Add(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1,-2,-3")]
        public void NegativeNumbersCauseError(string input)
        {
            // Arrange
            var calculator = new Calculator();
            var expected = "negatives not allowed: -2 -3";

            // Assert
            var exception = Assert.Throws<Exception>(() => calculator.Add(input));
            Assert.Equal(expected, exception.Message);
        }

    }
}