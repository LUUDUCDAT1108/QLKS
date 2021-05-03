namespace QLKS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PHONG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PHONGS",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 128),
                        TenPhong = c.String(),
                        LoaiPhong = c.String(),
                        TrangThai = c.String(),
                        GiaPhong = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhong);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PHONGS");
        }
    }
}
