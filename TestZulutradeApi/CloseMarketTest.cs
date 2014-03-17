using NUnit.Framework;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Command.CloseMarket;
using ZuluTradeRestApi.Query.GetOpenTrades;

namespace TestZulutradeApi
{
    [TestFixture]
   public class CloseMarketTest
    {
        //[Test]
        public void CloseTrade()
        {
            var openTrades2 = new GetOpenTrades();
            GetOpenTradesResponse openTradesResp2 = openTrades2.Invoke(new GetOpenTradesRequest());

            var closeCmd = new CloseMarket(new LogWriter());
            CloseMarketResponse trResponse = closeCmd.Invoke(new CloseMarketRequest { CurrencyName = "EUR/JPY", Buy = false, Lots = 1, RequestPrice = 1.35, UniqueId = "12345" });


            var openTrades = new GetOpenTrades();
            GetOpenTradesResponse openTradesResp = openTrades.Invoke(new GetOpenTradesRequest());
        }
    }
}
