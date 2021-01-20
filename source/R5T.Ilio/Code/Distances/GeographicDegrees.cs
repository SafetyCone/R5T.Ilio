using System;

using R5T.Dubley;


namespace R5T.Ilio
{
    /// <summary>
    /// A class for use when a general "degrees" value is required that is conceptually neither longitude nor latitude.
    /// </summary>
    public class GeographicDegrees : TypedDouble
    {
        #region Static

        public static GeographicDegrees From(double value)
        {
            var geographicDegrees = new GeographicDegrees(value);
            return geographicDegrees;
        }

        #endregion


        public GeographicDegrees(double value)
            : base(value)
        {
        }
    }
}
