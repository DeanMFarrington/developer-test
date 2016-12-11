namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddViewingsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Viewings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Status = c.String(),
                    ViewingDate = c.DateTime(nullable: false),
                    Buyer_Id = c.Int(),
                    Property_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Properties", t => t.Property_Id)
                .Index(t => t.Property_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Viewings", "Property_Id", "dbo.Properties");
            DropIndex("dbo.Viewings", new[] { "Property_Id" });
            DropTable("dbo.Viewings");
        }
    }
}
