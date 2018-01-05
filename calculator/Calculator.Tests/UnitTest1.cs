using System;
using Xunit;

namespace CalculatorApp.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }

        [Fact]
        public void SubtractTwoIntegers()
        {
            int sub = _calculator.Subtract(54, 9);

            Assert.Equal(sub, 45);
        }

        [Fact]
        public void MultiplyTwoIntegers()
        {
            int multiply = _calculator.Multiply(3, 9);

            Assert.Equal(multiply, 27);
        }

        [Fact]
        public void DivideTwoIntegers()
        {
            int divide = _calculator.Divide(45, 9);

            Assert.Equal(divide, 5);
        }
    }
}
