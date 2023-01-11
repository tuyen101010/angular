using CRM.EntityFrameworkCore.Repositories;
using I3T.CRM.Common;
using I3T.CRM.Common.Caches;
using I3T.CRM.Common.Dtos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3T.CRM.SqlObject
{
    public class SysTenantCustomPages
    {
        public static async Task LoadToCache(IRepositorySqlServerContext _MsSqlServer)
        {
            string sqlQuery = @"SELECT [Id], [TenantId], [PageIndex], [PageMenuKey], [PageTitleKey] FROM [SysTenantCustomPages] WITH (NOLOCK);";
            DataTable dt = await _MsSqlServer.GetListObject(sqlQuery);
            TenantCustomPagesCache.LoadToCache(dt);
        }

        public static async Task<bool> UpdateAllItem(IRepositorySqlServerContext _MsSqlServer, int TenantId, long? LoginUserId, List<TenantCustomPageItemDto> Items)
        {
            List<TenantCustomPageItemDto> oldItems = TenantCustomPagesCache.GetList(TenantId);
            List<int> UpdateIds = new List<int>();
            if (Items != null && Items.Count > 0)
            {
                foreach (TenantCustomPageItemDto item in Items)
                {
                    if (item.Id.HasValue)
                    {
                        UpdateIds.Add(item.Id.Value);
                    }

                    await AddOrUpdate(_MsSqlServer, TenantId, LoginUserId, item);
                }
            }

            foreach (TenantCustomPageItemDto oldItem in oldItems)
            {
                if (oldItem.Id.HasValue && !UpdateIds.Contains(oldItem.Id.Value))
                {
                    await Remove(_MsSqlServer, TenantId, oldItem.Id.Value);
                }
            }

            return true;
        }

        public static async Task<bool> AddOrUpdate(IRepositorySqlServerContext _MsSqlServer, int TenantId, long? LoginUserId, TenantCustomPageItemDto Item)
        {
            List<SqlParameter> listParams = new List<SqlParameter>();
            listParams.Add(new SqlParameter { ParameterName = "@TenantId", SqlDbType = SqlDbType.Int, Value = TenantId });
            listParams.Add(new SqlParameter { ParameterName = "@CustomPageId", SqlDbType = SqlDbType.Int, IsNullable = true, Value = Item.Id ?? (object)DBNull.Value });
            listParams.Add(new SqlParameter { ParameterName = "@CreatorUserId", SqlDbType = SqlDbType.BigInt, IsNullable = true, Value = LoginUserId ?? (object)DBNull.Value });
            listParams.Add(new SqlParameter { ParameterName = "@PageIndex", SqlDbType = SqlDbType.Int, Value = Item.PageIndex });
            listParams.Add(new SqlParameter { ParameterName = "@PageMenuKey", SqlDbType = SqlDbType.NVarChar, Size = 256, Value = Item.PageMenuKey });
            listParams.Add(new SqlParameter { ParameterName = "@PageTitleKey", SqlDbType = SqlDbType.NVarChar, Size = 256, IsNullable = true, Value = Item.PageTitleKey ?? (object)DBNull.Value });

            string sqlAdd = @"
                INSERT INTO [SysTenantCustomPages] (
                    [TenantId], [CreatorUserId], [PageIndex], [PageMenuKey], [PageTitleKey]
                ) VALUES (
                    @TenantId, @CreatorUserId, @PageIndex, @PageMenuKey, @PageTitleKey
                );

                DECLARE @newId INT; SET @newId = SCOPE_IDENTITY();
                SELECT @newId;
            ";

            string sqlUpdate = @"
                UPDATE [SysTenantCustomPages] SET
                    [PageIndex] = @PageIndex, 
                    [PageMenuKey] = @PageMenuKey, 
                    [PageTitleKey] = @PageTitleKey
                WHERE
                    [Id] = @CustomPageId;
            ";

            if (!Item.Id.HasValue)
            {
                int? newId = await _MsSqlServer.GetIntElement(sqlAdd, CommandType.Text, listParams);
                if (newId.HasValue && newId.Value > 0)
                {
                    Item.Id = newId.Value;
                    TenantCustomPagesCache.AddOrUpdate(TenantId, Item);
                    return true;
                }
            }
            else
            {
                bool ck = await _MsSqlServer.ExecQuery(sqlUpdate, CommandType.Text, listParams);
                if (ck)
                {
                    TenantCustomPagesCache.AddOrUpdate(TenantId, Item);
                }
                return ck;
            }

            return false;
        }

        public static async Task<bool> Remove(IRepositorySqlServerContext _MsSqlServer, int TenantId, int ItemId)
        {
            string sqlQuery = @"DELETE FROM [SysTenantCustomPages] WHERE [Id] = {0};";
            sqlQuery = String.Format(sqlQuery, ItemId);

            bool ck = await _MsSqlServer.ExecQuery(sqlQuery);
            if (ck)
            {
                TenantCustomPagesCache.Remove(TenantId, ItemId);
            }
            return ck;
        }
    }
}
