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
        private RoleManager<Role> _roleManager;
        IHttpContextAccessor _httpContextAccessor;

        public GetShopsQueryHandler(ILogisticEFContext context, IUserService userService, UserManager<User> userManager, RoleManager<Role> roleManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userService = userService;
            _userManager = userManager;
            _roleManager = roleManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<ClientDto>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {
            //await _userManager.UpdateSecurityStampAsync(await _userManager.FindByIdAsync(_userService.Id.ToString()));
            var clients = _roleManager.Roles.Include(x => x.UserRoles).ThenInclude(x => x.User).Where(x => x.Name == Roles.Client);
            ////var clients = await _roleManager.Get
            //if (clients.Any())
            //{
            //    List<ClientDto> shopDtos = clients.Select(x=>x.UserRoles)
                    
            //        .Select(x => x
            //    new ClientDto
            //    {
            //        Fullname = x.Select(x=>x.User.Fullname)
            //        Address = x.Address,
            //        Phone = x.PhoneNumber
            //    }).ToList();
            //}
            //return shopDtos;
            return null;

        }
    }
}
