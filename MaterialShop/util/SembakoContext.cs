using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SembakoShop.model;

namespace MaterialShop.util
{
    public class SembakoContext : DbContext
    {
        // Your context has been configured to use a 'SembakoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MaterialShop.ui.SembakoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SembakoContext' 
        // connection string in the application configuration file.
        public SembakoContext()
            : base("tokoMaterial")
        {
        }

        public virtual DbSet<Supplier> Suppliers { get; set; }

        public virtual DbSet<Kategori> Kategoris { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Karyawan> Karyawans { get; set; }

        public virtual DbSet<Barang> Barangs { get; set; }

        public virtual DbSet<Pembelian> Pembelians { get; set; }

        public virtual DbSet<DetailBeli> DetailBelis { get; set; }

        public virtual DbSet<Penjualan> Penjualans { get; set; }

        public virtual DbSet<DetailJual> DetailJuals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder
                .Entity<Karyawan>()
                .Property(k => k.NIK)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}