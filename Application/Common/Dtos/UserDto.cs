namespace Application.Common.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Amount { get; set; } = 0;
    }
}