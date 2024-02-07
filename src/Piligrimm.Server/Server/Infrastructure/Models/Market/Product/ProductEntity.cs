using System.ComponentModel.DataAnnotations;

namespace Piligrimm.Server.Infrastructure.Models.Market
{
    public class ProductEntity
    {
        [Key]
        public Guid Uid { get; set; }
        public Guid CategoryUid { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public double Discount { get; set; }
        public string? Description { get; set; }
    }
}
