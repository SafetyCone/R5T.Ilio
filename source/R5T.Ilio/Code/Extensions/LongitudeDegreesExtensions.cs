using System;


namespace R5T.Ilio
{
    public static class LongitudeDegreesExtensions
    {
        public static bool IsClippable(this LongitudeDegrees longitudeDegrees)
        {
            var isClippable = LongitudeDegrees.IsClippable(longitudeDegrees.Value);
            return isClippable;
        }

        public static LongitudeDegrees ToClipped(this LongitudeDegrees longitudeDegrees)
        {
            var clippable = new LongitudeDegrees(longitudeDegrees.Value, true);
            return clippable;
        }
    }
}
