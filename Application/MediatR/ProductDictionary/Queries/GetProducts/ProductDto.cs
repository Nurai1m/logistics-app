namespace Application.MediatR.ProductDictionary.Queries
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VendorCode { get; set; }
    }
}