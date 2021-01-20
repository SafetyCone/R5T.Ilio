using System;

using R5T.Dubley;


namespace R5T.Ilio
{
    public class Miles : TypedDouble
    {
        #region Static

        public static Miles From(double value)
        {
            var endpointIdentity = new Miles(value);
            return endpointIdentity;
        }

        #endregion


        public Miles(double value)
            : base(value)
        {
        }
    }
}
