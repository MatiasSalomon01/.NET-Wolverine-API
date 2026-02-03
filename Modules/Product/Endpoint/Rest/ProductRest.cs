using Microsoft.AspNetCore.Mvc;
using Wolverine;
using WolverineTest.Modules.Product.Actions;

namespace WolverineTest.Modules.Product.Endpoint.Rest;

public class ProductRest : BaseController
{
    [HttpGet("products")]
    public async Task<IActionResult> Get(CreateProductArgument action)
    {
        var result = await Invoke<CreateProductResult>(action);
        return Ok(result);
    }
}



























public class BaseController : ControllerBase
{
    public async Task<R> Invoke<R>(object message)
    {
        var bus = HttpContext.RequestServices.GetService<IMessageBus>() ?? throw new Exception("Bus no inicializado");
        return await bus.InvokeAsync<R>(message);
    }
}