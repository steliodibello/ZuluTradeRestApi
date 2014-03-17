using System;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Common;

namespace ZuluTradeRestApi.Command.UpdateLimit
{
    public class UpdateLimit : IUpdateLimit
    {
        private readonly ILogWriter _logger;

        public UpdateLimit(ILogWriter logger)
        {
            _logger = logger;
        }

        public UpdateLimitResponse Invoke(UpdateLimitRequest request)
        {
            try
            {
                string url = Config.BaseUrl + Constants.Url.UpdateLimit;

                string urlWithParams = string.Format(Constants.UrlTemplates.UpdateLimit, request.CurrencyName, request.Lots, request.Buy, request.RequestPrice, request.UniqueId, request.LimitValue);
                url += urlWithParams;
                var result = TradeCommands.Execute(url);
 
                return new UpdateLimitResponse {Result = result};
            }
            catch (Exception ex)
            {
                _logger.Error("error in Update LimitValue", ex);
                throw;
            }
        }
    }
}