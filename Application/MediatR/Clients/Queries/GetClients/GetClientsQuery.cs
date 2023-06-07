using Application.Common.Interfaces;
using Domain.Constants;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.Clients.Queries
{
    public class GetClientsQuery : IRequest<List<ClientDto>>
    {
    }

    public class GetShopsQueryHandler : IRequestHandler<GetClientsQuery, List<ClientDto>>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;
        private UserManager<User> _userManager;
        private RoleManager<IdentityRole<Guid>> _roleManager;
        IHttpContextAccessor _httpContextAccessor;

        public GetShopsQueryHandler(ILogisticEFContext context, IUserService userService, UserManager<User> userManager, RoleManager<IdentityRole<Guid>> roleManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userService = userService;
            _userManager = userManager;
            _roleManager = roleManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<ClientDto>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {
            var users = await _userManager.GetUsersInRoleAsync("client");

            List<ClientDto> clients = users.Select(x =>
            new ClientDto
            {
                Id = x.Id,
                Fullname = x.Fullname,
                Phone = x.PhoneNumber,
                Address = x.Address
            }).ToList();

            return clients;

        }
    }
}
