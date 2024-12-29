using Microsoft.EntityFrameworkCore;

namespace SampleWebapi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define your DbSets (tables) here
        public required DbSet<AppUser> Users { get; set; }
        public required DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var tbl = modelBuilder.Entity<AppUser>().ToTable("users");
            tbl.HasKey(u => u.User_Id);
            tbl.Property(u => u.User_Id).HasColumnName("user_id").ValueGeneratedOnAdd();
            tbl.Property(u => u.Display_Name).HasColumnName("display_name");
            tbl.Property(u => u.Country).HasColumnName("country");
            tbl.Property(u => u.Payload).HasColumnName("payload").HasColumnType("jsonb");
            // Configure your entity relationships and constraints here

            var roleTbl = modelBuilder.Entity<UserRole>().ToTable("user_roles");
            roleTbl.Property(r => r.Id).HasColumnName("id");
            roleTbl.Property(r => r.Role).HasColumnName("role");
        }
    }
}