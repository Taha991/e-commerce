using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastrucure.Data.Config
{
    public class WomenProductConfiguration : IEntityTypeConfiguration<WomenProducts>
    {
        public void Configure(EntityTypeBuilder<WomenProducts> builder)
        {
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Price).HasColumnType("decimal");
            builder.Property(p => p.PictureUrl).IsRequired();
            builder.HasOne(p => p.WomenProductBrand).WithMany().HasForeignKey(p => p.WomenProductBrandId);
            builder.HasOne(p => p.WomenProductType).WithMany().HasForeignKey(p => p.WomenProductTypeId);
        }
    }
}
