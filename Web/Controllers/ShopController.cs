using Application.MediatR.Shop.Commands;
using Application.MediatR.Shop.Queries;
using AspNetCoreHero.ToastNotification.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ShopController : Controller
    {
        private IMediator Mediator;
        private INotyfService _notyfService;

        public ShopController(IMediator mediator, INotyfService notyfService)
        {
            Mediator = mediator;
            _notyfService = notyfService;
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
            //if (ModelState.IsValid)
            //{
            var result = await Mediator.Send(command);
            if (result.Succeed)
            {
                foreach (var message in result.Messages) _notyfService.Success(message);
                return RedirectToAction("Index");
            }
            foreach (var message in result.Messages) _notyfService.Error(message);
            //}

            return View(command);
        }


    }
}