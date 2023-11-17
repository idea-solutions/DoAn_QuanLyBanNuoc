namespace DoAn_QuanLyBanNuoc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ACCOUNT",
                c => new
                    {
                        ACCOUNTID = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        PASSWORD = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        FULLNAME = c.String(nullable: false),
                        PHONENUM = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        DATE = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.ACCOUNTID);
            
            CreateTable(
                "dbo.ORDER_TABLE",
                c => new
                    {
                        IDBAN = c.String(nullable: false, maxLength: 6, fixedLength: true, unicode: false),
                        IDORDER = c.Int(nullable: false),
                        ACCOUNTID = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        IDNUOC = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        SOLUONGNUOC = c.Int(nullable: false),
                        TONGTIEN = c.Long(nullable: false),
                        THOIGIAN = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.IDBAN, t.IDORDER })
                .ForeignKey("dbo.BAN", t => t.IDBAN)
                .ForeignKey("dbo.NUOC", t => t.IDNUOC)
                .ForeignKey("dbo.ACCOUNT", t => t.ACCOUNTID)
                .Index(t => t.IDBAN)
                .Index(t => t.ACCOUNTID)
                .Index(t => t.IDNUOC);
            
            CreateTable(
                "dbo.BAN",
                c => new
                    {
                        IDBAN = c.String(nullable: false, maxLength: 6, fixedLength: true, unicode: false),
                        DACHON = c.Boolean(),
                    })
                .PrimaryKey(t => t.IDBAN);
            
            CreateTable(
                "dbo.NUOC",
                c => new
                    {
                        IDNUOC = c.String(nullable: false, maxLength: 5, fixedLength: true, unicode: false),
                        TENNUOC = c.String(nullable: false, maxLength: 50),
                        GIA = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.IDNUOC);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ORDER_TABLE", "ACCOUNTID", "dbo.ACCOUNT");
            DropForeignKey("dbo.ORDER_TABLE", "IDNUOC", "dbo.NUOC");
            DropForeignKey("dbo.ORDER_TABLE", "IDBAN", "dbo.BAN");
            DropIndex("dbo.ORDER_TABLE", new[] { "IDNUOC" });
            DropIndex("dbo.ORDER_TABLE", new[] { "ACCOUNTID" });
            DropIndex("dbo.ORDER_TABLE", new[] { "IDBAN" });
            DropTable("dbo.NUOC");
            DropTable("dbo.BAN");
            DropTable("dbo.ORDER_TABLE");
            DropTable("dbo.ACCOUNT");
        }
    }
}
