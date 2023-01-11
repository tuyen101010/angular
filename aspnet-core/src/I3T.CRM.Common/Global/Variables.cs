using System;

namespace I3T.CRM.Common.Global
{
    public class GlobalVariables
    {
        public static string MsSqlConnectionString;
        public static string MySqlConnectionString;

        public static bool SQL_WRITE_LOG = false;
        public static bool SQL_WRITE_LOG_ONLY_FALSE = false;
        public static bool API_WRITE_LOG = false;
    }
}