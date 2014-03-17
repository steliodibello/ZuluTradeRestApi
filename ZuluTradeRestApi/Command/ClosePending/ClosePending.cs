using System;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Common;

namespace ZuluTradeRestApi.Command.ClosePending
{
    public class ClosePending : IClosePending
    {
        private readonly ILogWriter _logger;

        public ClosePending(ILogWriter logger)
        {
            _logger = logger;
        }

        public ClosePendingResponse Invoke(ClosePendingRequest request)
        {
            try
            {
                string url = Config.BaseUrl + Constants.Url.ClosePending;

                string urlWithParams = string.Format(Constants.UrlTemplates.QsTemplate, request.CurrencyName, request.Lots, request.Buy, request.RequestPrice, request.UniqueId);
                url += urlWithParams;
                var result = TradeCommands.Execute(url);

                return new ClosePendingResponse {Result = result};
            }
            catch (Exception ex)
            {
                _logger.Error("error in ClosePending", ex);
                throw;
            }
        }
    }
}