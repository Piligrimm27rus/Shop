namespace Piligrimm.Server.Application.Models.Market
{
    public class Category
    {
        public Guid Uid { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}