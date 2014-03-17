using NUnit.Framework;
using TradingBackBone.Logging;
using ZuluTradeRestApi.Command.OpenMarket;
using ZuluTradeRestApi.Query.GetOpenTrades;

namespace TestZulutradeApi
{
    [TestFixture]
    public class OpenMarketTest
    {
        //  [Test]
        public void TestOpen()
        {
            var openCmd = new OpenMarket(new LogWriter());
            OpenMarketResponse trResponse = openCmd.Invoke(new OpenMarketRequest {CurrencyName = "EUR/JPY", Buy = false, Lots = 1, RequestPrice = 137, UniqueId = "12345"});


            var openTrades = new GetOpenTrades();
            GetOpenTradesResponse openTradesResp = openTrades.Invoke(new GetOpenTradesRequest());
        }
    }
}