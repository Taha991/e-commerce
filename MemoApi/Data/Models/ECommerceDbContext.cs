using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MemoApi.Data.Models;

public partial class ECommerceDbContext : DbContext
{
    public ECommerceDbContext()
    {
    }

    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartItem> CartItems { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerInteraction> CustomerInteractions { get; set; }

    public virtual DbSet<DailySalesSummary> DailySalesSummaries { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<InteractionType> InteractionTypes { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Merchant> Merchants { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductSale> ProductSales { get; set; }

    public virtual DbSet<ProductVariant> ProductVariants { get; set; }

    public virtual DbSet<ProductView> ProductViews { get; set; }

    public virtual DbSet<Refund> Refunds { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SubscriptionPackage> SubscriptionPackages { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<UserAuth> UserAuths { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("workstation id=E-commercee.mssql.somee.com;packet size=4096;user id=Taha991_SQLLogin_1;pwd=go9e5gjbo1;data source=E-commercee.mssql.somee.com;persist security info=False;initial catalog=E-commercee;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => e.CartId).HasName("PK__Carts__51BCD7973A1A054F");

            entity.Property(e => e.CartId).HasColumnName("CartID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Carts)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Carts__CustomerI__656C112C");
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasKey(e => e.CartItemId).HasName("PK__CartItem__488B0B2A6E285663");

            entity.Property(e => e.CartItemId).HasColumnName("CartItemID");
            entity.Property(e => e.CartId).HasColumnName("CartID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Cart).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.CartId)
                .HasConstraintName("FK__CartItems__CartI__14E61A24");

            entity.HasOne(d => d.Product).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__CartItems__Produ__15DA3E5D");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2BBD7DCC68");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK__Company__DAD4F3BE9933F7E3");

            entity.ToTable("Company");

            entity.HasIndex(e => e.PhoneNumber, "UQ__Company__85FB4E38AC20ABCA").IsUnique();

            entity.HasIndex(e => e.CompanyName, "UQ__Company__9BCE05DC2DB93F64").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Company__A9D1053421F87EE1").IsUnique();

            entity.HasIndex(e => e.Email, "idx_email");

            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.AdditionalInfo).HasColumnType("text");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionEndDate).HasColumnType("datetime");
            entity.Property(e => e.SubscriptionPackageId).HasColumnName("SubscriptionPackageID");
            entity.Property(e => e.SubscriptionStartDate).HasColumnType("datetime");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.SubscriptionPackage).WithMany(p => p.Companies)
                .HasForeignKey(d => d.SubscriptionPackageId)
                .HasConstraintName("FK__Company__Subscri__32AB8735");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B8DB46FF6F");

            entity.HasIndex(e => e.PhoneNumber, "UQ__Customer__85FB4E3858C80D26").IsUnique();

            entity.HasIndex(e => e.PhoneNumber, "idx_phone_number");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.HomeAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubAddresses).HasColumnType("text");

            entity.HasMany(d => d.Products).WithMany(p => p.Customers)
                .UsingEntity<Dictionary<string, object>>(
                    "Favorite",
                    r => r.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Favorites__Produ__11158940"),
                    l => l.HasOne<Customer>().WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Favorites__Custo__10216507"),
                    j =>
                    {
                        j.HasKey("CustomerId", "ProductId").HasName("PK__Favorite__6FEEA8D63D6E0581");
                    });
        });

        modelBuilder.Entity<CustomerInteraction>(entity =>
        {
            entity.HasKey(e => e.InteractionId).HasName("PK__Customer__922C03765DCCD445");

            entity.Property(e => e.InteractionId).HasColumnName("InteractionID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.InteractionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InteractionTypeId).HasColumnName("InteractionTypeID");
            entity.Property(e => e.Note).HasColumnType("text");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerInteractions)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__CustomerI__Custo__04E4BC85");

            entity.HasOne(d => d.InteractedByNavigation).WithMany(p => p.CustomerInteractions)
                .HasForeignKey(d => d.InteractedBy)
                .HasConstraintName("FK__CustomerI__Inter__05D8E0BE");

            entity.HasOne(d => d.InteractionType).WithMany(p => p.CustomerInteractions)
                .HasForeignKey(d => d.InteractionTypeId)
                .HasConstraintName("FK__CustomerI__Inter__06CD04F7");
        });

        modelBuilder.Entity<DailySalesSummary>(entity =>
        {
            entity.HasKey(e => e.SummaryDate).HasName("PK__DailySal__5B3F15F946A3FF7A");

            entity.ToTable("DailySalesSummary");

            entity.Property(e => e.SummaryDate).HasColumnType("date");
            entity.Property(e => e.TotalRefunds).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalSales).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => e.DiscountId).HasName("PK__Discount__E43F6DF64230C805");

            entity.Property(e => e.DiscountId).HasColumnName("DiscountID");
            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .HasDefaultValueSql("('1')");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.DiscountType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RequiredSubscriptionLevel)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Product).WithMany(p => p.Discounts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Discounts__Produ__2334397B");
        });

        modelBuilder.Entity<InteractionType>(entity =>
        {
            entity.HasKey(e => e.InteractionTypeId).HasName("PK__Interact__827A814F7A857525");

            entity.Property(e => e.InteractionTypeId).HasColumnName("InteractionTypeID");
            entity.Property(e => e.InteractionTypeName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.InventoryId).HasName("PK__Inventor__F5FDE6D3E3129AC9");

            entity.ToTable("Inventory");

            entity.HasIndex(e => e.WarehouseId, "idx_inventory_warehouse");

            entity.Property(e => e.InventoryId).HasColumnName("InventoryID");
            entity.Property(e => e.VariantId).HasColumnName("VariantID");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.HasOne(d => d.Variant).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.VariantId)
                .HasConstraintName("FK__Inventory__Varia__09746778");
        });

        modelBuilder.Entity<Merchant>(entity =>
        {
            entity.HasKey(e => e.MerchantId).HasName("PK__Merchant__04416563D3052F1A");

            entity.Property(e => e.MerchantId).HasColumnName("MerchantID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubscriptionEndDate).HasColumnType("datetime");
            entity.Property(e => e.SubscriptionPackageId).HasColumnName("SubscriptionPackageID");
            entity.Property(e => e.SubscriptionStartDate).HasColumnType("datetime");
            entity.Property(e => e.SubscriptionStatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("('1')");

            entity.HasOne(d => d.SubscriptionPackage).WithMany(p => p.Merchants)
                .HasForeignKey(d => d.SubscriptionPackageId)
                .HasConstraintName("FK__Merchants__Subsc__2CF2ADDF");

            entity.HasMany(d => d.Roles).WithMany(p => p.Merchants)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UserRoles__RoleI__4A8310C6"),
                    l => l.HasOne<Merchant>().WithMany()
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UserRoles__Merch__498EEC8D"),
                    j =>
                    {
                        j.HasKey("MerchantId", "RoleId").HasName("PK__UserRole__BCEEC980F9B5A21C");
                    });
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BAFB054D6E3");

            entity.HasIndex(e => e.CustomerId, "idx_order_customer");

            entity.HasIndex(e => e.Date, "idx_order_date");

            entity.HasIndex(e => new { e.Date, e.Status }, "idx_order_date_status");

            entity.HasIndex(e => e.MerchantId, "idx_order_merchant");

            entity.HasIndex(e => e.PaymentMethodId, "idx_order_payment");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MerchantId).HasColumnName("MerchantID");
            entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('Pending')");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__Orders__Customer__6FB49575");

            entity.HasOne(d => d.Merchant).WithMany(p => p.Orders)
                .HasForeignKey(d => d.MerchantId)
                .HasConstraintName("FK__Orders__Merchant__70A8B9AE");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.Orders)
                .HasForeignKey(d => d.PaymentMethodId)
                .HasConstraintName("FK__Orders__PaymentM__719CDDE7");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId).HasName("PK__OrderDet__D3B9D30C5A04F4C2");

            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderDeta__Order__0C50D423");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__OrderDeta__Produ__0D44F85C");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentMethodId).HasName("PK__PaymentM__DC31C1F377D9EC61");

            entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6EDFF61B01C");

            entity.HasIndex(e => e.CategoryId, "idx_category");

            entity.HasIndex(e => e.MerchantId, "idx_merchant");

            entity.HasIndex(e => e.Name, "idx_product_name");

            entity.HasIndex(e => e.Price, "nidx_product_price");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Approved)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('1')");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.DiscountPercentage)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DiscountedPrice)
                .HasComputedColumnSql("([Price]*((1)-[DiscountPercentage]/(100)))", true)
                .HasColumnType("decimal(21, 8)");
            entity.Property(e => e.MerchantId).HasColumnName("MerchantID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Products__Catego__7849DB76");

            entity.HasOne(d => d.Merchant).WithMany(p => p.Products)
                .HasForeignKey(d => d.MerchantId)
                .HasConstraintName("FK__Products__Mercha__793DFFAF");
        });

        modelBuilder.Entity<ProductSale>(entity =>
        {
            entity.HasKey(e => e.SaleId).HasName("PK__ProductS__1EE3C41FB1EAB4D5");

            entity.Property(e => e.SaleId).HasColumnName("SaleID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.SaleCount).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductSales)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductSa__Produ__1D7B6025");
        });

        modelBuilder.Entity<ProductVariant>(entity =>
        {
            entity.HasKey(e => e.VariantId).HasName("PK__ProductV__0EA233E468226E99");

            entity.HasIndex(e => e.Sku, "UQ__ProductV__CA1ECF0D499D6E8C").IsUnique();

            entity.Property(e => e.VariantId).HasColumnName("VariantID");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('Available')");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductVariants)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductVa__Produ__0697FACD");
        });

        modelBuilder.Entity<ProductView>(entity =>
        {
            entity.HasKey(e => e.ViewId).HasName("PK__ProductV__1E371C1623E2B3E4");

            entity.Property(e => e.ViewId).HasColumnName("ViewID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductViews)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductVi__Produ__19AACF41");
        });

        modelBuilder.Entity<Refund>(entity =>
        {
            entity.HasKey(e => e.RefundId).HasName("PK__Refunds__725AB9001C3D7345");

            entity.Property(e => e.RefundId).HasColumnName("RefundID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ProcessedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Reason).HasColumnType("text");

            entity.HasOne(d => d.Order).WithMany(p => p.Refunds)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__Refunds__OrderID__29E1370A");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE3A44B271D1");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubscriptionPackage>(entity =>
        {
            entity.HasKey(e => e.SubscriptionPackageId).HasName("PK__Subscrip__9503977E48307CBA");

            entity.Property(e => e.SubscriptionPackageId).HasColumnName("SubscriptionPackageID");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE666943655ECB2");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.ContactInfo).HasColumnType("text");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserAuth>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserAuth__1788CCAC5E83E437");

            entity.ToTable("UserAuth");

            entity.HasIndex(e => e.Username, "UQ__UserAuth__536C85E4685C34A8").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__UserAuth__A9D105340554E80E").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HashedPassword)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsActive)
                .HasMaxLength(1)
                .HasDefaultValueSql("('1')");
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRoleMapping",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UserRoleM__RoleI__69FBBC1F"),
                    l => l.HasOne<UserAuth>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UserRoleM__UserI__690797E6"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__UserRole__AF27604FCBC59CF8");
                    });
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.WarehouseId).HasName("PK__Warehous__2608AFD9B5F24931");

            entity.ToTable("Warehouse");

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
