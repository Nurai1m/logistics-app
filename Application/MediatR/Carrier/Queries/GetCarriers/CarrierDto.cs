namespace Application.MediatR.Carrier.Queries
{
    public class CarrierDto
    {
        public Guid Id { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public int OrderAmount { get; set; }
    }
}