using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MediatR.ProductDictionary.Commands
{
    public class CreateProductDictionaryCommand : IRequest<Result>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string VendorCode { get; set; }
    }

    public class CreateProductDictionaryCommandHandler : IRequestHandler<CreateProductDictionaryCommand, Result>
    {
        private ILogisticEFContext _context;

        public CreateProductDictionaryCommandHandler(ILogisticEFContext context)
        {
            _context = context;
        }

        public async Task<Result> Handle(CreateProductDictionaryCommand request, CancellationToken cancellationToken)
        {
            try
            { 
                var product = new Domain.Entities.ProductDictionary
                { 
                    Name = request.Name, 
                    Description = request.Description,
                    VendorCode = request.VendorCode,
                };

                _context.ProductDictionary.Add(product);
                await _context.SaveChangesAsync(cancellationToken);

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure("");
            }
        }
    }
}
