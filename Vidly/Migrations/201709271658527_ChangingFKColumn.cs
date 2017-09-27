namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingFKColumn : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", "Genre_Id"); 
        }
        
        public override void Down()
        {
        }
    }
}
