using TradingBackBone.Interfaces;

namespace ZuluTradeRestApi.Command.OpenPending
{
    public interface IOpenPending : ICommand<OpenPendingRequest, OpenPendingResponse>
    {
    }
}