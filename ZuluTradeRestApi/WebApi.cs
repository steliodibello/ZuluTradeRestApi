using System;
using System.Net.Http;
using System.Text;

namespace ZuluTradeRestApi
{
    public class WebApi
    {
        public static HttpClient GetNewClientWithDefaults()
        {
            var handler = new HttpClientHandler
                {
                    AllowAutoRedirect = false
                };

            var client = new HttpClient(handler);
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(Config.UserName + ":" + Config.Password)));

            return client;
        }
    }
}