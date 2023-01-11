using I3T.CRM.Common.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRM.EntityFrameworkCore.Repositories
{
    public class RepositoryMySQLContext : IRepositoryMySQLContext
    {
        private string _ConnectionString = GlobalVariables.MySqlConnectionString;

        public void SetConnection(string connectionString)
        {
            _ConnectionString = connectionString;
        }

        public async Task<DataTable> GetListObject(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null, Dictionary<string, object> tableParams = null)
        {
            DataTable dataTable = new DataTable();

            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = _ConnectionString;
            MySqlCommand sqlcom = new MySqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (MySqlParameter parameter in parameters)
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
            }
            catch { }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            return dataTable;
        }

        public async Task<bool?> GetBooleanElement(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null)
        {
            bool? _value = null;

            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = _ConnectionString;
            MySqlCommand sqlcom = new MySqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (MySqlParameter parameter in parameters)
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
                    try { _value = Convert.ToBoolean(result); } catch { };
                }
            }
            catch { }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            return _value;
        }

        public async Task<double?> GetDoubleElement(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null)
        {
            double? _value = null;

            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = _ConnectionString;
            MySqlCommand sqlcom = new MySqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (MySqlParameter parameter in parameters)
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
                    try { _value = Convert.ToDouble(result); } catch { };
                }
            }
            catch { }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            return _value;
        }

        public async Task<int?> GetIntElement(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null)
        {
            int? _value = null;

            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = _ConnectionString;
            MySqlCommand sqlcom = new MySqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (MySqlParameter parameter in parameters)
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
            }
            catch { }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            return _value;
        }

        public async Task<long?> GetLongElement(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null)
        {
            long? _value = null;

            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = _ConnectionString;
            MySqlCommand sqlcom = new MySqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (MySqlParameter parameter in parameters)
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
            }
            catch { }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            return _value;
        }

        public async Task<string> GetStringElement(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null)
        {
            string _value = null;

            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = _ConnectionString;
            MySqlCommand sqlcom = new MySqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (MySqlParameter parameter in parameters)
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
            }
            catch { }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            return _value;
        }

        public async Task<bool> ExecQuery(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null, Dictionary<string, object> tableParams = null)
        {
            bool _value = false;

            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = _ConnectionString;
            MySqlCommand sqlcom = new MySqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (MySqlParameter parameter in parameters)
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

                _value = true;
            }
            catch { }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            return _value;
        }

        public async Task<RDC_ObjectAndValue> GetListObjectAndValue(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null)
        {
            RDC_ObjectAndValue output = new RDC_ObjectAndValue();

            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = _ConnectionString;
            MySqlCommand sqlcom = new MySqlCommand();
            sqlcom.CommandText = SQL;
            sqlcom.CommandType = cmdType;
            sqlcom.Connection = connect;
            sqlcom.CommandTimeout = 3600;
            try
            {
                if (parameters != null)
                {
                    foreach (MySqlParameter parameter in parameters)
                    {
                        sqlcom.Parameters.Add(parameter);
                    }
                }

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter();
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

                if (ds.Tables.Count == 0)
                {
                    return output;
                }

                if (ds.Tables.Count == 1)
                {
                    output.dataTable = ds.Tables[0];
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

                    return output;
                }
            }
            catch { }

            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

            return await Task.FromResult(output);
        }
    }
}
