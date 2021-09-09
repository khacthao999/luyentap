namespace luyentap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Sinhvien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sinhviens",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 128),
                        TenSinhVien = c.String(),
                    })
                .PrimaryKey(t => t.MaSinhVien);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sinhviens");
        }
    }
}
