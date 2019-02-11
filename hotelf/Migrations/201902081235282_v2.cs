namespace hotelf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ilces",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        IlceAdi = c.String(),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                        IL_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ILs", t => t.IL_id)
                .Index(t => t.IL_id);
            
            CreateTable(
                "dbo.mahalleids",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        MahalleAdi = c.String(),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                        Ilce_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Ilces", t => t.Ilce_id)
                .Index(t => t.Ilce_id);
            
            CreateTable(
                "dbo.ILs",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        IlAdi = c.String(),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.musteris",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        adi = c.String(),
                        soyadi = c.String(),
                        sifre = c.String(),
                        kullaniciid = c.String(),
                        tel = c.String(),
                        email = c.String(),
                        tc = c.Int(nullable: false),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.odas",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        otelid = c.String(),
                        odatipi = c.String(),
                        bosmu = c.Boolean(nullable: false),
                        ucret = c.String(),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.otelozelligis",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        otelid = c.String(),
                        özellikid = c.String(),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.otelresimleris",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        otelid = c.String(),
                        resim = c.Byte(nullable: false),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ozelliks",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        özellikadi = c.String(),
                        özellikid = c.String(),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.rezervasyons",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        musteriid = c.String(),
                        odaid = c.String(),
                        kisisayisi = c.String(),
                        checkindate = c.DateTime(nullable: false),
                        checkoutdate = c.DateTime(nullable: false),
                        odemezamanı = c.DateTime(nullable: false),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.yildizs",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        begenmesayisi = c.Int(nullable: false),
                        begenmemesayisi = c.Int(nullable: false),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.yorums",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        musteriid = c.String(),
                        yorumbas = c.String(),
                        yorumicer = c.String(),
                        yildiz = c.String(),
                        olusturmatar = c.String(),
                        olusturan = c.String(),
                        olusturmatarihi = c.DateTime(nullable: false),
                        guncellenmetarihi = c.DateTime(nullable: false),
                        guncelleyen = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ilces", "IL_id", "dbo.ILs");
            DropForeignKey("dbo.mahalleids", "Ilce_id", "dbo.Ilces");
            DropIndex("dbo.mahalleids", new[] { "Ilce_id" });
            DropIndex("dbo.Ilces", new[] { "IL_id" });
            DropTable("dbo.yorums");
            DropTable("dbo.yildizs");
            DropTable("dbo.rezervasyons");
            DropTable("dbo.ozelliks");
            DropTable("dbo.otelresimleris");
            DropTable("dbo.otelozelligis");
            DropTable("dbo.odas");
            DropTable("dbo.musteris");
            DropTable("dbo.ILs");
            DropTable("dbo.mahalleids");
            DropTable("dbo.Ilces");
        }
    }
}
