using System;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Common;

namespace ZuluTradeRestApi.Command.UpdateStop
{
    public class UpdateStop : IUpdateStop
    {
        private readonly ILogWriter _logger;

        public UpdateStop(ILogWriter logger)
        {
            _logger = logger;
        }

        public UpdateStopResponse Invoke(UpdateStopRequest request)
        {
            try
            {
                string url = Config.BaseUrl + Constants.Url.UpdateStop;

                string urlWithParams = string.Format(Constants.UrlTemplates.UpdateStop, request.CurrencyName, request.Lots, request.Buy, request.RequestPrice, request.UniqueId, request.StopValue);
                url += urlWithParams;

                var result = TradeCommands.Execute(url);

                return new UpdateStopResponse { Result = result };
             
            }
            catch (Exception ex)
            {
                _logger.Error("error in Update StopValue", ex);
                throw ;
            }

         }
    }
}