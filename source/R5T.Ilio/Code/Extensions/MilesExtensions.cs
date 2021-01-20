using System;


namespace R5T.Ilio
{
    public static class MilesExtensions
    {
        public const double ToKilometersConversionFactor = 1.60934;


        public static Kilometers ToKilometers(this Miles miles)
        {
            var kilometersValue = miles.Value * MilesExtensions.ToKilometersConversionFactor;

            var kilometers = Kilometers.From(kilometersValue);
            return kilometers;
        }
    }
}
