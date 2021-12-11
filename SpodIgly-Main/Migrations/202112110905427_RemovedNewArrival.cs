namespace SpodIgly_Main.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedNewArrival : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Albums", "isNewArrival");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Albums", "isNewArrival", c => c.Boolean(nullable: false));
        }
    }
}
