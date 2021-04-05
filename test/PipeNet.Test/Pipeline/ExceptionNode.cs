using System;
using System.Threading.Tasks;

namespace PipeNet.Test.Pipeline
{
    public class ExceptionNode : Node<OrderData>
    {
        public override Task InvokeAsync(OrderData data)
        {
            data.State = nameof(ExceptionNode);
            throw new Exception("100");
        }
    }
}