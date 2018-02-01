namespace MaterialShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nikNotIdentity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pembelian", "NIKRefId", "dbo.Karyawan");
            DropForeignKey("dbo.Penjualan", "NIKRefId", "dbo.Karyawan");
            DropPrimaryKey("dbo.Karyawan");
            AlterColumn("dbo.Karyawan", "NIK", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Karyawan", "NIK");
            AddForeignKey("dbo.Pembelian", "NIKRefId", "dbo.Karyawan", "NIK", cascadeDelete: true);
            AddForeignKey("dbo.Penjualan", "NIKRefId", "dbo.Karyawan", "NIK", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Penjualan", "NIKRefId", "dbo.Karyawan");
            DropForeignKey("dbo.Pembelian", "NIKRefId", "dbo.Karyawan");
            DropPrimaryKey("dbo.Karyawan");
            AlterColumn("dbo.Karyawan", "NIK", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Karyawan", "NIK");
            AddForeignKey("dbo.Penjualan", "NIKRefId", "dbo.Karyawan", "NIK", cascadeDelete: true);
            AddForeignKey("dbo.Pembelian", "NIKRefId", "dbo.Karyawan", "NIK", cascadeDelete: true);
        }
    }
}
