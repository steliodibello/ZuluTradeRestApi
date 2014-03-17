namespace TradingBackBone.Interfaces
{
    public interface IQuery<in TRequest, out TResponse> : IInvoker<TRequest, TResponse>
    {
    }
}