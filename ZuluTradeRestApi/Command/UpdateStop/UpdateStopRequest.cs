using ZuluTradeRestApi.Common;

namespace ZuluTradeRestApi.Command.UpdateStop
{
    public class UpdateStopRequest : TradeRequestBase
    {
        public double StopValue { get; set; }
    }
}