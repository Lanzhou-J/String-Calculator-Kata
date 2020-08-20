using Xunit;
using String.Calculator;
using System;

namespace String.UnitTests.Calculator
{
    public class StringCalculator_CalculatorShould
    {
        private readonly StringCalculator _stringCalculator;

        public StringCalculator_CalculatorShould()
        {
            _stringCalculator = new StringCalculator();
        }

        [Fact]
        public void Calculator_ReturnInt()
        {
            var result = _stringCalculator.Calculator("");

            Assert.Equal(typeof(Int32).Name, result.GetType().Name);
        }
    }
}