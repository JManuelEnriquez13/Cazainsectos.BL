using System;

namespace Cazainsectos.BL.Utils
{
    public static class DBNullHelper
    {
        //If value is DBNull then convert value to null
        public static object Null_If_DBNull(object value)
        {
            return value == DBNull.Value ? null : value;
        }

        //If value is null or empty then convert value to DBNull
        public static object DBNull_If_Null(object value)
        {
            if (value == null || (value is string && string.IsNullOrEmpty((string)value)))
                return DBNull.Value;
            return value;
        }
    }
}