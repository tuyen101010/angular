using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.EntityFrameworkCore.Repositories
{
    public class CacheLogs
    {
        public static Dictionary<int, string> folderLogSql = new Dictionary<int, string>();
        public static Dictionary<int, List<string>> sbLogSql = new Dictionary<int, List<string>>();
    }
}
