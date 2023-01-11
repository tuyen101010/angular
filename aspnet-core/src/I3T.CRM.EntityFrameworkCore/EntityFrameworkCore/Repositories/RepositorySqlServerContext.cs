using I3T.CRM.Common.Global;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace CRM.EntityFrameworkCore.Repositories
{
    public class RepositorySqlServerContext : IRepositorySqlServerContext
    {
        private string _ConnectionString = GlobalVariables.MsSqlConnectionString;

        public void SetConnection(string connectionString)
        {
            _ConnectionString = connectionString;
        }
        public async Task<DataTable> GetListObject(string SQL, CommandType cmdType = CommandType.Text, List<SqlParameter> parameters = null, Dictionary<string, object> tableParams = null)
        {
            DateTime _StartTime = DateTime.Now;
            bool _IsSuccess = false;
            string _Exception = null;

            DataTable dataTable = new DataTable();

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = _ConnectionString;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        sqlcom.Parameters.Add(parameter);
                    }
                }

                if (tableParams != null)
                {
                    foreach (KeyValuePair<string, object> parameter in tableParams)
                    {
                        sqlcom.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                DbDataReader dataReader = await sqlcom.ExecuteReaderAsync();
                dataTable.Load(dataReader);

                if (parameters != null || tableParams != null)
                {
                    sqlcom.Parameters.Clear();
                }

                _IsSuccess = true;
            }
            catch (Exception e)
            {
                if (GlobalVariables.SQL_WRITE_LOG)
                {
                    _Exception = Newtonsoft.Json.JsonConvert.SerializeObject(e);
                }
            }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            WriteLog(_StartTime, _IsSuccess, SQL, parameters, _Exception);

            return dataTable;
        }

        public async Task<bool?> GetBooleanElement(string SQL, CommandType cmdType = CommandType.Text, List<SqlParameter> parameters = null)
        {
            DateTime _StartTime = DateTime.Now;
            bool _IsSuccess = false;
            string _Exception = null;

            bool? _value = null;

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = _ConnectionString;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        sqlcom.Parameters.Add(parameter);
                    }
                }

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                var result = await sqlcom.ExecuteScalarAsync();

                if (parameters != null)
                {
                    sqlcom.Parameters.Clear();
                }

                if (result != null)
                {
                    _value = (bool)result;
                }

                _IsSuccess = true;
            }
            catch (Exception e)
            {
                if (GlobalVariables.SQL_WRITE_LOG)
                {
                    _Exception = Newtonsoft.Json.JsonConvert.SerializeObject(e);
                }
            }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            WriteLog(_StartTime, _IsSuccess, SQL, parameters, _Exception);

            return _value;
        }

        public async Task<double?> GetDoubleElement(string SQL, CommandType cmdType = CommandType.Text, List<SqlParameter> parameters = null)
        {
            DateTime _StartTime = DateTime.Now;
            bool _IsSuccess = false;
            string _Exception = null;

            double? _value = null;

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = _ConnectionString;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        sqlcom.Parameters.Add(parameter);
                    }
                }

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                var result = await sqlcom.ExecuteScalarAsync();

                if (parameters != null)
                {
                    sqlcom.Parameters.Clear();
                }

                if (result != null)
                {
                    _value = (double)result;
                }

                _IsSuccess = true;
            }
            catch (Exception e)
            {
                if (GlobalVariables.SQL_WRITE_LOG)
                {
                    _Exception = Newtonsoft.Json.JsonConvert.SerializeObject(e);
                }
            }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            WriteLog(_StartTime, _IsSuccess, SQL, parameters, _Exception);

            return _value;
        }

        public async Task<int?> GetIntElement(string SQL, CommandType cmdType = CommandType.Text, List<SqlParameter> parameters = null)
        {
            DateTime _StartTime = DateTime.Now;
            bool _IsSuccess = false;
            string _Exception = null;

            int? _value = null;

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = _ConnectionString;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        sqlcom.Parameters.Add(parameter);
                    }
                }

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                var result = await sqlcom.ExecuteScalarAsync();

                if (parameters != null)
                {
                    sqlcom.Parameters.Clear();
                }

                if (result != null)
                {
                    try { _value = Convert.ToInt32(result); } catch { };
                }
                _IsSuccess = true;
            }
            catch (Exception e)
            {
                if (GlobalVariables.SQL_WRITE_LOG)
                {
                    _Exception = Newtonsoft.Json.JsonConvert.SerializeObject(e);
                }
            }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            WriteLog(_StartTime, _IsSuccess, SQL, parameters, _Exception);

            return _value;
        }

        public async Task<long?> GetLongElement(string SQL, CommandType cmdType = CommandType.Text, List<SqlParameter> parameters = null)
        {
            DateTime _StartTime = DateTime.Now;
            bool _IsSuccess = false;
            string _Exception = null;

            long? _value = null;

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = _ConnectionString;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;

            try
            {
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        sqlcom.Parameters.Add(parameter);
                    }
                }

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                var result = await sqlcom.ExecuteScalarAsync();

                if (parameters != null)
                {
                    sqlcom.Parameters.Clear();
                }

                if (result != null)
                {
                    try { _value = Convert.ToInt64(result); } catch { };
                }

                _IsSuccess = true;
            }
            catch (Exception e)
            {
                if (GlobalVariables.SQL_WRITE_LOG)
                {
                    _Exception = Newtonsoft.Json.JsonConvert.SerializeObject(e);
                }
            }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            WriteLog(_StartTime, _IsSuccess, SQL, parameters, _Exception);

            return _value;
        }

        public async Task<string> GetStringElement(string SQL, CommandType cmdType = CommandType.Text, List<SqlParameter> parameters = null)
        {
            DateTime _StartTime = DateTime.Now;
            bool _IsSuccess = false;
            string _Exception = null;

            string _value = null;

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = _ConnectionString;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        sqlcom.Parameters.Add(parameter);
                    }
                }

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                var result = await sqlcom.ExecuteScalarAsync();

                if (parameters != null)
                {
                    sqlcom.Parameters.Clear();
                }

                if (result != null)
                {
                    _value = result.ToString();
                }

                _IsSuccess = true;
            }
            catch (Exception e)
            {
                if (GlobalVariables.SQL_WRITE_LOG)
                {
                    _Exception = Newtonsoft.Json.JsonConvert.SerializeObject(e);
                }
            }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            WriteLog(_StartTime, _IsSuccess, SQL, parameters, _Exception);

            return _value;
        }

        public async Task<bool> ExecQuery(string SQL, CommandType cmdType = CommandType.Text, List<SqlParameter> parameters = null, Dictionary<string, object> tableParams = null)
        {
            DateTime _StartTime = DateTime.Now;
            bool _IsSuccess = false;
            string _Exception = null;

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = _ConnectionString;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        sqlcom.Parameters.Add(parameter);
                    }
                }

                if (tableParams != null)
                {
                    foreach (KeyValuePair<string, object> parameter in tableParams)
                    {
                        sqlcom.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                var result = await sqlcom.ExecuteNonQueryAsync();

                if (parameters != null || tableParams != null)
                {
                    sqlcom.Parameters.Clear();
                }

                _IsSuccess = true;
            }
            catch (Exception e)
            {
                if (GlobalVariables.SQL_WRITE_LOG)
                {
                    _Exception = Newtonsoft.Json.JsonConvert.SerializeObject(e);
                }
            }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            WriteLog(_StartTime, _IsSuccess, SQL, parameters, _Exception);

            return _IsSuccess;
        }

        public async Task<RDC_ObjectAndValue> GetListObjectAndValue(string SQL, CommandType cmdType = CommandType.Text, List<SqlParameter> parameters = null)
        {
            DateTime _StartTime = DateTime.Now;
            bool _IsSuccess = false;
            string _Exception = null;

            RDC_ObjectAndValue output = new RDC_ObjectAndValue();

            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = _ConnectionString;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (SqlParameter parameter in parameters)
                    {
                        sqlcom.Parameters.Add(parameter);
                    }
                }

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlcom;

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (parameters != null)
                {
                    sqlcom.Parameters.Clear();
                }

                if (connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }

                _IsSuccess = true;

                if (ds.Tables.Count == 0)
                {
                    WriteLog(_StartTime, _IsSuccess, SQL, parameters);

                    return output;
                }

                if (ds.Tables.Count == 1)
                {
                    output.dataTable = ds.Tables[0];

                    WriteLog(_StartTime, _IsSuccess, SQL, parameters);

                    return output;
                }

                DataTable dataTable1 = ds.Tables[0];
                DataTable dataTable2 = ds.Tables[1];

                output.dataTable = dataTable1;
                if (dataTable2.Rows.Count == 1 && dataTable2.Columns.Count == 1)
                {
                    try
                    {
                        output.value = Convert.ToInt32(dataTable2.Rows[0][0]);
                    }
                    catch { }

                    WriteLog(_StartTime, _IsSuccess, SQL, parameters);

                    return output;
                }

                if (dataTable1.Rows.Count == 1 && dataTable1.Columns.Count == 1)
                {
                    output.dataTable = dataTable2;
                    try
                    {
                        output.value = Convert.ToInt32(dataTable1.Rows[0][0]);
                    }
                    catch { }

                    WriteLog(_StartTime, _IsSuccess, SQL, parameters);

                    return output;
                }
            }
            catch (Exception e)
            {
                if (GlobalVariables.SQL_WRITE_LOG)
                {
                    _Exception = Newtonsoft.Json.JsonConvert.SerializeObject(e);
                }
            }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            WriteLog(_StartTime, _IsSuccess, SQL, parameters, _Exception);

            return await Task.FromResult(output);
        }

        private void WriteLog(DateTime _StartTime, bool _IsSuccess, string query, List<SqlParameter> listParams = null, string _Exception = null)
        {
            if (!GlobalVariables.SQL_WRITE_LOG)
            {
                return;
            }

            if (GlobalVariables.SQL_WRITE_LOG_ONLY_FALSE && _IsSuccess)
            {
                return;
            }

            DateTime _EndTime = DateTime.Now;
            string sql = GlobalLogs.GetDebugSqlQuery(query, listParams);
            int _minute = _EndTime.Minute / 10;
            int keyLogCache = (_EndTime.Hour * 10) + _minute;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(String.Format("TimeRunning: {0}", (_EndTime - _StartTime).TotalMilliseconds));
            sb.AppendLine(String.Format("Status: {0}", _IsSuccess));
            sb.AppendLine(String.Format("SQL: {0}", sql));
            if (!String.IsNullOrEmpty(_Exception))
            {
                sb.AppendLine(String.Format("Exception: {0}", _Exception));
            }


            string _folder = "LogsSql";
            string _todayFolder = _EndTime.ToString("yyyyMMdd");
            string _subFolder = System.IO.Path.Combine(_folder, _todayFolder);

            try
            {
                if (!System.IO.Directory.Exists(_folder))
                {
                    System.IO.Directory.CreateDirectory(_folder);
                }
            }
            catch { }
            try
            {
                if (!System.IO.Directory.Exists(_subFolder))
                {
                    System.IO.Directory.CreateDirectory(_subFolder);
                }
            }
            catch { }

            string _fileName = String.Format("{0}.txt", keyLogCache);

            try
            {
                string filePath = System.IO.Path.Combine(_subFolder, _fileName);

                System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, true);

                sw.WriteLine(sb.ToString());

                sw.Flush();
                sw.Close();
            }
            catch
            {
                CacheLogs.sbLogSql[keyLogCache].Add(sb.ToString());
            }
        }
    }

    public class RDC_ObjectAndValue
    {
        public int? value { set; get; }
        public DataTable dataTable { set; get; }
    }
}
