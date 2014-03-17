using TradingBackBone.Interfaces;

namespace ZuluTradeRestApi.Command.OpenMarket
{
    public interface IOpenMarket : ICommand<OpenMarketRequest, OpenMarketResponse>
    {
    }
}