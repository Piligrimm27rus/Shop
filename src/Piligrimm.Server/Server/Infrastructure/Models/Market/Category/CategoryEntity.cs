using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Piligrimm.Server.Infrastructure.Models.Market
{
    // [Table("categories")]
    internal class CategoryEntity
    {
        [Key]
        public Guid Uid { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}