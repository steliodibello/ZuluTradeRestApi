using System.Collections.Generic;

namespace ZuluTradeRestApi.Query.GetOpenTrades
{
    public class ZulutradeResponse
    {
        public List<OpenPosition> OpenPositions { get; set; }
        public List<OpenPosition> OpenOrders { get; set; }
    }
}