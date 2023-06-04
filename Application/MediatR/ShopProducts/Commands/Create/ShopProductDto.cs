namespace Application.MediatR.ShopProducts.Commands
{
    public class ShopProductDto
    {
        public Guid ShopId { get; set; }
        public Guid ProductId { get; set; }
        public double Amount { get; set; }
    }
}