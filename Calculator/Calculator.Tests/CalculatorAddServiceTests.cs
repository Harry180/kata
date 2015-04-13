using Xunit;

namespace Calculator.Tests
{
    public class CalculatorAddServiceTests
    {
        [Fact]
        public void should_return_zero_when_value_as_a_empty_string()
        {
            const string value = "";

            //act
            var result = new CalculatorLib.CalculatorAddService().Add(value);

            //assert
            Assert.Equal(0, result);
        }
    }
}
