using NUnit.Framework;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Command.UpdateLimit;
using ZuluTradeRestApi.Query.GetOpenTrades;

namespace TestZulutradeApi
{
    [TestFixture]
   public class TestUpdateLimitOrder
    {
        // [Test]
        public void UpdateLimitForPendingOrder()
        {
            var openCmd = new UpdateLimit(new LogWriter());
            var trResponse = openCmd.Invoke(new UpdateLimitRequest { CurrencyName = "USD/JPY", Buy = false, Lots = 1, RequestPrice = 100, UniqueId = "12347", LimitValue = 97 });


            var openTrades = new GetOpenTrades();
            GetOpenTradesResponse openTradesResp = openTrades.Invoke(new GetOpenTradesRequest());
        }
    }
}
