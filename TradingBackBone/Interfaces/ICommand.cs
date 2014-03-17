 
namespace TradingBackBone.Interfaces
{
    public interface ICommand<in TRequest, out TResponse> : IInvoker<TRequest, TResponse>
    {
    }
}