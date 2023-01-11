namespace I3T.CRM.Configuration
{
    public interface IAppConfigurationWriter
    {
        void Write(string key, string value);
    }
}
