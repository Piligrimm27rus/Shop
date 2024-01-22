namespace Piligrimm.Server.Infrastructure.Models.Market
{
    public interface ICategoryInfrastructure
    {
        IEnumerable<CategoryDto> GetAll();
    }
}