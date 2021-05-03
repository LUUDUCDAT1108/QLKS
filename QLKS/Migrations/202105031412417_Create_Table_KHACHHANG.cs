namespace QLKS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KHACHHANG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KHACHHANGS",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        HoTenKH = c.String(),
                        SoDT = c.String(),
                        CMCC = c.Int(nullable: false),
                        PhanLoaiKH = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KHACHHANGS");
        }
    }
}
