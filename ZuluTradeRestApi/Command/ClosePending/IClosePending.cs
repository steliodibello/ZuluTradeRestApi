using TradingBackBone.Interfaces;

namespace ZuluTradeRestApi.Command.ClosePending
{
    public interface IClosePending : ICommand<ClosePendingRequest, ClosePendingResponse>
    {
    }
}