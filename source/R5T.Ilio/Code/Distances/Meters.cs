using System;

using R5T.Dubley;


namespace R5T.Ilio
{
    public class Meters : TypedDouble
    {
        #region Static

        public static Meters From(double value)
        {
            var endpointIdentity = new Meters(value);
            return endpointIdentity;
        }

        #endregion


        public Meters(double value)
            : base(value)
        {
        }
    }
}
