using System;

namespace ConversionLibrary
{
    public class TempConversion
    {
        public static decimal CToF(decimal TempC)
        {
            return TempC * (9m/5m) + 32;
        }

        public static decimal CToK(decimal TempC)
        {
            return TempC + 273.15m;
        }

        public static decimal FToC(decimal TempF)
        {
            return TempF * (5m/9m) -32;
        }

        public static decimal FToK(decimal TempF)
        {
            return TempF * (5m/9m) + 241.15m;
        }

        public static decimal KToC(decimal TempK)
        {
            return TempK - 273.15m;
        }

         public static decimal KToF(decimal TempK)
        {
            return TempK  * (9m/5m) - 241.15m;
        }



        

    }
}
