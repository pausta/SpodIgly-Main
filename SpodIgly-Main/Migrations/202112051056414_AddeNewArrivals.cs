namespace SpodIgly_Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddeNewArrivals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "isNewArrival", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "isNewArrival");
        }
    }
}
