using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using I3T.CRM.MultiTenancy.HostDashboard.Dto;

namespace I3T.CRM.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}