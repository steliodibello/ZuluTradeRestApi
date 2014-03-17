using System;
using System.Net.Http;
using System.Web.Script.Serialization;
using TradingBackBone.Logging;

namespace ZuluTradeRestApi.Command.CloseMarket
{
    public class CloseMarket : ICloseMarket
    {
        private readonly ILogWriter _logger;

        public CloseMarket(ILogWriter logger)
        {
            _logger = logger;
        }

        public CloseMarketResponse Invoke(CloseMarketRequest request)
        {
            try
            {
                string url = Config.BaseUrl + Constants.Url.CloseMarket;

                string urlWithParams = string.Format(Constants.UrlTemplates.QsTemplate, request.CurrencyName, request.Lots, request.Buy, request.RequestPrice, request.UniqueId);
                url += urlWithParams;
                using (HttpClient client = WebApi.GetNewClientWithDefaults())
                {
                    HttpResponseMessage result = client.GetAsync(url).Result;

                    var js = new JavaScriptSerializer();
                    string replacedResponse = result.Content.ReadAsStringAsync().Result;

                    var tradeRes = js.Deserialize<JsonCloseTradeResult>(replacedResponse);

                    return new CloseMarketResponse {Result = tradeRes, WebApiSuccesfull = true};
                }
            }
            catch (Exception ex)
            {
                _logger.Error("error in OpenTrade", ex);
            }

            return new CloseMarketResponse {WebApiSuccesfull = false};
        }
    }
}