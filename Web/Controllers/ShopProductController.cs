using Application.MediatR.ProductDictionary.Queries;
using Application.MediatR.Shop.Queries;
using Application.MediatR.ShopProducts.Commands;
using Application.MediatR.ShopProducts.Queries;
using AspNetCoreHero.ToastNotification.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ShopProductController : Controller
    {
        private IMediator Mediator;
        private INotyfService _notyfService;

        public ShopProductController(IMediator mediator, INotyfService notyfService)
        {
            Mediator = mediator;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["ShopProducts"] = await Mediator.Send(new GetShopProductsQuery());
            return View();
        }

        public async Task<IActionResult> Create()
        {
            var aaa = await Mediator.Send(new GetShopsQuery());
            ViewData["Shops"] = await Mediator.Send(new GetShopsQuery());
            ViewData["Products"] = await Mediator.Send(new GetProductsQuery());

            return View(new AddShopProductCommand());
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddShopProductCommand command)
        {
            var result = await Mediator.Send(command);
            if (result.Succeed)
            {
                foreach (var message in result.Messages) _notyfService.Success(message);
                return RedirectToAction("Index");
            }
            ViewData["Shops"] = await Mediator.Send(new GetShopsQuery());
            ViewData["Products"] = await Mediator.Send(new GetProductsQuery());

            foreach (var message in result.Messages) _notyfService.Error(message);
           
            return View(command);
        }
    }
}
