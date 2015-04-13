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
    }
}
