using System.Net.Http;

namespace ZuluTradeRestApi.Common
{
    public class TradeCommands
    {
        public static JsonTradeResult Execute(string url)
        {
            using (HttpClient client = WebApi.GetNewClientWithDefaults())
            {
                HttpResponseMessage result = client.GetAsync(url).Result;

                var tradeRes = result.Content.ReadAsAsync<JsonTradeResult>().Result;
                return tradeRes;
             }
        }
    }
}
