using Application.MediatR.ShopProducts.Commands;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
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
