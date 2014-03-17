using ZuluTradeRestApi.Common;

namespace ZuluTradeRestApi.Command.CloseMarket
{
    public class JsonCloseTradeResult : JsonTradeResult
    {
        //public bool success { get; set; }
        //public string uniqueId { get; set; }
        //public string brokerTicket { get; set; }
        //public string openUtcTimestamp { get; set; }
        //public string currencyName { get; set; }
        //public bool buy { get; set; }
        //public double lots { get; set; }
        //public double entryrate { get; set; }
        //public double stopValue { get; set; }
        //public double limitValue { get; set; }
        //public int errorCode { get; set; }
        //public string errorMessage { get; set; }
        //public string dateOpenedAsString { get; set; }

        public string dateClosed { get; set; }
        public string closeUtcTimestamp { get; set; }
        public double priceOpen { get; set; }
        public double priceClosed { get; set; }
        public double grossPnl { get; set; }
        public double commission { get; set; }
        public double interest { get; set; }
        public double netPnl { get; set; }

//       JSON Response
//{
//         "success":    true,
//         "uniqueId":    "1378728350223",
//         "brokerTicket":    "3031379425737380",
//         "currencyName":    "EUR/USD",
//         "buy":    true,
//         "lots":    1,
//         "dateOpen":    "2013-09-23 08:51:02",
//         "openUtcTimestamp":    1379926262000,
//         "dateClosed":    "2013-09-23 08:53:58",
//         "closeUtcTimestamp":    1379926438000,
//         "priceOpen":    1.35201,
//         "priceClosed":    1.35185,
//         "grossPnl":    -16,
//         "commission":    0,
//         "interest":    0,
//         "netPnl":    -16,
//         "errorCode":    0,
//         "errorMessage":    null
//}
    }
}