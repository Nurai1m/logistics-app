using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configuration
{
    public class ProductDictionaryConfiguration : IEntityTypeConfiguration<ProductDictionary>
    {
        public void Configure(EntityTypeBuilder<ProductDictionary> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.VendorCode).IsRequired().HasMaxLength(500);
        }
    }
}