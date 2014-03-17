using System;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Common;

namespace ZuluTradeRestApi.Command.OpenMarket
{
    public class OpenMarket : IOpenMarket
    {
        private readonly ILogWriter _logger;

        public OpenMarket(ILogWriter logger)
        {
            _logger = logger;
        }

        public OpenMarketResponse Invoke(OpenMarketRequest request)
        {
            try
            {
                string url = Config.BaseUrl + Constants.Url.OpenMarket;

                string urlWithParams = string.Format(Constants.UrlTemplates.QsTemplate, request.CurrencyName, request.Lots, request.Buy, request.RequestPrice, request.UniqueId);
                url += urlWithParams;
                //http://tradingserver.zulutrade.com/open/market/?currencyName=EUR/USD&lots=1.0&buy=true&requestedPrice=1.4&uniqueId=1379926231592 
                JsonTradeResult result = TradeCommands.Execute(url);

                return new OpenMarketResponse {Result = result};
            }
            catch (Exception ex)
            {
                _logger.Error("error in OpenTrade", ex);
                throw;
            }
        }
    }
}