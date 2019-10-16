using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterCS
{
    class CurrencyConverter
    {

        public float Calculate(float input, Currency x, Currency y)
        {
            // Mathmatical Calculation for Conversion:
            // input amount / x = euro amount
            // euro amount * y = output
            // All rates pertain to EURO, which is why EURO is used to calculate the conversion.

            float euroAmount = input / x.rate;
            float result = euroAmount * y.rate;
            return result;
        }



    }
}
