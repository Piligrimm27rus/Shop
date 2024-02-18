using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Piligrimm.Server.Infrastructure.Models.Market
{
    [Table("Products")]
    internal class ProductEntity
    {
        [Key]
        public Guid Uid { get; set; }

        public CategoryEntity Category { get; set; } = null!;

        public string Name { get; set; } = null!;

        [Range(1, int.MaxValue)]
        public double Price { get; set; }

        [Range(0, 1)]
        public double Discount { get; set; }

        public string? Description { get; set; }
    }
}
