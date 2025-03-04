using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(p => p.Title).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(p => p.Category).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Image).HasMaxLength(255);

            builder.OwnsOne(p => p.Rating, rating =>
            {
                rating.Property(r => r.Rate).IsRequired().HasColumnType("decimal(3,2)").HasDefaultValue(0);
                rating.Property(r => r.Count).IsRequired().HasDefaultValue(0);
            });

            builder.Property(p => p.CreatedAt).HasColumnType("timestamp").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(p => p.UpdatedAt).HasColumnType("timestamp");
        }
    }
}
