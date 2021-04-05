using System.Threading.Tasks;

namespace Pipe.Net.Test.Pipeline
{
    public class CheckoutNode : Node<OrderData>
    {
        public override Task InvokeAsync(OrderData data)
        {
            data.State = nameof(CheckoutNode);
            return Task.CompletedTask;
        }
    }
}