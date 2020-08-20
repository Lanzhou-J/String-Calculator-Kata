using System;

namespace String.Calculator
{
    public class StringCalculator
    {
        public int Calculator(string input)
        {
            //throw new NotImplementedException("Not implemented.");
            if (input == "")
            {
                return 0;
            }
            else {
                int result = int.Parse(input);
                return result;
            }
        }
    }
}
