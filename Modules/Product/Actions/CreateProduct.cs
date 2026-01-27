namespace WolverineTest.Modules.Product.Actions;

public record GetProduct();

public class GetProductHandler
{
    public Task<int> Handle(GetProduct product)
    {
        return Task.FromResult(1);
    }
}
