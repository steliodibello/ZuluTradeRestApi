using System.Configuration;

namespace ZuluTradeRestApi
{
   public class Config
    {
        public static string UserName
        {
            get { return ConfigurationManager.AppSettings["ZuluUserName"]; }
        }

        public static string Password
        {
            get { return ConfigurationManager.AppSettings["ZuluPwd"]; }
        }

        public static string BaseUrl
        {
            get { return ConfigurationManager.AppSettings["ZuluServiceUrl"]; }
        }
    }
}
