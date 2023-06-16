using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                if (string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Description) || string.IsNullOrWhiteSpace(request.VendorCode))
                {
                    return Result.Failure("Необходимо заполнить все поля");
                }    

                var product = new Domain.Entities.ProductDictionary
                { 
                    Name = request.Name, 
                    Description = request.Description,
                    VendorCode = request.VendorCode,
                };

                _context.ProductDictionary.Add(product);
                await _context.SaveChangesAsync(cancellationToken);

                return Result.Success("Данные успешно сохранены");
            }
            catch (Exception ex)
            {
                return Result.Failure("");
            }
        }
    }
}
