using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLKS.Models
{
    public partial class QLKSDbContext : DbContext
    {
        public QLKSDbContext()
            : base("name=QLKSDbContext")
        {
        }

        public virtual DbSet<KhachHang>KhachHangs { get; set; }
        public virtual DbSet<PHONG> PHONGS { get; set; }
        public virtual DbSet<DICHVU> DICHVUS { get; set; }
        public virtual DbSet<HOADON> HOADONS { get; set; }
        public virtual DbSet<THUEPHONG> THUEPHONGS { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
