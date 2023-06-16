﻿using Application.MediatR.Carrier.Queries;
using Application.MediatR.Clients.Queries;
using Application.MediatR.Orders.Commands;
using Application.MediatR.Orders.Commands.Create;
using Application.MediatR.Orders.Queries;
using Application.MediatR.Shop.Queries;
using Application.MediatR.Shop.Queries.GetShops;
using Application.MediatR.ShopProducts.Queries.GetShopProducts;
using AspNetCoreHero.ToastNotification.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        private IMediator Mediator;
        private INotyfService _notyfService;

        public OrderController(IMediator mediator, INotyfService notyfService)
        {
            Mediator = mediator;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await Mediator.Send(new GetOrdersQuery());
            ViewData["Orders"] = result;

            return View();
        }

        public async Task<IActionResult> ShopsIndex()
        {
            var shops = await Mediator.Send(new GetShopsQuery());
            return View(shops);
        }

        public async Task<IActionResult> Create(GetShopByIdQuery query)
        {
            ViewData["Shop"] = await Mediator.Send(query);
            ViewData["ShopProducts"] = await Mediator.Send(new GetShopProductsByShopIdQuery { ShopId = query.Id});
            ViewData["Customers"] = await Mediator.Send(new GetClientsQuery());

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await Mediator.Send(command);
                if (result.Succeed)
                {
                    foreach (var message in result.Messages) _notyfService.Success(message);
                    return RedirectToAction("Index");
                }
                foreach (var message in result.Messages) _notyfService.Error(message);
            }

            return View(command);
        }

        public async Task<IActionResult> CreateDelivery(CreateDeliveryCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await Mediator.Send(command);

                return Json(result);
            }

            return View("CreateDelivery");
        }

        public async Task<IActionResult> PickupSend(PickupSendCommand command)
        {
            if (ModelState.IsValid)
            {
                var result = await Mediator.Send(command);
                if (result.Succeed)
                {
                    foreach (var message in result.Messages) _notyfService.Success(message);
                    return RedirectToAction("Index");
                }
                foreach (var message in result.Messages) _notyfService.Error(message);
            }

            return View();
        }
    }
}
