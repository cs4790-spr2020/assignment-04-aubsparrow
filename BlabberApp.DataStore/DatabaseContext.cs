using BlabberApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlabberApp.DataStore
{

    public class DatabaseContext : DbContext
    {
        public DbSet<Blab> BlabSet {get; set;}
        public DbSet<User> UserSet {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseMySQL("server=142.93.114;database=aubsparrow;user=aubsparrow;password=letmein");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.getSysId());
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.LastLoginDTTM).IsRequired();
                entity.Property(e => e.RegisterDTTM).IsRequired();
            });

            builder.Entity<Blab>(entity =>
            {
                entity.HasKey(e => e.getSysId());
                entity.Property(e => e.DTTM).IsRequired();
                entity.Property(e => e.Message).IsRequired();
                entity.Property(e => e.UserID).IsRequired();

            });
        } 
    }

}