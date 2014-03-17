namespace ZuluTradeRestApi.Common
{
   public class TradeRequestBase
    {
        public string CurrencyName { get; set; }
        public double Lots { get; set; }
        public bool Buy { get; set; }
        public double RequestPrice { get; set; }
        public string UniqueId { get; set; }
    }
}
