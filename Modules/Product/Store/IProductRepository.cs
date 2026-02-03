using WolverineTest.Modules.Product.Actions;

namespace WolverineTest.Modules.Product.Store;

public interface IProductRepository : IBaseRepository<ProductEntity>
{
    Task<int> CreateV2(ProductEntity entity);
}

public class ProductRespository : BaseRepository<ProductEntity>, IProductRepository
{
    public Task<int> CreateV2(ProductEntity entity)
    {
        throw new NotImplementedException();
    }
}