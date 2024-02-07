namespace Piligrimm.Server.Infrastructure.Models.Market
{
    public interface ICategoryInfrastructure
    {
        IEnumerable<CategoryEntity> GetAll();
    }
}