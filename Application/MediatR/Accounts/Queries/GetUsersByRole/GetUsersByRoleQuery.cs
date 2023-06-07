﻿//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Application.MediatR.Accounts.Queries.GetUsersByRole
//{
//    internal class GetUsersByRoleQuery
//    {
//    }

//    public class GetUsersByRoleQuery : IRequest<List<CarrierDto>>
//    {
//    }

//    public class GetCarriersQueryHandler : IRequestHandler<GetUsersByRoleQuery, List<CarrierDto>>
//    {
//        private ILogisticEFContext _context;
//        private IUserService _userService;
//        private UserManager<User> _userManager;

//        public GetCarriersQueryHandler(ILogisticEFContext context, IUserService userService, UserManager<User> userManager)
//        {
//            _context = context;
//            _userService = userService;
//            _userManager = userManager;
//        }

//        public async Task<List<CarrierDto>> Handle(GetUsersByRoleQuery request, CancellationToken cancellationToken)
//        {
//            var carriers = await _userManager.GetUsersInRoleAsync("carrier");

//            List<CarrierDto> carrierDtos = carriers.Select(x =>
//            new CarrierDto
//            {
//                Fullname = x.Fullname,
//                Phone = x.PhoneNumber,
//            }).ToList();

//            return carrierDtos;
//        }
//    }
