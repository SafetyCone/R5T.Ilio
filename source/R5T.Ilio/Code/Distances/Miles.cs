using System;

using R5T.Dubley;


namespace R5T.Ilio
{
    public class Miles : TypedDouble
    {
        #region Static

        public static Miles From(double value)
        {
            var miles = new Miles(value);
            return miles;
        }

        #endregion


        public Miles(double value)
            : base(value)
        {
        }
    }
}
