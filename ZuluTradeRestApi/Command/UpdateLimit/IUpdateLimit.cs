using TradingBackBone.Interfaces;

namespace ZuluTradeRestApi.Command.UpdateLimit
{
    public interface IUpdateLimit : ICommand<UpdateLimitRequest, UpdateLimitResponse>
    {
    }
}