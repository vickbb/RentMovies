namespace RentMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToCustumer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubcribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubcribedToNewsletter");
        }
    }
}
