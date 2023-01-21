namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WebSitedb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        kullaniciadi = c.String(),
                        sifre = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Duyurulars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        pictures = c.String(),
                        baslik = c.String(),
                        duyuru = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Duyurulars");
            DropTable("dbo.Admins");
        }
    }
}
