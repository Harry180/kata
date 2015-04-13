using System;

namespace CalculatorLib
{
    public class CalculatorAddService
    {
        public int Add(string value)
        {
            var result = 0;
            if (!String.IsNullOrWhiteSpace(value))
            {
                var array = value.Split(',');
                for (var i = 0; i < array.Length; i++)
                {
                    result += int.Parse(array[i]);
                }
            }

            return result;
        }
    }
}
