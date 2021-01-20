using System;

using R5T.Dubley;


namespace R5T.Ilio
{
    public class LatitudeDegrees : TypedDouble
    {
        public const double MaximumValue = 90;
        public const double MinimumValue = -90;
        public const double Range = 180;
        public static readonly LatitudeDegrees Zero = new LatitudeDegrees(0);


        #region Static

        /// <summary>
        /// Determines if a longitude value is clippale.
        /// </summary>
        public static bool IsClippable(double value)
        {
            var isClippable = value > LatitudeDegrees.MaximumValue || value < LatitudeDegrees.MinimumValue;
            return isClippable;
        }

        /// <summary>
        /// Clips a longitude value to be between the max and the min.
        /// </summary>
        public static double Clip(double value)
        {
            var clippedValue = value;

            if (value < LatitudeDegrees.MinimumValue)
            {
                while (clippedValue < LatitudeDegrees.MinimumValue)
                {
                    clippedValue += LatitudeDegrees.Range;
                }

                return clippedValue;
            }

            if (value > LatitudeDegrees.MaximumValue)
            {
                while (clippedValue > LatitudeDegrees.MinimumValue)
                {
                    clippedValue -= LatitudeDegrees.Range;
                }

                return clippedValue;
            }

            return clippedValue;
        }

        public static LatitudeDegrees From(double value, bool clipIfNecessary = true)
        {
            var endpointIdentity = new LatitudeDegrees(value, clipIfNecessary);
            return endpointIdentity;
        }

        #endregion


        public LatitudeDegrees(double value, bool clipIfNecessary = true)
        {
            var actualValue = value;

            if (clipIfNecessary && LatitudeDegrees.IsClippable(value))
            {
                actualValue = LatitudeDegrees.Clip(value);
            }

            this.Value = actualValue;
        }
    }
}
