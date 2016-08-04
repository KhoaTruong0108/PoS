namespace lhk.POS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SyncWithOldDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        ParentId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Description = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.ProductPrice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsCurrentPrice = c.Boolean(nullable: false),
                        ChangedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);

            CreateTable(
                "dbo.Unit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 400),
                        Description = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Manufacturer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 400),
                        Address = c.String(maxLength: 1000),
                        Phone = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 400),
                        Phone = c.String(maxLength: 20),
                        Address = c.String(maxLength: 2000),
                        TotalPurchase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Purchase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Email = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        ChangedBy = c.Int(nullable: false),
                        ChangedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.ImportItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImportId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Import", t => t.ImportId, cascadeDelete: true)
                .Index(t => t.ImportId)
                .Index(t => t.ProductId);

            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 200),
                        Barcode = c.String(maxLength: 20),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockQuantity = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        UnitId = c.Int(),
                        ManufacturerId = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        ChangedBy = c.Int(nullable: false),
                        ChangedDate = c.DateTime(nullable: false),
                        Description = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Manufacturer", t => t.ManufacturerId)
                .ForeignKey("dbo.Unit", t => t.UnitId)
                .Index(t => t.CategoryId)
                .Index(t => t.UnitId)
                .Index(t => t.ManufacturerId);

            CreateTable(
                "dbo.Import",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ImportStatus = c.Boolean(nullable: false),
                        Description = c.String(),
                        ImportBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.OrderItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);

            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(),
                        TotalQuantity = c.Int(nullable: false),
                        TotalPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ChangedBy = c.Int(nullable: false),
                        ChangedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId)
                .Index(t => t.CustomerId);

            CreateTable(
                "dbo.RefundItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RefundId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Refund",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Reason = c.String(nullable: false, maxLength: 1000),
                        TotalQuantity = c.Int(nullable: false),
                        TotalPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ChangedDate = c.DateTime(nullable: false),
                        ChangedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 20),
                        Password = c.String(),
                        Role = c.String(nullable: false, maxLength: 10),
                        IsDeleted = c.Boolean(nullable: false),
                        ChangedBy = c.Int(nullable: false),
                        ChangedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItem", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Order", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.OrderItem", "ProductId", "dbo.Product");
            DropForeignKey("dbo.ImportItem", "ImportId", "dbo.Import");
            DropForeignKey("dbo.ImportItem", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product", "UnitId", "dbo.Unit");
            DropForeignKey("dbo.ProductPrice", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product", "ManufacturerId", "dbo.Manufacturer");
            DropForeignKey("dbo.Product", "CategoryId", "dbo.Category");
            DropIndex("dbo.Order", new[] { "CustomerId" });
            DropIndex("dbo.OrderItem", new[] { "ProductId" });
            DropIndex("dbo.OrderItem", new[] { "OrderId" });
            DropIndex("dbo.Product", new[] { "ManufacturerId" });
            DropIndex("dbo.Product", new[] { "UnitId" });
            DropIndex("dbo.Product", new[] { "CategoryId" });
            DropIndex("dbo.ImportItem", new[] { "ProductId" });
            DropIndex("dbo.ImportItem", new[] { "ImportId" });
            DropIndex("dbo.ProductPrice", new[] { "ProductId" });
            DropTable("dbo.User");
            DropTable("dbo.Refund");
            DropTable("dbo.RefundItem");
            DropTable("dbo.Order");
            DropTable("dbo.OrderItem");
            DropTable("dbo.Import");
            DropTable("dbo.Product");
            DropTable("dbo.ImportItem");
            DropTable("dbo.Customer");
            DropTable("dbo.Manufacturer");
            DropTable("dbo.Unit");
            DropTable("dbo.ProductPrice");
            DropTable("dbo.Category");
        }
    }
}
