namespace Application.Common.Interfaces
{
    public interface IUserService
    {
        Guid Id { get; }
        string Name { get; }
        string Firstname { get; }
        string Patronymic { get; }
        string Address { get; }
        string Fullname { get; }
        string RoleName { get; }
    }
}