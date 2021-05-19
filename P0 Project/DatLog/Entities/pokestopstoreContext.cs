using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatLog.Entities
{
    public partial class pokestopstoreContext : DbContext
    {
        public pokestopstoreContext()
        {
        }

        public pokestopstoreContext(DbContextOptions<pokestopstoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Storefront> Storefronts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerPassword)
                    .HasName("PK__Customer__FD8049953D395B2E");

                entity.ToTable("Customer");

                entity.Property(e => e.CustomerPassword)
                    .ValueGeneratedNever()
                    .HasColumnName("customerPassword");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("customerName");

                entity.Property(e => e.Customerhometown)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("Inventory");

                entity.Property(e => e.InventoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("inventoryID");

                entity.Property(e => e.InventoryName).HasColumnName("inventoryName");

                entity.Property(e => e.InventoryQuantity).HasColumnName("inventoryQuantity");

                entity.Property(e => e.StoreId).HasColumnName("storeID");

                entity.HasOne(d => d.InventoryNameNavigation)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.InventoryName)
                    .HasConstraintName("FK__Inventory__inven__17C286CF");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Inventory__store__18B6AB08");
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.Property(e => e.LineitemId)
                    .ValueGeneratedNever()
                    .HasColumnName("lineitemID");

                entity.Property(e => e.LineitemQuantity).HasColumnName("lineitemQuantity");

                entity.Property(e => e.LineorderId).HasColumnName("lineorderID");

                entity.Property(e => e.LineproductId).HasColumnName("lineproductID");

                entity.HasOne(d => d.Lineorder)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.LineorderId)
                    .HasConstraintName("FK__LineItems__lineo__13F1F5EB");

                entity.HasOne(d => d.Lineproduct)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.LineproductId)
                    .HasConstraintName("FK__LineItems__linep__14E61A24");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.Property(e => e.ManagerId)
                    .ValueGeneratedNever()
                    .HasColumnName("managerID");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("managerName");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("orderID");

                entity.Property(e => e.OrderCustomerId).HasColumnName("orderCustomerID");

                entity.Property(e => e.OrderStroreFrontId).HasColumnName("orderStroreFrontID");

                entity.Property(e => e.OrderTiming)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("orderTiming");

                entity.Property(e => e.OrderTotal).HasColumnName("orderTotal");

                entity.HasOne(d => d.OrderCustomer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderCustomerId)
                    .HasConstraintName("FK__Orders__orderCus__0C50D423");

                entity.HasOne(d => d.OrderStroreFront)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStroreFrontId)
                    .HasConstraintName("FK__Orders__orderStr__0D44F85C");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductCode)
                    .HasName("PK__Product__C20683889F6C0656");

                entity.ToTable("Product");

                entity.Property(e => e.ProductCode)
                    .ValueGeneratedNever()
                    .HasColumnName("productCode");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("productName");

                entity.Property(e => e.ProductPrice).HasColumnName("productPrice");
            });

            modelBuilder.Entity<Storefront>(entity =>
            {
                entity.ToTable("Storefront");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("storefrontID");

                entity.Property(e => e.StorefrontTown)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("storefrontTown");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
