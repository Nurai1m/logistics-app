using Application.MediatR.ProductDictionary.Queries;
using Application.MediatR.Shop.Queries;
using Application.MediatR.ShopProducts.Commands;
using Application.MediatR.ShopProducts.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ShopProductController : Controller
    {
        private IMediator Mediator;

        public ShopProductController(IMediator mediator)
        {
            Mediator = mediator;
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
