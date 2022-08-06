using System.Configuration;


    public static class ConnectionStringHelper
    {
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }

