using Application.MediatR.Carrier.Queries;
using Application.MediatR.Clients.Queries;
using Application.MediatR.Orders.Commands;
using Application.MediatR.Orders.Queries;
using Application.MediatR.Shop.Queries;
using Application.MediatR.Shop.Queries.GetShops;
using Application.MediatR.ShopProducts.Queries.GetShopProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        private IMediator Mediator;

        public OrderController(IMediator mediator)
        {
            Mediator = mediator;
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
                    return RedirectToAction("Index");
                }
            }

            return View(command);
        }
    }
}
