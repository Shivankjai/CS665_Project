using Microsoft.EntityFrameworkCore;
using OfficeDB_CRUD.Models;

namespace OfficeDB_CRUD.Data
{
    public class OfficeDbContext : DbContext
    {
        public OfficeDbContext(DbContextOptions<OfficeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<VendorRelation> VendorRelations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite key for VendorRelation
            modelBuilder.Entity<VendorRelation>()
                .HasKey(vr => new { vr.BranchId, vr.VendorId });

            // Configure relationships
            modelBuilder.Entity<VendorRelation>()
                .HasOne(vr => vr.Branch)
                .WithMany(b => b.VendorRelations)
                .HasForeignKey(vr => vr.BranchId);

            modelBuilder.Entity<VendorRelation>()
                .HasOne(vr => vr.Vendor)
                .WithMany(v => v.VendorRelations)
                .HasForeignKey(vr => vr.VendorId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Branch)
                .WithMany(b => b.Employees)
                .HasForeignKey(e => e.BranchId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Manager)
                .WithMany(m => m.ManagedEmployees)
                .HasForeignKey(e => e.ManagerId)
                .IsRequired(false);

            modelBuilder.Entity<Client>()
                .HasOne(c => c.Employee)
                .WithMany(e => e.Clients)
                .HasForeignKey(c => c.EmployeeId);
        }
    }
}