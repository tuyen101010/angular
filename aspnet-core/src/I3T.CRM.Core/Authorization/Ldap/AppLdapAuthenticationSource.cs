using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using I3T.CRM.Authorization.Users;
using I3T.CRM.MultiTenancy;

namespace I3T.CRM.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}