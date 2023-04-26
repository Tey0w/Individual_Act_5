using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rustia_3
{
    public class DataContext : DbContext
    {
        public DataContext(string connectionString) : base(connectionString)
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>().HasKey<int>(i => i.Id);
            modelBuilder.Entity<UserPermission>().HasKey<int>(ui => ui.ID);

            modelBuilder.Entity<User>()
            .Property(p => p.Branch)
            .HasColumnName("Branch")
            .HasColumnOrder(3)
            .HasColumnType("datetime2");

 
            modelBuilder.Entity<User>()
            .Property(p => p.Branch)
            .IsOptional();

            modelBuilder.Entity<User>()
            .Property(p => p.Branch)
            .IsRequired();

            modelBuilder.Entity<User>()
            .Property(p => p.Branch)
            .HasMaxLength(50);

        }

}
}