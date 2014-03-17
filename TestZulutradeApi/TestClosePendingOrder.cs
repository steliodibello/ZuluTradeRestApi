using NUnit.Framework;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Command.ClosePending;
using ZuluTradeRestApi.Command.UpdateLimit;
using ZuluTradeRestApi.Command.UpdateStop;
using ZuluTradeRestApi.Query.GetOpenTrades;

namespace TestZulutradeApi
{
    [TestFixture]
   public class TestClosePendingOrder
    {
         [Test]
        public void UpdateStopForPendingOrder()
        {
            var openCmd = new ClosePending(new LogWriter());
            var trResponse = openCmd.Invoke(new ClosePendingRequest { CurrencyName = "USD/JPY", Buy = false, Lots = 1, RequestPrice = 100, UniqueId = "12347"});


            var openTrades = new GetOpenTrades();
            GetOpenTradesResponse openTradesResp = openTrades.Invoke(new GetOpenTradesRequest());
        }
    }
}
