using System;

namespace CalculatorLib
{
    public class CalculatorAddService
    {
        public int Add(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                return 0;
            }

            throw new NotImplementedException();
        }
    }
}
