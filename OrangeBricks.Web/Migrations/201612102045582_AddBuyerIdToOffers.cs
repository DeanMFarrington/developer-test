namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBuyerIdToOffers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "BuyerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Offers", "BuyerId");
            AddForeignKey("dbo.Offers", "BuyerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Offers", "BuyerId", "dbo.AspNetUsers");
            DropIndex("dbo.Offers", new [] {"BuyerId"});
            DropColumn("dbo.Offers", "BuyerId");
        }
    }
}