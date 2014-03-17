using ZuluTradeRestApi.Common;

namespace ZuluTradeRestApi.Command.UpdateEntry
{
    public class UpdateEntryRequest : TradeRequestBase
    {
        public double EntryValue { get; set; }
    }
}