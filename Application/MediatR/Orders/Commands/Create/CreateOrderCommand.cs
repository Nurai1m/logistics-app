﻿using Application.Common.Dtos;
using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.MediatR.Orders.Commands
{
    public class CreateOrderCommand : IRequest<Result>
    {
        public Guid CustomerId { get; set; }
        public Guid ShopLocationId { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public string Description { get; set; }
        public Guid? CarrierId { get; set; }
        public string Address { get; set; }
        public string Lat { get; set; }
        public string Lang { get; set; }
        public Guid ShopId { get; set; }
        public List<OrderProductDto> Products { get; set; }
    }

    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Result>
    {
        private ILogisticEFContext _context;
        private IUserService _userService;

        public CreateOrderCommandHandler(ILogisticEFContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public async Task<Result> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var shopLocation = _context.ShopLocations.FirstOrDefault(x => x.ShopId == request.ShopId);
                var order = new Order
                {
                    CustomerId = request.CustomerId,
                    DeliveryType = request.DeliveryType,
                    Description = request.Description,
                    СarrierId = request.CarrierId,
                    Address = request.Address,
                    Lang = request.Lang,
                    Lat = request.Lat,
                    TreckingNumber = TrackNum(10),
                    ShopId = request.ShopId,
                    ShopLocationId = shopLocation.Id,
                    OrderStatus = OrderStatus.Await,
                };

                var products = new List<OrderProduct>();

                foreach (var product in request.Products)
                {
                    products.Add(new OrderProduct
                    {
                        ShopProductId = product.ShopProductId,
                        Amount = product.Amount
                    });
                }

                order.OrderProducts = products;
                _context.Orders.Add(order);
                await _context.SaveChangesAsync(cancellationToken);

                return Result.Success("Данные успешно сохранены");
            }
            catch (Exception ex)
            {
                return Result.Failure("");
            }
            
        }

        private static string TrackNum(int length)
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var randStr =  new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return $"Track_{DateTime.Now.ToString("yyyy-MM-dd")}_{randStr}";
        }
    }
}