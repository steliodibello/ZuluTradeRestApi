using System;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Common;

namespace ZuluTradeRestApi.Command.OpenPending
{
    public class OpenPending : IOpenPending
    {
        private readonly ILogWriter _logger;

        public OpenPending(ILogWriter logger)
        {
            _logger = logger;
        }

        public OpenPendingResponse Invoke(OpenPendingRequest request)
        {
            try
            {
                string url = Config.BaseUrl + Constants.Url.OpenPending;

                string urlWithParams = string.Format(Constants.UrlTemplates.QsTemplate, request.CurrencyName, request.Lots, request.Buy, request.RequestPrice, request.UniqueId);
                url += urlWithParams;
               
                JsonTradeResult result = TradeCommands.Execute(url);

                return new OpenPendingResponse {Result = result};
            }
            catch (Exception ex)
            {
                _logger.Error("error in OpenTrade", ex);
                throw;
            }
        }
    }
}