using Abp.Domain.Repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace CRM.EntityFrameworkCore.Repositories
{
    public interface IRepositoryMySQLContext : IRepository
    {
        void SetConnection(string connectionString);

        Task<DataTable> GetListObject(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null, Dictionary<string, object> tableParams = null);

        Task<bool?> GetBooleanElement(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null);

        Task<double?> GetDoubleElement(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null);

        Task<int?> GetIntElement(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null);

        Task<long?> GetLongElement(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null);

        Task<string> GetStringElement(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null);

        Task<bool> ExecQuery(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null, Dictionary<string, object> tableParams = null);

        Task<RDC_ObjectAndValue> GetListObjectAndValue(string SQL, CommandType cmdType = CommandType.Text, List<MySqlParameter> parameters = null);
    }
}
