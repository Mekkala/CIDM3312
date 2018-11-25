using System;

namespace ConversionLibrary
{
    public class MassConversion
    {
        public static decimal OunceToPound(decimal Oz)
        {
            return Oz / 16m;
        }

        public static decimal OunceToGram(decimal Oz)
        {
            return Oz * 23.35m;
        }

        public static decimal OunceToKilogram(decimal Oz)
        {
            return Oz / 35.274m;
        }

        public static decimal PoundToOunce(decimal lb)
        {
            return lb * 16m;
        }

        public static decimal PoundToGram(decimal lb)
        {
            return lb * 453.592m;
        }

        public static decimal PoundToKilogram(decimal lb)
        {
            return lb / 2.205m;
        }

        public static decimal GramToOunce(decimal Gm)
        {
            return Gm / 28.35m;
        }

        public static decimal GramToPound(decimal Gm)
        {
            return Gm / 453.592m;
        }

        public static decimal GramToKilogram(decimal Gm)
        {
            return Gm / 1000;
        }

        public static decimal KilogramToOunce(decimal Kg)
        {
            return Kg * 35.274m;
        }

        public static decimal KilogramToPound(decimal Kg)
        {
            return Kg * 2.205m;
        }

        public static decimal KilogramToGram(decimal Kg)
        {
            return Kg * 1000;
        }

    }
}
