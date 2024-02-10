using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Piligrimm.Server.Infrastructure.Models.Market
{
    // [Table("product")]
    internal class ProductEntity
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
