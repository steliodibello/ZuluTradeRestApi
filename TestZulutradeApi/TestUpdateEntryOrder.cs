using NUnit.Framework;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Command.UpdateEntry;
using ZuluTradeRestApi.Query.GetOpenTrades;

namespace TestZulutradeApi
{
    [TestFixture]
   public class TestUpdateEntryOrder
    {
        // [Test]
        public void UpdateEntryForPendingOrder()
        {
            var openCmd = new UpdateEntry(new LogWriter());
            var trResponse = openCmd.Invoke(new UpdateEntryRequest { CurrencyName = "USD/JPY", Buy = false, Lots = 1, RequestPrice = 100, UniqueId = "12347", EntryValue = 98});


            var openTrades = new GetOpenTrades();
            GetOpenTradesResponse openTradesResp = openTrades.Invoke(new GetOpenTradesRequest());
        }
    }
}
