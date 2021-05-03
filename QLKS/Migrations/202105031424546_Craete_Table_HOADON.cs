namespace QLKS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Craete_Table_HOADON : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HOADONS",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 128),
                        MaKH = c.String(),
                        SoTien = c.Single(nullable: false),
                        NgayTT = c.String(),
                        HinhThucTT = c.String(),
                    })
                .PrimaryKey(t => t.MaHD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HOADONS");
        }
    }
}
