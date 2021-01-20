using System;

using R5T.Dubley;


namespace R5T.Ilio
{
    public class Kilometers : TypedDouble
    {
        #region Static

        public static Kilometers From(double value)
        {
            var endpointIdentity = new Kilometers(value);
            return endpointIdentity;
        }

        #endregion


        public Kilometers(double value)
            : base(value)
        {
        }
    }
}
