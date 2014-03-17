using ZuluTradeRestApi.Common;

namespace ZuluTradeRestApi.Command.UpdateLimit
{
    public class UpdateLimitRequest : TradeRequestBase
    {
        public double LimitValue { get; set; }
    }
}