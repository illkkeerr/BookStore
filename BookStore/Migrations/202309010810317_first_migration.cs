namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Yazar = c.String(),
                        YayinTarihi = c.DateTime(nullable: false),
                        StokSayisi = c.Int(nullable: false),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Categories", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.BorrowRecords",
                c => new
                    {
                        KayitId = c.Int(nullable: false, identity: true),
                        MusteriId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                        OduncTarihi = c.DateTime(nullable: false),
                        IadeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KayitId)
                .ForeignKey("dbo.Books", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.MusteriId, cascadeDelete: true)
                .Index(t => t.MusteriId)
                .Index(t => t.KitapId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        EPosta = c.String(),
                        Telefon = c.String(),
                    })
                .PrimaryKey(t => t.MusteriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BorrowRecords", "MusteriId", "dbo.Customers");
            DropForeignKey("dbo.BorrowRecords", "KitapId", "dbo.Books");
            DropForeignKey("dbo.Books", "KategoriId", "dbo.Categories");
            DropIndex("dbo.BorrowRecords", new[] { "KitapId" });
            DropIndex("dbo.BorrowRecords", new[] { "MusteriId" });
            DropIndex("dbo.Books", new[] { "KategoriId" });
            DropTable("dbo.Customers");
            DropTable("dbo.BorrowRecords");
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
        }
    }
}
