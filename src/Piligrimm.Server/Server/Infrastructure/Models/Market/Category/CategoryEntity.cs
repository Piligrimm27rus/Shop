using System.ComponentModel.DataAnnotations;

namespace Piligrimm.Server.Infrastructure.Models.Market
{
    public class CategoryEntity
    {
        [Key]
        public Guid Uid { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}