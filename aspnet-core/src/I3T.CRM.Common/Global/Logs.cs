using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace I3T.CRM.Common.Global
{
    public class GlobalLogs
    {
        public static string GetDebugSqlQuery(string query, List<SqlParameter> listParams = null)
        {
            try
            {
                string StrParams = "";
                if (listParams != null && listParams.Count > 0)
                {
                    StrParams = "DECLARE ";
                    foreach (var p in listParams)
                    {
                        StrParams += p.ParameterName + " ";
                        if (p.SqlDbType == SqlDbType.NVarChar)
                        {
                            string _size = p.Size > 0 ? "(" + p.Size + ")" : "(MAX)";
                            if (p.Value == (object)DBNull.Value || p.Value == null)
                            {
                                StrParams += " NVARCHAR" + _size + " = NULL,\r\n";
                            }
                            else
                            {
                                StrParams += " NVARCHAR" + _size + " = N'" + p.Value.ToString() + "',\r\n";
                            }
                        }
                        else if (p.SqlDbType == SqlDbType.VarChar)
                        {
                            string _size = p.Size > 0 ? "(" + p.Size + ")" : "(MAX)";
                            if (p.Value == (object)DBNull.Value || p.Value == null)
                            {
                                StrParams += " VARCHAR" + _size + " = NULL,\r\n";
                            }
                            else
                            {
                                StrParams += "VARCHAR" + _size + " = '" + p.Value.ToString() + "',\r\n";
                            }
                        }
                        else if (p.SqlDbType == SqlDbType.DateTime || p.SqlDbType == SqlDbType.DateTime2)
                        {
                            if (p.Value == (object)DBNull.Value || p.Value == null)
                            {
                                StrParams += (p.SqlDbType == SqlDbType.DateTime2 ? " DATETIME2" : " DATETIME") + " = NULL,\r\n";
                            }
                            else
                            {
                                if (String.IsNullOrEmpty(p.Value.ToString()))
                                {
                                    StrParams += (p.SqlDbType == SqlDbType.DateTime2 ? " DATETIME2" : " DATETIME") + " = NULL,\r\n";
                                }
                                else
                                {
                                    StrParams += (p.SqlDbType == SqlDbType.DateTime2 ? " DATETIME2" : " DATETIME") + " = '" + Convert.ToDateTime(p.Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss.fffff") + "',\r\n";
                                }
                            }
                        }
                        else if (p.SqlDbType == SqlDbType.Date)
                        {
                            if (p.Value == (object)DBNull.Value || p.Value == null)
                            {
                                StrParams += " DATE = NULL,\r\n";
                            }
                            else
                            {
                                if (String.IsNullOrEmpty(p.Value.ToString()))
                                {
                                    StrParams += " DATE = NULL,\r\n";
                                }
                                else
                                {
                                    StrParams += " DATE = '" + Convert.ToDateTime(p.Value.ToString()).ToString("yyyy-MM-dd") + "',\r\n";
                                }
                            }
                        }
                        else if (p.SqlDbType == SqlDbType.Int)
                        {
                            if (p.Value == (object)DBNull.Value || p.Value == null)
                            {
                                StrParams += " INT = NULL,\r\n";
                            }
                            else
                            {
                                StrParams += " INT = " + p.Value.ToString() + ",\r\n";
                            }
                        }
                        else if (p.SqlDbType == SqlDbType.Float)
                        {
                            if (p.Value == (object)DBNull.Value || p.Value == null)
                            {
                                StrParams += " FLOAT = NULL,\r\n";
                            }
                            else
                            {
                                StrParams += " FLOAT = " + p.Value.ToString() + ",\r\n";
                            }
                        }
                        else if (p.SqlDbType == SqlDbType.BigInt)
                        {
                            if (p.Value == (object)DBNull.Value || p.Value == null)
                            {
                                StrParams += " BIGINT = NULL,\r\n";
                            }
                            else
                            {
                                StrParams += " BIGINT = " + p.Value.ToString() + ",\r\n";
                            }
                        }
                        else if (p.SqlDbType == SqlDbType.Bit)
                        {
                            if (p.Value == (object)DBNull.Value || p.Value == null)
                            {
                                StrParams += " BIT = NULL,\r\n";
                            }
                            else
                            {
                                StrParams += " BIT = " + ((bool)p.Value ? "1" : "0") + ",\r\n";
                            }
                        }
                    }

                    StrParams = StrParams.Substring(0, StrParams.LastIndexOf(",")) + ";\r\n";
                }
                return StrParams + "" + query;
            }
            catch
            {
                return query;
            }
        }
    }
}
