namespace MaterialShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsdelete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Karyawan", "isDel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customer", "isDel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Supplier", "isDel", c => c.Boolean(nullable: false));
            AddColumn("dbo.Kategori", "isDel", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategori", "isDel");
            DropColumn("dbo.Supplier", "isDel");
            DropColumn("dbo.Customer", "isDel");
            DropColumn("dbo.Karyawan", "isDel");
        }
    }
}
