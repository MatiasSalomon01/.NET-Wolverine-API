namespace WolverineTest.Modules.Product.Store;

public interface IProductRepository
{
    Task<int> Create(Product entity);
}