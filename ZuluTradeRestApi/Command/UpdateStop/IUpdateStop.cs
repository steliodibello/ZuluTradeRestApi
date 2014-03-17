using TradingBackBone.Interfaces;

namespace ZuluTradeRestApi.Command.UpdateStop
{
    public interface IUpdateStop : ICommand<UpdateStopRequest, UpdateStopResponse>
    {
    }
}