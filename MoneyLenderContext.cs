using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MoneyLenderBackend.DomainModel;
using MoneyLenderBackend.DomainModel.EntityConfiguration;

namespace MoneyLenderBackend {
    public class MoneyLenderContext : DbContext {
        public MoneyLenderContext (DbContextOptions<MoneyLenderContext> options) : base (options) {

        }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration<User> (new UserConfiguration ());
            modelBuilder.ApplyConfiguration<Login> (new LoginConfiguration ());
        }

    }
}