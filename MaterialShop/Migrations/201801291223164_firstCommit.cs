namespace MaterialShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barang",
                c => new
                    {
                        idBarang = c.Int(nullable: false, identity: true),
                        namaBarang = c.String(),
                        stok = c.Int(nullable: false),
                        harga = c.Int(nullable: false),
                        idKategoriRefId = c.Int(nullable: false),
                        createDate = c.DateTime(),
                        UpdDate = c.DateTime(),
                        delDate = c.DateTime(),
                        isDel = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idBarang)
                .ForeignKey("dbo.Kategori", t => t.idKategoriRefId, cascadeDelete: true)
                .Index(t => t.idKategoriRefId);
            
            CreateTable(
                "dbo.DetailBeli",
                c => new
                    {
                        idDetBeli = c.Int(nullable: false, identity: true),
                        idBeliRefId = c.Int(nullable: false),
                        idBarangRefId = c.Int(nullable: false),
                        idSupplierRefId = c.Int(nullable: false),
                        jmlBeli = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idDetBeli)
                .ForeignKey("dbo.Barang", t => t.idBarangRefId, cascadeDelete: true)
                .ForeignKey("dbo.Pembelian", t => t.idBeliRefId, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.idSupplierRefId, cascadeDelete: true)
                .Index(t => t.idBeliRefId)
                .Index(t => t.idBarangRefId)
                .Index(t => t.idSupplierRefId);
            
            CreateTable(
                "dbo.Pembelian",
                c => new
                    {
                        idPembelian = c.Int(nullable: false, identity: true),
                        namaPembelian = c.String(),
                        tglBeli = c.DateTime(),
                        NIKRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPembelian)
                .ForeignKey("dbo.Karyawan", t => t.NIKRefId, cascadeDelete: true)
                .Index(t => t.NIKRefId);
            
            CreateTable(
                "dbo.Karyawan",
                c => new
                    {
                        NIK = c.Int(nullable: false, identity: true),
                        namaKaryawan = c.String(),
                        jabatan = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.NIK);
            
            CreateTable(
                "dbo.Penjualan",
                c => new
                    {
                        idPenjualan = c.Int(nullable: false, identity: true),
                        tglJual = c.DateTime(),
                        idCustomerRefId = c.Int(nullable: false),
                        NIKRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPenjualan)
                .ForeignKey("dbo.Customer", t => t.idCustomerRefId, cascadeDelete: true)
                .ForeignKey("dbo.Karyawan", t => t.NIKRefId, cascadeDelete: true)
                .Index(t => t.idCustomerRefId)
                .Index(t => t.NIKRefId);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        idCustomer = c.Int(nullable: false, identity: true),
                        namaCustomer = c.String(),
                    })
                .PrimaryKey(t => t.idCustomer);
            
            CreateTable(
                "dbo.DetailJual",
                c => new
                    {
                        idDetJual = c.Int(nullable: false, identity: true),
                        idJualRefId = c.Int(nullable: false),
                        idBarangRefId = c.Int(nullable: false),
                        jmlJual = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idDetJual)
                .ForeignKey("dbo.Barang", t => t.idBarangRefId, cascadeDelete: true)
                .ForeignKey("dbo.Penjualan", t => t.idJualRefId, cascadeDelete: true)
                .Index(t => t.idJualRefId)
                .Index(t => t.idBarangRefId);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        idSupplier = c.Int(nullable: false, identity: true),
                        supplierName = c.String(),
                    })
                .PrimaryKey(t => t.idSupplier);
            
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        idKategori = c.Int(nullable: false, identity: true),
                        namaKategori = c.String(),
                    })
                .PrimaryKey(t => t.idKategori);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Barang", "idKategoriRefId", "dbo.Kategori");
            DropForeignKey("dbo.DetailBeli", "idSupplierRefId", "dbo.Supplier");
            DropForeignKey("dbo.Penjualan", "NIKRefId", "dbo.Karyawan");
            DropForeignKey("dbo.DetailJual", "idJualRefId", "dbo.Penjualan");
            DropForeignKey("dbo.DetailJual", "idBarangRefId", "dbo.Barang");
            DropForeignKey("dbo.Penjualan", "idCustomerRefId", "dbo.Customer");
            DropForeignKey("dbo.Pembelian", "NIKRefId", "dbo.Karyawan");
            DropForeignKey("dbo.DetailBeli", "idBeliRefId", "dbo.Pembelian");
            DropForeignKey("dbo.DetailBeli", "idBarangRefId", "dbo.Barang");
            DropIndex("dbo.DetailJual", new[] { "idBarangRefId" });
            DropIndex("dbo.DetailJual", new[] { "idJualRefId" });
            DropIndex("dbo.Penjualan", new[] { "NIKRefId" });
            DropIndex("dbo.Penjualan", new[] { "idCustomerRefId" });
            DropIndex("dbo.Pembelian", new[] { "NIKRefId" });
            DropIndex("dbo.DetailBeli", new[] { "idSupplierRefId" });
            DropIndex("dbo.DetailBeli", new[] { "idBarangRefId" });
            DropIndex("dbo.DetailBeli", new[] { "idBeliRefId" });
            DropIndex("dbo.Barang", new[] { "idKategoriRefId" });
            DropTable("dbo.Kategori");
            DropTable("dbo.Supplier");
            DropTable("dbo.DetailJual");
            DropTable("dbo.Customer");
            DropTable("dbo.Penjualan");
            DropTable("dbo.Karyawan");
            DropTable("dbo.Pembelian");
            DropTable("dbo.DetailBeli");
            DropTable("dbo.Barang");
        }
    }
}
