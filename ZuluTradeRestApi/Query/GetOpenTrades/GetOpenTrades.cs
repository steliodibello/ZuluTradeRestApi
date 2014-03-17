using System.Net.Http;

namespace ZuluTradeRestApi.Query.GetOpenTrades
{
    public class GetOpenTrades : IGetOpenTrades
    {
        public GetOpenTradesResponse Invoke(GetOpenTradesRequest request)
        {
            string url = Config.BaseUrl + Constants.Url.GetOpen;
            using (HttpClient client = WebApi.GetNewClientWithDefaults())
            {
                HttpResponseMessage result = client.GetAsync(url).Result;

                var tradeRes = result.Content.ReadAsAsync<ZulutradeResponse>().Result;
              
                return new GetOpenTradesResponse {ZuluResult = tradeRes};
            }
        }
    }
}