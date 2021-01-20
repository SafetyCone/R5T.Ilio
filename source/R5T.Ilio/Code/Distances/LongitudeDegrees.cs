using System;

using R5T.Dubley;


namespace R5T.Ilio
{
    public class LongitudeDegrees : TypedDouble
    {
        public const double MaximumValue = 180;
        public const double MinimumValue = -180;
        public const double Range = 360;
        public static readonly LongitudeDegrees Zero = new LongitudeDegrees(0);


        #region Static

        /// <summary>
        /// Determines if a longitude value is clippale.
        /// </summary>
        public static bool IsClippable(double value)
        {
            var isClippable = value > LongitudeDegrees.MaximumValue || value < LongitudeDegrees.MinimumValue;
            return isClippable;
        }

        /// <summary>
        /// Clips a longitude value to be between the max and the min.
        /// </summary>
        public static double Clip(double value)
        {
            var clippedValue = value;

            if (value < LongitudeDegrees.MinimumValue)
            {
                while (clippedValue < LongitudeDegrees.MinimumValue)
                {
                    clippedValue += LongitudeDegrees.Range;
                }

                return clippedValue;
            }

            if(value > LongitudeDegrees.MaximumValue)
            {
                while (clippedValue > LongitudeDegrees.MinimumValue)
                {
                    clippedValue -= LongitudeDegrees.Range;
                }

                return clippedValue;
            }

            return clippedValue;
        }

        public static LongitudeDegrees From(double value, bool clipIfNecessary = true)
        {
            var endpointIdentity = new LongitudeDegrees(value, clipIfNecessary);
            return endpointIdentity;
        }

        #endregion


        public LongitudeDegrees(double value, bool clipIfNecessary = true)
        {
            var actualValue = value;

            if (clipIfNecessary && LongitudeDegrees.IsClippable(value))
            {
                actualValue = LongitudeDegrees.Clip(value);
            }

            this.Value = actualValue;
        }
    }
}
