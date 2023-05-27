using Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Firstname { get; }
        public string Patronymic { get; }
        public string Address { get; }
        public string Fullname => $"{Firstname} {Name} {Patronymic}";

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            ClaimsPrincipal principal = httpContextAccessor?.HttpContext?.User;

            Id = Guid.Parse(principal.FindFirstValue(ClaimTypes.NameIdentifier));
            Name = principal.FindFirstValue(ClaimTypes.Name);
            Firstname = principal.FindFirstValue("Firstname");
            Patronymic = principal.FindFirstValue("Patronymic");
            Address = principal.FindFirstValue("Address");
        }
    }
}
