using TradingBackBone.Interfaces;

namespace ZuluTradeRestApi.Command.UpdateEntry
{
    public interface IUpdateEntry : ICommand<UpdateEntryRequest, UpdateEntryResponse>
    {
    }
}