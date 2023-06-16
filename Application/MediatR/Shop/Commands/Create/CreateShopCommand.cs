﻿using Application.Common.Dtos;
using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using MediatR;

namespace Application.MediatR.Shop.Commands
{
    public class CreateShopCommand : IRequest<Result>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<LocationDto> Locations { get; set; }
    }

    public class CreateShopCommandHandler : IRequestHandler<CreateShopCommand, Result>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public CreateShopCommandHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<Result> Handle(CreateShopCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var shop = new Domain.Entities.Shop { Name = request.Name, Description = request.Description, Url = request.Url };

                shop.UserShops = new List<UserShop>();

                var userShop = new UserShop { UserId = _userService.Id };
                shop.UserShops.Add(userShop);

                var shopLocations = new List<ShopLocation>();

                foreach (var location in request.Locations)
                {
                    shopLocations.Add(new ShopLocation
                    {
                        Name = location.Name,
                        Address = location.Address,
                        Lat = location.Lat,
                        Lang = location.Lang,
                    });
                }

                shop.Locations = shopLocations;

                _context.Shops.Add(shop);
                await _context.SaveChangesAsync(cancellationToken);

                return Result.Success("Данные успешно сохранены");
            }
            catch (Exception ex)
            {
                return Result.Failure("");
            }
        }
    }
}