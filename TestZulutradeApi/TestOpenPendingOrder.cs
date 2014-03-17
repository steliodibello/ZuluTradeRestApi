using NUnit.Framework;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Command.OpenPending;
using ZuluTradeRestApi.Query.GetOpenTrades;

namespace TestZulutradeApi
{
    [TestFixture]
   public class TestOpenPendingOrder
    {
       // [Test]
        public void CreatePendingOrder()
        {
            var openCmd = new OpenPending(new LogWriter());
            var trResponse = openCmd.Invoke(new OpenPendingRequest { CurrencyName = "USD/JPY", Buy = false, Lots = 1, RequestPrice = 100, UniqueId = "12347" });


            var openTrades = new GetOpenTrades();
            GetOpenTradesResponse openTradesResp = openTrades.Invoke(new GetOpenTradesRequest());
        }
    }
}
