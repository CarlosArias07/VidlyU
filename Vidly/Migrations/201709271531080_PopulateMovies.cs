namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId, Stock) VALUES ('Hangover', '2009-08-14', '2017-09-26', 2, 5)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId, Stock) VALUES ('Die Hard', '1998-07-12', '2017-09-26', 1, 7)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId, Stock) VALUES ('The Terminator', '1984-12-20', '2017-09-26', 1, 9)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId, Stock) VALUES ('Toy Story', '1996-03-21', '2017-09-27', 3, 5)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, GenreId, Stock) VALUES ('Titanic', '1998-01-01', '2017-09-27', 4, 10)");
        }
        
        public override void Down()
        {
        }
    }
}
