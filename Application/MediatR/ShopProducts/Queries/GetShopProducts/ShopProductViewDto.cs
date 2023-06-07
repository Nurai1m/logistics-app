namespace Application.MediatR.ShopProducts.Queries
{
    public class ShopProductViewDto
    {
        public Guid ShopProductId { get; set; }
        public Guid ShopId { get; set; }
        public Guid ProductId { get; set; }
        public string ShopName { get; set; }
        public string ProductName { get; set; }
        public double Amount { get; set; }
    }
}