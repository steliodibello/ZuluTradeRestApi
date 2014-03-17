using System;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Common;

namespace ZuluTradeRestApi.Command.UpdateEntry
{
    public class UpdateEntry : IUpdateEntry
    {
        private readonly ILogWriter _logger;

        public UpdateEntry(ILogWriter logger)
        {
            _logger = logger;
        }

        public UpdateEntryResponse Invoke(UpdateEntryRequest request)
        {
            try
            {
                string url = Config.BaseUrl + Constants.Url.UpdateEntry;

                string urlWithParams = string.Format(Constants.UrlTemplates.UpdateEntry, request.CurrencyName, request.Lots, request.Buy, request.RequestPrice, request.UniqueId, request.EntryValue);
                url += urlWithParams;
                JsonTradeResult result = TradeCommands.Execute(url);

                return new UpdateEntryResponse {Result = result};
            }
            catch (Exception ex)
            {
                _logger.Error("error in UpdateEntry", ex);
                throw;
            }
        }
    }
}