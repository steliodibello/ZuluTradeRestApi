using TradingBackBone.Interfaces;

namespace ZuluTradeRestApi.Command.CloseMarket
{
    public interface ICloseMarket : ICommand<CloseMarketRequest, CloseMarketResponse>
    {
    }
}