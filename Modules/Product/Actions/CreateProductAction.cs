using Wolverine;
using WolverineTest.Modules.Product.Store;

namespace WolverineTest.Modules.Product.Actions;

public record CreateProductArgument(string Name, decimal Amount);

public record CreateProductResult();

public class CreateProductHandler(
    IProductRepository repository,
    IMessageBus bus,
    ILogger<CreateProductHandler> logger) : BaseHandler<CreateProductArgument, CreateProductResult>
{
    public override async Task<CreateProductResult> Handle(CreateProductArgument argument)
    {
        var entity = new ProductEntity(argument.Name, argument.Amount);

        await repository.Add(entity);

        await bus.PublishAsync(new SendProductNotificationArgument());

        return new();
    }

    public override async void After()
    {
        await Task.Delay(5000);
        logger.LogInformation("***** | After | *****");
    }
}




























public abstract class BaseHandler<T, R>
{
    public virtual void Before() { }

    public abstract Task<R> Handle(T argument);

    public virtual void After() { }

}


public interface IBaseRepository<T> where T : IEntity
{
    Task<T> Add(T entity);
}

public class BaseRepository<T> : IBaseRepository<T> where T : IEntity
{
    public Task<T> Add(T entity)
    {
        return Task.FromResult(entity);
    }
}