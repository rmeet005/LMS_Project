using LMS_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS_Project.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Pincodes> Pincodes { get; set; }
        public DbSet<RejectionReason> RejectionReasons { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<OccupationType> OccupationTypes { get; set; }
        public DbSet<DocumentType>DocumentTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Branch> Branches { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRoles>(ent =>
            {
                ent.HasOne(x => x.Roles)
                .WithMany(x =>x.userroles)
                .HasForeignKey(x => x.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            });
            modelBuilder.Entity<UserRoles>(ent =>
            {
                ent.HasOne(x => x.Users)
                .WithMany(x => x.userroles)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            });
            modelBuilder.Entity<States>(ent =>
            {
                ent.HasOne(x => x.Countries)
                .WithMany(x => x.States)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            });
            modelBuilder.Entity<Cities>(ent =>
            {
                ent.HasOne(x => x.States)
                .WithMany(x => x.Cities)
                .HasForeignKey(x => x.StateId)
                .OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<Pincodes>(ent =>
            {
                ent.HasOne(x => x.Cities)
                .WithMany(x => x.Pincodes)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Restrict);
                ent.HasOne(x => x.States)
                .WithMany(x => x.Pincodes)
                .HasForeignKey(x => x.StateId)
                .OnDelete(DeleteBehavior.Restrict);
                ent.HasOne(x => x.Countries)
                .WithMany(x => x.Pincodes)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
            });


        }
    }
}
