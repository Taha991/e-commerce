using System;
using System.Collections.Generic;

namespace MemoApi.Data.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int? CategoryId { get; set; }

    public int? MerchantId { get; set; }

    public string? Approved { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public decimal? DiscountedPrice { get; set; }

    public virtual ICollection<CartItem> CartItems { get; } = new List<CartItem>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<Discount> Discounts { get; } = new List<Discount>();

    public virtual Merchant? Merchant { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual ICollection<ProductSale> ProductSales { get; } = new List<ProductSale>();

    public virtual ICollection<ProductVariant> ProductVariants { get; } = new List<ProductVariant>();

    public virtual ICollection<ProductView> ProductViews { get; } = new List<ProductView>();

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
}
