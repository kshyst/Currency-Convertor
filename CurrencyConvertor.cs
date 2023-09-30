using System;

namespace CurrencyConvertor
{
    static class CurrencyConvertor
    {
        private static float DollarPrice = 50000;
        public static float TomanToDollar(this float Money)
        {
            float temp = Money / DollarPrice;

            return Math.Abs(temp);
        }
        public static float DollarToToman(this float Money)
        {
            float temp = Money * DollarPrice;

            return temp;
        }
    }

}
