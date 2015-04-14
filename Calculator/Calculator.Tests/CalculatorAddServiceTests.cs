using Xunit;

namespace Calculator.Tests
{
    public class CalculatorAddServiceTests
    {
        private CalculatorLib.CalculatorAddService _calculatorAddService = new CalculatorLib.CalculatorAddService();

        [Fact]
        public void should_return_zero_when_value_as_a_empty_string()
        {
            const string value = "";

            //act
            var result = _calculatorAddService.Add(value);

            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void should_return_same_value_than_passed()
        {
            const string value = "1";

            //act
            var result = _calculatorAddService.Add(value);

            //assert

            Assert.Equal(1, result);
        }

        [Fact]
        public void should_return_sum_of_values_passed()
        {
            const string value = "1,2";
            const int expectedValue = 3;

            //act
            var result = _calculatorAddService.Add(value);

            //assert

            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void should_return_sum_of_values_with_newline_delimeter()
        {
            const string value = "1\n2,3";
            const int expectedValue = 6;

            //act
            var result = _calculatorAddService.Add(value);

            //assert
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void should_return_zero_or_correct_sum_of_correct_values_in_incorrect_string()
        {
            const string value = "1,\n";
            const int expectedValue = 1;

            //act
            var result = _calculatorAddService.Add(value);

            //assert
            Assert.Equal(expectedValue, result);
        }
    }
}
