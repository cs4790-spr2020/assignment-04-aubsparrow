using BlabberApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlabberApp.DataStore
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new BlabMap(builder.Entity<Blab>());
            new UserMap(builder.Entity<User>());
        } 
    }
}