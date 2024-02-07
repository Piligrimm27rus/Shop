namespace Piligrimm.Server.Infrastructure.Models.Market
{
    public interface IProductInfrastructure
    {
        IEnumerable<ProductEntity> GetAll();
    }
}