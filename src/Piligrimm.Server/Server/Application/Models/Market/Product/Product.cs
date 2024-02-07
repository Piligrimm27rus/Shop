namespace Piligrimm.Server.Application.Models.Market
{
    public class Product
    {
        public Guid Uid { get; set; }
        public Guid CategoryUid { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public double Discount { get; set; }
        public string? Description { get; set; }
    }
}