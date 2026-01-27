using Wolverine;
using Wolverine.Http;
using WolverineTest.Modules.Product.Actions;

namespace WolverineTest.Modules.Product;

public class ProductEndpoints
{
    [WolverineGet("products")]
    public object Get(GetProduct action, IMessageBus bus)
    {
        return bus.InvokeAsync<int>(action).Result;
    }
}