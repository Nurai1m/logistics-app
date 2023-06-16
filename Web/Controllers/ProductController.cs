using Application.MediatR.ProductDictionary.Commands;
using Application.MediatR.ProductDictionary.Queries;
using AspNetCoreHero.ToastNotification.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private IMediator Mediator;
        private INotyfService _notyfService;

        public ProductController(IMediator mediator, INotyfService notyfService)
        {
            Mediator = mediator;
            _notyfService = notyfService;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Products"] = await Mediator.Send(new GetProductsQuery());

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDictionaryCommand command)
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
    }
}
