using Abp.Application.Services.Dto;

namespace I3T.CRM.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}