using I3T.CRM.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Data;

namespace I3T.CRM.Common.Caches
{
    public class TenantCustomPagesCache
    {
        public static Dictionary<int, Dictionary<int, TenantCustomPageItemDto>> allItem;

        public static List<TenantCustomPageItemDto> GetList(int? TenantId)
        {
            if (!TenantId.HasValue || allItem == null || !allItem.ContainsKey(TenantId.Value))
            {
                return new List<TenantCustomPageItemDto>();
            }

            return new List<TenantCustomPageItemDto>(allItem[TenantId.Value].Values);
        }

        public static TenantCustomPageItemDto GetItem(int? TenantId, int id)
        {
            if (!TenantId.HasValue || allItem == null || !allItem.ContainsKey(TenantId.Value))
            {
                return null;
            }

            if (allItem[TenantId.Value].ContainsKey(id))
            {
                return allItem[TenantId.Value][id];
            }

            return null;
        }

        public static void AddOrUpdate(int TenantId, TenantCustomPageItemDto item)
        {
            if (allItem == null)
            {
                allItem = new Dictionary<int, Dictionary<int, TenantCustomPageItemDto>>();
            }

            if (!allItem.ContainsKey(TenantId))
            {
                allItem.Add(TenantId, new Dictionary<int, TenantCustomPageItemDto>());
            }

            if (allItem[TenantId].ContainsKey(item.Id.Value))
            {
                allItem[TenantId][item.Id.Value] = item;
            }
            else
            {
                allItem[TenantId].Add(item.Id.Value, item);
            }
        }

        public static void Remove(int? TenantId, int id)
        {
            if (!TenantId.HasValue || allItem == null || !allItem.ContainsKey(TenantId.Value))
            {
                return;
            }

            if (allItem[TenantId.Value].ContainsKey(id))
            {
                allItem[TenantId.Value].Remove(id);
            }
        }

        public static void LoadToCache(DataTable dt)
        {
            allItem = new Dictionary<int, Dictionary<int, TenantCustomPageItemDto>>();
            if (dt == null || dt.Rows.Count < 1)
            {
                return;
            }

            foreach (DataRow dr in dt.Rows)
            {
                string _TenantId = dr["TenantId"].ToString();
                int TenantId = 0;
                if (!String.IsNullOrEmpty(_TenantId)) { TenantId = Convert.ToInt32(dr["TenantId"]); }

                TenantCustomPageItemDto item = new TenantCustomPageItemDto
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    PageIndex = Convert.ToInt32(dr["PageIndex"]),
                    PageMenuKey = dr["PageMenuKey"].ToString(),
                    PageTitleKey = dr["PageTitleKey"].ToString()
                };

                AddOrUpdate(TenantId, item);
            }
        }
    }
}
