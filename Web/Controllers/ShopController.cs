using Application.MediatR.Shop.Commands;
using Application.MediatR.Shop.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ShopController : Controller
    {
        private IMediator Mediator;

        public ShopController(IMediator mediator)
        {
            Mediator = mediator;
        }

        public async Task<IActionResult> Index(GetShopsQuery query)
        {
            var result = await Mediator.Send(query);
            ViewData["Shops"] = result;
            return View(query);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateShopCommand command)
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