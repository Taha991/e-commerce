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
    public class FoodStuffConfiguration : IEntityTypeConfiguration<FoodStuff>
    {
        public void Configure(EntityTypeBuilder<FoodStuff> builder)
        {
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired();
            builder.Property(p => p.Price).HasColumnType("decimal");
            builder.Property(p => p.PictureUrl).IsRequired();
            builder.HasOne(p => p.FoodProductBrand).WithMany().HasForeignKey(p => p.FoodProductBrandId);
            builder.HasOne(p => p.FoodProductType).WithMany().HasForeignKey(p => p.FoodProductTypeId);
        }
    }
}
