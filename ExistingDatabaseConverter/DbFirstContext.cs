namespace ExistingDatabaseConverter
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbFirstContext : DbContext
    {
        public DbFirstContext()
            : base("name=DbFirstContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<ImportDetail> ImportDetails { get; set; }
        public virtual DbSet<ImportProduct> ImportProducts { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<InventoryHistory> InventoryHistories { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        public virtual DbSet<RefundDetail> RefundDetails { get; set; }
        public virtual DbSet<RefundHistory> RefundHistories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }
        public virtual DbSet<TransactionShift> TransactionShifts { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category1)
                .HasForeignKey(e => e.category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.RefundHistories)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.TransactionHistories)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.cusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Delivery>()
                .HasMany(e => e.ImportProducts)
                .WithRequired(e => e.Delivery1)
                .HasForeignKey(e => e.delivery)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ImportProduct>()
                .Property(e => e.description)
                .IsFixedLength();

            modelBuilder.Entity<ImportProduct>()
                .HasMany(e => e.ImportDetails)
                .WithRequired(e => e.ImportProduct)
                .HasForeignKey(e => e.importId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Manufacturer1)
                .HasForeignKey(e => e.manufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ImportDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.Inventory)
                .WithRequired(e => e.Product);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.InventoryHistories)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductPrices)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.RefundDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.TransactionDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RefundHistory>()
                .HasMany(e => e.RefundDetails)
                .WithRequired(e => e.RefundHistory)
                .HasForeignKey(e => e.refundId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransactionHistory>()
                .HasMany(e => e.TransactionDetails)
                .WithRequired(e => e.TransactionHistory)
                .HasForeignKey(e => e.transactionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Unit1)
                .HasForeignKey(e => e.unit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TransactionHistories)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TransactionShifts)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
