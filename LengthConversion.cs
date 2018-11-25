using System;

namespace ConversionLibrary
{
    public class LengthConversion
    {
        public static decimal MetersToFeet(decimal Meter)
        {
            return Meter * 3.281m;
        }

        public static decimal MetersToYard(decimal Meter)
        {
            return Meter * 1.094m;
        }

        public static decimal FeetToMeter(decimal Feet)
        {
            return Feet / 3.281m;
        }

        public static decimal FeetToYard(decimal Feet)
        {
            return Feet / 3;
        }

        public static decimal YardToMeter(decimal Yard)
        {
            return Yard / 1.094m;
        }

        public static decimal YardToFeet(decimal Yard)
        {
            return Yard * 3;
        }
    }
}