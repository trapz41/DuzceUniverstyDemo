namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbnew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 30, unicode: false),
                        Soyad = c.String(nullable: false, maxLength: 30, unicode: false),
                        Sehir = c.String(maxLength: 20, unicode: false),
                        Mail = c.String(maxLength: 250, unicode: false),
                        Telefon = c.String(maxLength: 11, unicode: false),
                        Durum2 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registers");
        }
    }
}
