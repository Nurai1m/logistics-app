using Application.Common.Dtos;
using Domain.Constants;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.Accounts.Queries.GetRoles
{
    public class GetRolesQuery : IRequest<List<ValueDto>>
    {
    }

    public class GetRolesQueryHandler : IRequestHandler<GetRolesQuery, List<ValueDto>>
    {
        private RoleManager<IdentityRole<Guid>> _roleManager;

        public GetRolesQueryHandler(RoleManager<IdentityRole<Guid>> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<List<ValueDto>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
        {
            var roles = _roleManager.Roles.Select(x => new ValueDto {Id = x.Id, Name = x.Name }).Where(x=>x.Name != Roles.Admin).ToList();

            return roles;
        }
    }
}
