using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public GetShopsQueryHandler(ILogisticEFContext context, IUserService userService, UserManager<User> userManager)
        {
            _context = context;
            _userService = userService;
            _userManager = userManager;
        }

        public async Task<List<ClientDto>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {
            var clients = await _userManager.GetUsersInRoleAsync("client");

            List<ClientDto> shopDtos = clients.Select(x =>
            new ClientDto
            {
                Fullname = x.Fullname,
                Address = x.Address,
                Phone = x.PhoneNumber
            }).ToList();

            return shopDtos;

        }
    }
}
