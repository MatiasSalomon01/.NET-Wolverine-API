namespace WolverineTest.Modules.Product.Store;

public class ProductEntity : IEntity<Guid>
{
    public Guid Id { get; set; }
    object? IEntity.Id { get => Id; set; }

    public string Name { get; set; }
    public decimal Amount { get; set; }

    public ProductEntity()
    {
        Id = Guid.NewGuid();
    }

    public ProductEntity(string name, decimal amount)
    {
        Id = Guid.NewGuid();
        Name = name;
        Amount = amount;
    }
}
















public interface IEntity
{
    object Id { get; set; }
}

public interface IEntity<TKey> : IEntity
{
    new TKey Id { get; set; }
}
