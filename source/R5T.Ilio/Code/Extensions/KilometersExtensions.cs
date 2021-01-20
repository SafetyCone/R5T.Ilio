using System;


namespace R5T.Ilio
{
    public static class KilometersExtensions
    {
        public const double ToMilesConversionFactor = 0.621371;


        public static Miles ToMiles(this Kilometers kilometers)
        {
            var milesValue = kilometers.Value * KilometersExtensions.ToMilesConversionFactor;

            var miles = Miles.From(milesValue);
            return miles;
        }
    }
}
