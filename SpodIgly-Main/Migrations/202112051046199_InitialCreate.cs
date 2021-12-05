namespace SpodIgly_Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                {
                    AlbumID = c.Int(nullable: false, identity: true),
                    GenreID = c.Int(nullable: false),
                    AlbumTitle = c.String(),
                    ArtistName = c.String(),
                    DateAdded = c.DateTime(nullable: false),
                    CoverFileName = c.String(),
                    Description = c.String(),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    isBestseller = c.Boolean(nullable: false),
                    isHidden = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .Index(t => t.GenreID);

            CreateTable(
                "dbo.Genres",
                c => new
                {
                    GenreID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                    IconFilename = c.String(),
                })
                .PrimaryKey(t => t.GenreID);

            CreateTable(
                "dbo.OrderItems",
                c => new
                {
                    OrderItemID = c.Int(nullable: false, identity: true),
                    OrderID = c.Int(nullable: false),
                    AlbumID = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                    UnitPrice = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.OrderItemID)
                .ForeignKey("dbo.Albums", t => t.AlbumID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.AlbumID);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    OrderID = c.Int(nullable: false, identity: true),
                    FirstName = c.String(maxLength: 150),
                    LastName = c.String(maxLength: 150),
                    Address = c.String(),
                    CodeAndCity = c.String(nullable: false, maxLength: 50),
                    PhoneNumber = c.String(),
                    Email = c.String(),
                    Comment = c.String(),
                    DateCreated = c.DateTime(nullable: false),
                    Orderstate = c.Int(nullable: false),
                    TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.OrderID);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "AlbumID", "dbo.Albums");
            DropForeignKey("dbo.Albums", "GenreID", "dbo.Genres");
            DropIndex("dbo.OrderItems", new[] { "AlbumID" });
            DropIndex("dbo.OrderItems", new[] { "OrderID" });
            DropIndex("dbo.Albums", new[] { "GenreID" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Genres");
            DropTable("dbo.Albums");
        }
    }
}
