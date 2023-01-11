using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace I3T.CRM.Web.Authentication.JwtBearer
{
    public class AsyncJwtBearerOptions : JwtBearerOptions
    {
        public readonly List<IAsyncSecurityTokenValidator> AsyncSecurityTokenValidators;
        
        private readonly CRMAsyncJwtSecurityTokenHandler _defaultAsyncHandler = new CRMAsyncJwtSecurityTokenHandler();

        public AsyncJwtBearerOptions()
        {
            AsyncSecurityTokenValidators = new List<IAsyncSecurityTokenValidator>() {_defaultAsyncHandler};
        }
    }

}
