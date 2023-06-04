using Application.MediatR.ProductDictionary.Commands;
using Application.MediatR.ProductDictionary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ProductController : Controller
    {
        private IMediator Mediator;

        public ProductController(IMediator mediator)
        {
            Mediator = mediator;
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
                    return RedirectToAction("Index");
                }
            }

            return View(command);
        }
    }
}
