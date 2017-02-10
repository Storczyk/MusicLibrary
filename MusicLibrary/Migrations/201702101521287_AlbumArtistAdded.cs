namespace MusicLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlbumArtistAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        genre = c.Int(nullable: false),
                        artist_ArtistId = c.Int(),
                    })
                .PrimaryKey(t => t.AlbumId)
                .ForeignKey("dbo.Artists", t => t.artist_ArtistId)
                .Index(t => t.artist_ArtistId);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ArtistId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Albums", "artist_ArtistId", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "artist_ArtistId" });
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
