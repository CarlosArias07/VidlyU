namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdateToNull : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = null WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
