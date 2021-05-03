namespace QLKS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_THUEPHONG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.THUEPHONGS",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        NgayDen = c.String(),
                        NgayDi = c.String(),
                        ThanhToan = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.THUEPHONGS");
        }
    }
}
