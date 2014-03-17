using NUnit.Framework;
using ZuluTradeRestApi.Query.GetOpenTrades;

namespace TestZulutradeApi
{
    [TestFixture]
    public class TestGetOpenTrades
    {
        [Test]
        public void TestOpenTrades()
        {
            var openTrades = new GetOpenTrades();
            GetOpenTradesResponse openTradesResp = openTrades.Invoke(new GetOpenTradesRequest());

            int t = 5;
        }
    }
}