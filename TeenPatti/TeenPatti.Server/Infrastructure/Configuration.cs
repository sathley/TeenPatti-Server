using System.Configuration;

namespace TeenPatti.Server
{
    public static class Configuration
    {
        private static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static long ServerId
        {
            get { return long.Parse(GetSetting("serverid")); }
        }

        public static long DataCentreId
        {
            get { return long.Parse(GetSetting("datacentreid")); }
        }
    }
}