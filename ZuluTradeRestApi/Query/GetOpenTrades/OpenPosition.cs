namespace ZuluTradeRestApi.Query.GetOpenTrades
{
    public class OpenPosition
    {
        public bool Success { get; set; }
        public string UniqueId { get; set; }
        public string BrokerTicket { get; set; }
        public string CurrencyName { get; set; }
        public bool Buy { get; set; }
        public double Lots { get; set; }
        public double EntryRate { get; set; }
        public double StopValue { get; set; }
        public double LimitValue { get; set; }

        public string OpenUtcTimestamp { get; set; }

        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string DateOpenedAsString { get; set; }
    }
}