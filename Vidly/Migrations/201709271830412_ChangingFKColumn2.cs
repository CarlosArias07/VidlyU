namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingFKColumn2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Genre_Id");
            //DropColumn("dbo.Movies", "Genre_Id");
        }

        public override void Down()
        {
        }
    }
}
