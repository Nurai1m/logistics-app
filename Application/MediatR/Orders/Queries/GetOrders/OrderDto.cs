using Domain.Enums;

namespace Application.MediatR.Orders.Queries
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public string CustomerName { get; set; }
        public string? CarrierName { get; set; }
        public string TreckingNumber { get; set; }
        public string? Address { get; set; }
        public string Description { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}