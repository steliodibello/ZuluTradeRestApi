using NUnit.Framework;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Command.UpdateLimit;
using ZuluTradeRestApi.Command.UpdateStop;
using ZuluTradeRestApi.Query.GetOpenTrades;

namespace TestZulutradeApi
{
    [TestFixture]
   public class TestUpdateStopOrder
    {
         [Test]
        public void UpdateStopForPendingOrder()
        {
            var openCmd = new UpdateStop(new LogWriter());
            var trResponse = openCmd.Invoke(new UpdateStopRequest { CurrencyName = "USD/JPY", Buy = false, Lots = 1, RequestPrice = 100, UniqueId = "12347", StopValue = 100 });


            var openTrades = new GetOpenTrades();
            GetOpenTradesResponse openTradesResp = openTrades.Invoke(new GetOpenTradesRequest());
        }
    }
}
