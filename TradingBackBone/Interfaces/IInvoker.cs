namespace TradingBackBone.Interfaces
{
    public interface IInvoker<in TRequest, out TResponse>
    {
        TResponse Invoke(TRequest request);
    }
}