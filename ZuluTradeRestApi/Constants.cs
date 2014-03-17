namespace ZuluTradeRestApi
{
    public class Constants
    {
        public class Url
        {
            public const string GetOpen = "getOpen";
            public const string OpenMarket = "open/market";
            public const string OpenPending = "open/pending";
            public const string ClosePending = "close/pending";
            public const string CloseMarket = "close/market";
            public const string UpdateStop = "/update/stop";
            public const string UpdateLimit = "/update/limit";
            public const string UpdateEntry = "/update/entry";
        }

        public class UrlTemplates
        {
            public const string QsTemplate = "/?currencyName={0}&lots={1}&buy={2}&requestedPrice={3}&uniqueId={4}";
            //last 3 are not mandatory
            //?currencyName=EUR/USD&buy=true&lots=1.0&uniqueId=1378728350223&requestedPrice=1.4
            //public const string CloseMarket = "/?currencyName={0}&lots={1}&buy={2}&requestedPrice={3}&uniqueId={4}";

            public const string UpdateEntry = "/?currencyName={0}&lots={1}&buy={2}&requestedPrice={3}&uniqueId={4}&entryValue={5}";
            public const string UpdateLimit = "/?currencyName={0}&lots={1}&buy={2}&requestedPrice={3}&uniqueId={4}&limitValue={5}";
            public const string UpdateStop = "/?currencyName={0}&lots={1}&buy={2}&requestedPrice={3}&uniqueId={4}&stopValue={5}";
        }
    }
}