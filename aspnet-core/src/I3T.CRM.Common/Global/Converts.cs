using System;

namespace I3T.CRM.Common.Global
{
    public class GlobalConverts
    {
        public static DateTime clearTime(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day);
        }

        public static string getSorting(string s, bool IsReverse = false)
        {
            if (string.IsNullOrEmpty(s))
            {
                return null;
            }

            string[] ss = s.Trim().Split(' ');
            if (ss.Length == 1)
            {
                return IsReverse ? s + " DESC" : s;
            }

            if (ss.Length > 1)
            {
                string sort = ss[1].ToUpper();
                if (sort == "DESC" || sort == "ASC")
                {
                    if (!IsReverse)
                    {
                        return ss[0] + " " + sort;
                    }

                    return ss[0] + " " + (sort == "ASC" ? "DESC" : "ASC");
                }
            }

            return null;
        }

        public static DateTime? strToDate(string s, string fomat = "dd/MM/yyyy")
        {
            try
            {
                return DateTime.ParseExact(s, fomat, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static long? strToLong(string s)
        {
            if (!String.IsNullOrEmpty(s))
            {
                try { return Convert.ToInt64(s.Trim()); } catch { }
            }

            return null;
        }
    }
}